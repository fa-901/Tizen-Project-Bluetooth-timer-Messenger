/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include <time.h>

#include "config.h"

#include "view/edit-view.h"
#include "view/recurrence-view.h"

#include "utils/ui-utils.h"
#include "utils/logger.h"
#include "utils/event-record.h"
#include "utils/settings-utils.h"

typedef struct {
	window_obj			*win;
	Evas_Object			*naviframe;
	Elm_Object_Item		*naviframe_item;

	Evas_Object			*layout;
	Evas_Object			*genlist;

	event_data			*view_parent_data;
	event_data			*view_temporary_data;

	Evas_Object			*title_entry;
	Evas_Object			*location_entry;
	Evas_Object			*description_entry;

	Evas_Object			*start_datetime;
	Evas_Object			*end_datetime;
	Evas_Object			*start_date_btn;
	Evas_Object			*start_time_btn;
	Evas_Object			*end_date_btn;
	Evas_Object			*end_time_btn;
	Evas_Object			*allday_btn;
	Evas_Object			*reminder_btn;
	Evas_Object			*recurrence_btn;
	Evas_Object			*priority_btn;
	Evas_Object			*sensitivity_btn;
	Evas_Object			*status_btn;

	Evas_Object			*popup;
	Evas_Object			*date_time_popup;

	calendar_alarm_time_unit_type_e		reminder_type;
	int 								reminder_number;

	recurrence_repeat_data				recurrence_data;
	calendar_event_priority_e			priority;
	calendar_sensitivity_e				sensitivity;
	calendar_event_status_e				status;

	struct tm			stm; /* start */
	struct tm			etm; /* end */

	Eina_Bool			is_allday;

	Elm_Object_Item		*genlist_from_item;
	Elm_Object_Item		*genlist_to_item;
	Elm_Object_Item		*genlist_reminder_item;
	Elm_Object_Item		*genlist_location_item;
	Elm_Object_Item		*genlist_description_item;


	calendar_record_h	event_record;

	Evas_Object		*reminder_ctxpopup;
	Evas_Object		*context_popup;

} edit_view_data;

static char *_set_object_label(const char *format, const char *label)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer), format, get_system_font_size(), label);
	return strdup(buffer);
}

static bool _close_active_popup(edit_view_data *view_data)
{
	RETVM_IF(!view_data, false, "view_data is NULL");

	if (view_data->context_popup) {
		evas_object_del(view_data->context_popup);
		view_data->context_popup = NULL;
		return true;
	} else if (view_data->popup) {
		evas_object_del(view_data->popup);
		view_data->popup = NULL;
		return true;
	} else if (view_data->date_time_popup) {
		Evas_Object *obj = elm_object_content_get(view_data->date_time_popup);
		elm_object_content_unset(view_data->date_time_popup);
		evas_object_hide(obj);
		evas_object_del(view_data->date_time_popup);
		view_data->date_time_popup = NULL;
		return true;
	} else if (view_data->reminder_ctxpopup) {
		evas_object_del(view_data->reminder_ctxpopup);
		view_data->reminder_ctxpopup = NULL;
		return true;
	}

	return false;
}

static void _scroll_genlist_top_cb(void *data, Evas_Object *obj, void *event_info)
{
	edit_view_data *ad = (edit_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");

	if (ad->genlist_location_item == (Elm_Object_Item *)event_info
	|| ad->genlist_description_item == (Elm_Object_Item *)event_info
	|| ad->genlist_reminder_item == (Elm_Object_Item *)event_info) {
		elm_genlist_item_show((Elm_Object_Item *)event_info, ELM_GENLIST_ITEM_SCROLLTO_MIDDLE);
	}
}

static void _location_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;
	event_data_set_value(view_data->view_temporary_data, EVENT_DATA_LOCATION, elm_entry_entry_get(obj));
}

static void _description_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	event_data_set_value(view_data->view_temporary_data, EVENT_DATA_DESCRIPTION, elm_entry_entry_get(obj));
}

static void _title_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	event_data_set_value(view_data->view_temporary_data, EVENT_DATA_TITLE, elm_entry_entry_get(obj));
}

/**
 * Add title entry to edit-view layout
 *
 * @param[in]	data	Data used in this function
 * @param[in]	part	The container's part name to set (some might accept
 *						@c NULL for the default part)
 * @param[in]	func	Func the callback function
 *
 * @return				An entry object
 */
static Evas_Object *_prepare_entry_box(edit_view_data *item_data, Evas_Object *entry, const char *name, const char *hint, const char *text, Evas_Smart_Cb func)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	edit_view_data *data = (edit_view_data *)item_data;

	Evas_Object *box = elm_box_add(data->genlist);
	elm_box_horizontal_set(box, EINA_TRUE);
	evas_object_size_hint_min_set(box, 0, ELM_ENTRY_MIN_HEIGHT);
	evas_object_show(box);

	Evas_Object *rect1 = evas_object_rectangle_add(box);
	evas_object_color_set(rect1, 0, 0, 0, 0);
	evas_object_size_hint_min_set(rect1, ELM_ENTRY_SPACER_WIDTH, ELM_ENTRY_MIN_HEIGHT);
	evas_object_show(rect1);

	Evas_Object *rect2 = evas_object_rectangle_add(box);
	evas_object_color_set(rect2, 0, 0, 0, 0);
	evas_object_size_hint_min_set(rect2, ELM_ENTRY_SPACER_WIDTH, ELM_ENTRY_MIN_HEIGHT);
	evas_object_show(rect2);

	Evas_Object *label = elm_label_add(box);
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, ENTRY_LABEL_FORMAT, get_system_font_size(), name);
	elm_object_text_set(label, buffer);
	evas_object_show(label);

	entry = elm_entry_add(box);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_scroller_policy_set(entry, ELM_SCROLLER_POLICY_AUTO, ELM_SCROLLER_POLICY_OFF);
	snprintf(buffer, sizeof(buffer) - 1, STYLE_FORMAT, get_system_font_size());
	elm_entry_text_style_user_push(entry, buffer);
	Elm_Entry_Filter_Limit_Size limit = {SUBJECT_CHAR_LIMIT, SUBJECT_BYTE_LIMIT};
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &limit);
	elm_entry_cursor_end_set(entry);
	elm_entry_cnp_mode_set(entry, ELM_CNP_MODE_PLAINTEXT);

	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);

	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), hint);
	elm_object_part_text_set(entry, "elm.guide", buffer);
	evas_object_smart_callback_add(entry, "changed", func, data);
	evas_object_show(entry);

	elm_object_part_text_set(entry, "elm.text", text);

	elm_box_pack_end(box, rect1);
	elm_box_pack_end(box, label);
	elm_box_pack_end(box, rect2);
	elm_box_pack_end(box, entry);

	return box;
}

/**
 * Add title entry to edit-view layout
 *
 * @param[in]	data	Data used in this function
 *
 * @return				An entry object
 */
static Evas_Object *_entry_add(edit_view_data *data, ENTRY_TYPE entry_type)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");

	Evas_Object *box = NULL;
	switch (entry_type) {
		case TITLE_ENTRY:
			box = _prepare_entry_box(data, data->title_entry, TITLE, TITLE_HINT, event_data_get_value(data->view_temporary_data, EVENT_DATA_TITLE), _title_entry_changed_cb);
			break;
		case LOCATION_ENTRY:
			box = _prepare_entry_box(data, data->location_entry, LOCATION, LOCATION_HINT, event_data_get_value(data->view_temporary_data, EVENT_DATA_LOCATION), _location_entry_changed_cb);
			break;
		case DESCRIPTION_ENTRY:
			box = _prepare_entry_box(data, data->description_entry, DESCRIPTION, DESCRIPTION_HINT, event_data_get_value(data->view_temporary_data, EVENT_DATA_DESCRIPTION), _description_entry_changed_cb);
			break;
		default:
			break;
	}

	return box;
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static Evas_Object *_title_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	edit_view_data *data = (edit_view_data *)item_data;

	return _entry_add(data, TITLE_ENTRY);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Entry object
 */
static Evas_Object *_location_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	edit_view_data *data = (edit_view_data *)item_data;

	return _entry_add(data, LOCATION_ENTRY);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Entry object
 */
static Evas_Object *_description_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	edit_view_data *data = (edit_view_data *)item_data;

	return _entry_add(data, DESCRIPTION_ENTRY);
}

static char *_start_datetime_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, FROM);
}

static void _on_datetime_popup_cancel_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	edit_view_data *view = data;
	_close_active_popup(view);
}

static void _on_datetime_popup_set_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	edit_view_data *view = (edit_view_data *)data;

	Elm_Object_Item *selected_item = elm_genlist_selected_item_get(view->genlist);

	if (selected_item == view->genlist_from_item) {
		elm_datetime_value_get(view->start_datetime, &view->stm);
		char buffer[DATE_TIME_BUF_LEN] = {0};
		snprintf(buffer, sizeof(buffer) - 1, "%s %s",
			elm_object_text_get(view->start_date_btn),
			elm_object_text_get(view->start_time_btn));
		event_data_set_value(view->view_parent_data, EVENT_DATA_START_DATE, buffer);
		memset(buffer, '\0', DATE_TIME_BUF_LEN);
		_close_active_popup(view);
	} else if (selected_item == view->genlist_to_item) {
		elm_datetime_value_get(view->end_datetime, &view->etm);
		char buffer[DATE_TIME_BUF_LEN] = {0};
		snprintf(buffer, sizeof(buffer) - 1, "%s %s",
			elm_object_text_get(view->end_date_btn),
			elm_object_text_get(view->end_time_btn));
		event_data_set_value(view->view_parent_data, EVENT_DATA_END_DATE, buffer);
		memset(buffer, '\0', DATE_TIME_BUF_LEN);
		_close_active_popup(view);
	}

	elm_genlist_item_update(selected_item);
}

static Evas_Object *_date_time_popup_add(Evas_Object *parent, edit_view_data *view,
										Evas_Smart_Cb set_cb, Evas_Smart_Cb cancel_cb)
{
	Evas_Object *popup = elm_popup_add(parent);
	view->date_time_popup = popup;

	elm_popup_orient_set(popup, ELM_POPUP_ORIENT_CENTER);
	evas_object_show(popup);

	Evas_Object *cancel_btn = elm_button_add(popup);
	elm_object_style_set(cancel_btn, "popup");
	elm_object_text_set(cancel_btn, CANCEL);
	elm_object_part_content_set(popup, "button1", cancel_btn);
	evas_object_smart_callback_add(cancel_btn, "clicked", cancel_cb, view);

	Evas_Object *set_btn = elm_button_add(popup);
	elm_object_style_set(set_btn, "popup");
	elm_object_text_set(set_btn, SET);
	elm_object_part_content_set(popup, "button2", set_btn);
	evas_object_smart_callback_add(set_btn, "clicked", set_cb, view);

	return popup;
}

static void _get_start_datetime(edit_view_data *view, Evas_Object *parent, const char *format)
{
	if (!view->start_datetime) {
		view->start_datetime = elm_datetime_add(parent);
		evas_object_size_hint_weight_set(view->start_datetime, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(view->start_datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
	}

	elm_datetime_value_set(view->start_datetime, &view->stm);
	elm_datetime_format_set(view->start_datetime, format);
	evas_object_show(view->start_datetime);
}

static void _get_end_datetime(edit_view_data *view, Evas_Object *parent, const char *format)
{
	if (!view->end_datetime) {
		view->end_datetime = elm_datetime_add(parent);
		evas_object_size_hint_weight_set(view->end_datetime, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(view->end_datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
	}

	elm_datetime_value_set(view->end_datetime, &view->etm);
	elm_datetime_format_set(view->end_datetime, format);
	evas_object_show(view->end_datetime);
}

static void _start_date_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	edit_view_data *view = (edit_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_start_datetime(view, popup, "%d %b %Y");

	elm_object_content_set(popup, view->start_datetime);
}

static void _start_time_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	edit_view_data *view = (edit_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_start_datetime(view, popup, "%R");

	elm_object_content_set(popup, view->start_datetime);
}

static void _end_date_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	edit_view_data *view = (edit_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_end_datetime(view, popup, "%d %b %Y");

	elm_object_content_set(popup, view->end_datetime);
}

static void _end_time_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	edit_view_data *view = (edit_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_end_datetime(view, popup, "%R");

	elm_object_content_set(popup, view->end_datetime);
}

static Evas_Object *_start_datetime_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	edit_view_data *data = (edit_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *box = elm_box_add(obj);
		elm_box_horizontal_set(box, EINA_TRUE);
		elm_box_padding_set(box, ELM_BOX_PADDING, ELM_BOX_PADDING);
		elm_box_align_set(box, 0.0, 0.5);
		evas_object_show(box);

		data->start_date_btn = elm_button_add(box);
		evas_object_show(data->start_date_btn);
		evas_object_smart_callback_add(data->start_date_btn, "clicked", _start_date_btn_cb, data);

		char buf[DATE_TIME_BUF_LEN] = {0};
		strftime(buf, DATE_TIME_BUF_LEN, "%x", &data->stm);
		elm_object_text_set(data->start_date_btn, buf);

		evas_object_size_hint_weight_set(data->start_date_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_min_set(data->start_date_btn, ELM_BUTTON_DATE_WIDTH, ELM_BUTTON_HEIGHT);
		elm_box_pack_end(box, data->start_date_btn);

		if (!data->is_allday) {
			data->start_time_btn = elm_button_add(box);
			evas_object_show(data->start_time_btn);
			evas_object_smart_callback_add(data->start_time_btn, "clicked", _start_time_btn_cb, data);

			strftime(buf, DATE_TIME_BUF_LEN, "%R", &data->stm);
			elm_object_text_set(data->start_time_btn, buf);
			evas_object_size_hint_weight_set(data->start_time_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_min_set(data->start_time_btn, ELM_BUTTON_TIME_WIDTH, ELM_BUTTON_HEIGHT);
			elm_box_pack_end(box, data->start_time_btn);
		}

		return box;
	}

	return NULL;
}

static char *_end_datetime_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, TO);
}

static Evas_Object *_end_datetime_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	edit_view_data *data = (edit_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *box = elm_box_add(obj);
		elm_box_horizontal_set(box, EINA_TRUE);
		elm_box_padding_set(box, ELM_BOX_PADDING, ELM_BOX_PADDING);
		evas_object_show(box);

		data->end_date_btn = elm_button_add(box);
		evas_object_show(data->end_date_btn);
		evas_object_smart_callback_add(data->end_date_btn, "clicked", _end_date_btn_cb, data);

		char buf[DATE_TIME_BUF_LEN] = {0};
		strftime(buf, DATE_TIME_BUF_LEN, "%x", &data->etm);
		elm_object_text_set(data->end_date_btn, buf);

		evas_object_size_hint_weight_set(data->end_date_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_min_set(data->end_date_btn, ELM_BUTTON_DATE_WIDTH, ELM_BUTTON_HEIGHT);

		elm_box_pack_end(box, data->end_date_btn);

		data->end_datetime = elm_datetime_add(data->layout);
		evas_object_size_hint_weight_set(data->end_datetime, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(data->end_datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);

		if (!data->is_allday) {
			data->end_time_btn = elm_button_add(box);
			evas_object_show(data->end_time_btn);
			evas_object_smart_callback_add(data->end_time_btn, "clicked", _end_time_btn_cb, data);

			strftime(buf, DATE_TIME_BUF_LEN, "%R", &data->etm);
			elm_object_text_set(data->end_time_btn, buf);
			evas_object_size_hint_weight_set(data->end_time_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_min_set(data->end_time_btn, ELM_BUTTON_TIME_WIDTH, ELM_BUTTON_HEIGHT);
			elm_box_pack_end(box, data->end_time_btn);
		}

		return box;
	}

	return NULL;
}

static char *_timezone_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, TIME_ZONE);
}

static Evas_Object *_timezone_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;
	if (strcmp(part, "elm.swallow.end") != 0) {
		return NULL;
	}

	Evas_Object *label = elm_label_add(view_data->layout);

	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), event_data_get_value(view_data->view_temporary_data, EVENT_DATA_TIMEZONE));
	elm_object_text_set(label, buffer);

	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(label, EVAS_HINT_FILL, EVAS_HINT_FILL);

	return label;
}

static char *_allday_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, ALL_DAY);
}

static void _allday_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view = (edit_view_data *)data;

	view->is_allday = !view->is_allday;
	char buffer_start[DATE_TIME_BUF_LEN] = {0};
	char buffer_end[DATE_TIME_BUF_LEN] = {0};

	if(view->is_allday) {
		event_data_set_value(view->view_temporary_data, EVENT_DATA_ALL_DAY, YES);
		snprintf(buffer_start, sizeof(buffer_start) - 1, "%s",
			elm_object_text_get(view->start_date_btn));
		snprintf(buffer_end, sizeof(buffer_end) - 1, "%s",
			elm_object_text_get(view->end_date_btn));
	} else {
		event_data_set_value(view->view_temporary_data, EVENT_DATA_ALL_DAY, NO);
		snprintf(buffer_start, sizeof(buffer_start) - 1, "%s 00:00",
			elm_object_text_get(view->start_date_btn));
		snprintf(buffer_end, sizeof(buffer_end) - 1, "%s 00:00",
			elm_object_text_get(view->start_date_btn));
	}

	event_data_set_value(view->view_temporary_data, EVENT_DATA_START_DATE, buffer_start);
	event_data_set_value(view->view_temporary_data, EVENT_DATA_END_DATE, buffer_end);
	memset(buffer_start, '\0', DATE_TIME_BUF_LEN);
	memset(buffer_end, '\0', DATE_TIME_BUF_LEN);

	elm_genlist_item_update(view->genlist_from_item);
	elm_genlist_item_update(view->genlist_to_item);
}

static Evas_Object *_allday_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	if (strcmp(part, "elm.swallow.end") != 0) {
		return NULL;
	}

	view_data->allday_btn = elm_check_add(view_data->layout);

	elm_object_style_set(view_data->allday_btn, "on&off");
	elm_check_state_set(view_data->allday_btn, view_data->is_allday);
	evas_object_propagate_events_set(view_data->allday_btn, EINA_FALSE);
	evas_object_smart_callback_add(view_data->allday_btn, "changed", _allday_changed_cb, view_data);

	return view_data->allday_btn;
}

static char *_reminder_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, REMINDER);
}

static void _reminder_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	edit_view_data *ad = (edit_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");

	evas_object_del(ad->reminder_ctxpopup);
	ad->reminder_ctxpopup = NULL;

	if (!data) {
		return;
	}

	char *name = (char *)data;
	calendar_alarm_time_unit_type_e reminder = settings_reminder_type_get(name);
	elm_object_text_set(ad->reminder_btn, name);
	evas_object_size_hint_weight_set(ad->reminder_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->reminder_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(ad->reminder_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
	ad->reminder_type = reminder;
	event_data_set_value(ad->view_temporary_data, EVENT_DATA_REMINDER, name);
}

static void _show_reminder_context_popup(edit_view_data *ad)
{
	ad->reminder_ctxpopup = elm_ctxpopup_add(ad->layout);
	evas_object_data_set(ad->reminder_ctxpopup, KEY_PRIORITY_DATA, ad);

	int i;
	for (i = 0; i < reminder_info_size; i++) {
		elm_ctxpopup_item_append(ad->reminder_ctxpopup, reminder_info[i].name, NULL, _reminder_btn_lable_changed_cb, (void *)reminder_info[i].name);
	}

	evas_object_size_hint_weight_set(ad->reminder_ctxpopup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0;
	int y = 0;
	evas_object_geometry_get(ad->reminder_btn, &x, &y, NULL, NULL);
	evas_object_move(ad->reminder_ctxpopup, x, y);
	evas_object_smart_callback_add(ad->reminder_ctxpopup, "dismissed", _reminder_btn_lable_changed_cb, NULL);

	evas_object_show(ad->reminder_ctxpopup);
}

static void _reminder_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	edit_view_data *ad = (edit_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	if (!ad->reminder_ctxpopup) {
	_show_reminder_context_popup(ad);
	} else {
		evas_object_del(ad->reminder_ctxpopup);
		ad->reminder_ctxpopup = NULL;
	}
}

static Evas_Object *_reminder_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;
	Evas_Object *layout = NULL;

	if (strcmp(part, "elm.swallow.end") == 0) {
		layout = elm_layout_add(view_data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			view_data->reminder_btn = elm_button_add(layout);
			elm_object_text_set(view_data->reminder_btn, event_data_get_value(view_data->view_temporary_data, EVENT_DATA_REMINDER));
			evas_object_smart_callback_add(view_data->reminder_btn, "clicked", _reminder_btn_clicked_cb, view_data);
			evas_object_size_hint_weight_set(view_data->reminder_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(view_data->reminder_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(view_data->reminder_btn, ELM_SCALE_SIZE(BUTTON_WIDTH), ELM_SCALE_SIZE(BUTTON_HEIGHT));
			elm_layout_content_set(layout, "elm.swallow.content", view_data->reminder_btn);
		}
	}

	return layout;
}

static char *_recurrence_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, RECURRENCE);
}

static void _recurrence_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	edit_view_data *ad = (edit_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");

	switch (ad->recurrence_data.id) {
		case CALENDAR_RECURRENCE_NONE:
			elm_object_text_set(ad->recurrence_btn, "None");
			break;
		case CALENDAR_RECURRENCE_DAILY:
			elm_object_text_set(ad->recurrence_btn, "Daily");
			break;
		case CALENDAR_RECURRENCE_WEEKLY:
			elm_object_text_set(ad->recurrence_btn, "Weekly");
			break;
		case CALENDAR_RECURRENCE_MONTHLY:
			elm_object_text_set(ad->recurrence_btn, "Monthly");
			break;
		case CALENDAR_RECURRENCE_YEARLY:
			elm_object_text_set(ad->recurrence_btn, "Yearly");
			break;
		default:
			break;
	}
	evas_object_size_hint_weight_set(ad->recurrence_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->recurrence_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(ad->recurrence_btn, ELM_SCALE_SIZE(BUTTON_WIDTH), ELM_SCALE_SIZE(BUTTON_HEIGHT));
	event_data_set_value(ad->view_temporary_data, EVENT_DATA_RECURRENCE, elm_object_text_get(ad->recurrence_btn));
}

static void _recurrence_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	edit_view_data *ad = (edit_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	recurrence_view_add(ad->win, ad->naviframe, &ad->recurrence_data, _recurrence_btn_lable_changed_cb, ad);
}

static void _btn_recurrence_text_get(void *data)
{
	if (!data) {
		return;
	}

	edit_view_data *details_data = (edit_view_data *)data;
	int freq = CALENDAR_RECURRENCE_NONE;
	char *id_str = NULL;

	if (CALENDAR_ERROR_NONE == calendar_record_get_str(details_data->event_record, _calendar_event.recurrence_id, &id_str)) {
		if (id_str) {
			freq = atoi(id_str);
			free(id_str);
		} else {
			calendar_record_get_int(details_data->event_record, _calendar_event.freq, &freq);
		}
	}

	details_data->recurrence_data.id = freq;

	int range_type = 0;
	calendar_error_e error = calendar_record_get_int(details_data->event_record, _calendar_event.range_type, &range_type);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);
	details_data->recurrence_data.range_type = range_type;

	error = calendar_record_get_int(details_data->event_record, _calendar_event.count, &details_data->recurrence_data.count);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);

	calendar_time_s cal_until_time;
	memset(&cal_until_time, 0x0, sizeof(cal_until_time));
	error = calendar_record_get_caltime(details_data->event_record, _calendar_event.until_time, &cal_until_time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_caltime() is failed(%x)", error);
	time_t start_time = cal_until_time.time.utime;
	details_data->recurrence_data.tm = *localtime(&start_time);
	if (cal_until_time.type == CALENDAR_TIME_LOCALTIME) {
		details_data->recurrence_data.tm.tm_year = cal_until_time.time.date.year - TM_START_YEAR;
		details_data->recurrence_data.tm.tm_mon = cal_until_time.time.date.month - TM_START_MONTH;
		details_data->recurrence_data.tm.tm_mday = cal_until_time.time.date.mday;
	}
}

static Evas_Object *_recurrence_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(view_data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			view_data->recurrence_btn = elm_button_add(layout);
			elm_object_text_set(view_data->recurrence_btn, event_data_get_value(view_data->view_temporary_data, EVENT_DATA_RECURRENCE));
			evas_object_smart_callback_add(view_data->recurrence_btn, "clicked", _recurrence_btn_clicked_cb, data);
			evas_object_size_hint_weight_set(view_data->recurrence_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(view_data->recurrence_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(view_data->recurrence_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
			elm_layout_content_set(layout, "elm.swallow.content", view_data->recurrence_btn);
			return layout;
		}
	}
	return NULL;
}

static char *_priority_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, PRIORITY);
}

static void _set_priority(edit_view_data *view_data, int priority)
{
	RETM_IF(!view_data, "Passed NULL input data");

	switch (priority) {
		case CALENDAR_EVENT_PRIORITY_LOW:
			elm_object_text_set(view_data->priority_btn, "Low");
			view_data->priority = priority;
			break;
		case CALENDAR_EVENT_PRIORITY_NORMAL:
			elm_object_text_set(view_data->priority_btn, "Normal");
			view_data->priority = priority;
			break;
		case CALENDAR_EVENT_PRIORITY_HIGH:
			elm_object_text_set(view_data->priority_btn, "High");
			view_data->priority = priority;
			break;
		default:
			ERR("set_priority illegal priority");
			break;
	}
	evas_object_size_hint_weight_set(view_data->priority_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(view_data->priority_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(view_data->priority_btn, ELM_SCALE_SIZE(BUTTON_WIDTH), ELM_SCALE_SIZE(BUTTON_HEIGHT));
	event_data_set_value(view_data->view_temporary_data, EVENT_DATA_PRIORITY, elm_object_text_get(view_data->priority_btn));
}

static void _delete_context_popup(edit_view_data *view_data)
{
	if (view_data && view_data->context_popup) {
		evas_object_del(view_data->context_popup);
		view_data->context_popup = NULL;
	}
}

static void _set_low_priority_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_priority(view_data, CALENDAR_EVENT_PRIORITY_LOW);
}

static void _set_normal_priority_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_priority(view_data, CALENDAR_EVENT_PRIORITY_NORMAL);
}

static void _set_high_priority_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_priority(view_data, CALENDAR_EVENT_PRIORITY_HIGH);
}

static void _context_popup_dismiss_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);
}

static void _priority_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	view_data->context_popup = elm_ctxpopup_add(view_data->layout);
	elm_ctxpopup_item_append(view_data->context_popup, "Low", NULL, _set_low_priority_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "Normal", NULL, _set_normal_priority_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "High", NULL, _set_high_priority_cb, view_data);

	evas_object_size_hint_weight_set(view_data->context_popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0, y = 0;
	evas_object_geometry_get(obj, &x, &y, NULL, NULL);
	evas_object_move(view_data->context_popup, x, y);
	evas_object_smart_callback_add(view_data->context_popup, "dismissed", _context_popup_dismiss_cb, view_data);

	evas_object_show(view_data->context_popup);
}

static Evas_Object *_priority_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(view_data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			view_data->priority_btn = elm_button_add(layout);
			_set_priority(view_data, view_data->priority);
			evas_object_smart_callback_add(view_data->priority_btn, "clicked", _priority_button_cb, view_data);
			elm_layout_content_set(layout, "elm.swallow.content", view_data->priority_btn);
			return layout;
		}
	}

	return NULL;
}

static char *_sensitivity_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, SENSITIVITY);
}

static void _set_sensitivity(edit_view_data *view_data, int sensitivity)
{
	RETM_IF(!view_data, "Passed NULL input data");

	switch (sensitivity) {
		case CALENDAR_SENSITIVITY_PUBLIC:
			elm_object_text_set(view_data->sensitivity_btn, "Public");
			view_data->sensitivity = sensitivity;
			break;
		case CALENDAR_SENSITIVITY_PRIVATE:
			elm_object_text_set(view_data->sensitivity_btn, "Private");
			view_data->sensitivity = sensitivity;
			break;
		case CALENDAR_SENSITIVITY_CONFIDENTIAL:
			elm_object_text_set(view_data->sensitivity_btn, "Confidential");
			view_data->sensitivity = sensitivity;
			break;
		default:
			ERR("set_sensitivity illegal priority");
			break;
	}
	evas_object_size_hint_weight_set(view_data->sensitivity_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(view_data->sensitivity_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(view_data->sensitivity_btn, ELM_SCALE_SIZE(BUTTON_WIDTH), ELM_SCALE_SIZE(BUTTON_HEIGHT));
	event_data_set_value(view_data->view_temporary_data, EVENT_DATA_SENSITIVITY, elm_object_text_get(view_data->sensitivity_btn));
}

static void _set_public_sensitivity_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_sensitivity(view_data, CALENDAR_SENSITIVITY_PUBLIC);
}

static void _set_private_sensitivity_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_sensitivity(view_data, CALENDAR_SENSITIVITY_PRIVATE);
}

static void _set_confidential_sensitivity_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_sensitivity(view_data, CALENDAR_SENSITIVITY_CONFIDENTIAL);
}

static void _sensitivity_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	view_data->context_popup = elm_ctxpopup_add(view_data->layout);
	elm_ctxpopup_item_append(view_data->context_popup, "Public", NULL, _set_public_sensitivity_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "Private", NULL, _set_private_sensitivity_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "Confidential", NULL, _set_confidential_sensitivity_cb, view_data);

	evas_object_size_hint_weight_set(view_data->context_popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0, y = 0;
	evas_object_geometry_get(obj, &x, &y, NULL, NULL);
	evas_object_move(view_data->context_popup, x, y);
	evas_object_smart_callback_add(view_data->context_popup, "dismissed", _context_popup_dismiss_cb, view_data);

	evas_object_show(view_data->context_popup);
}

static Evas_Object *_sensivity_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(view_data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			view_data->sensitivity_btn = elm_button_add(layout);
			_set_sensitivity(view_data, view_data->sensitivity);
			evas_object_smart_callback_add(view_data->sensitivity_btn, "clicked", _sensitivity_button_cb, view_data);
			elm_layout_content_set(layout, "elm.swallow.content", view_data->sensitivity_btn);
			return layout;
		}
	}

	return NULL;
}

static char *_status_label_cb(void *data, Evas_Object *obj, const char *part)
{
	return _set_object_label(LABEL_FORMAT, STATUS);
}

static void _set_status(edit_view_data *view_data, int status)
{
	RETM_IF(!view_data, "Passed NULL input data");

	elm_object_text_set(view_data->status_btn, settings_status_name_get(status));

	evas_object_size_hint_weight_set(view_data->status_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(view_data->status_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(view_data->status_btn, ELM_SCALE_SIZE(BUTTON_WIDTH), ELM_SCALE_SIZE(BUTTON_HEIGHT));
	event_data_set_value(view_data->view_temporary_data, EVENT_DATA_STATUS, elm_object_text_get(view_data->status_btn));
	view_data->status = status;
}

static void _set_none_status_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_status(view_data, CALENDAR_EVENT_STATUS_NONE);
}

static void _set_confirmed_status_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_status(view_data, CALENDAR_EVENT_STATUS_CONFIRMED);
}

static void _set_cancelled_status_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_status(view_data, CALENDAR_EVENT_STATUS_CANCELLED);
}

static void _set_tentative_status_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	_set_status(view_data, CALENDAR_EVENT_STATUS_TENTATIVE);
}

static void _status_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	_delete_context_popup(view_data);

	view_data->context_popup = elm_ctxpopup_add(view_data->layout);
	elm_ctxpopup_item_append(view_data->context_popup, "None", NULL, _set_none_status_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "Confirmed", NULL, _set_confirmed_status_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "Cancelled", NULL, _set_cancelled_status_cb, view_data);
	elm_ctxpopup_item_append(view_data->context_popup, "Tentative", NULL, _set_tentative_status_cb, view_data);

	evas_object_size_hint_weight_set(view_data->context_popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0, y = 0;
	evas_object_geometry_get(obj, &x, &y, NULL, NULL);
	evas_object_move(view_data->context_popup, x, y);
	evas_object_smart_callback_add(view_data->context_popup, "dismissed", _context_popup_dismiss_cb, view_data);

	evas_object_show(view_data->context_popup);
}

static Evas_Object *_status_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(view_data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			view_data->status_btn = elm_button_add(layout);
			_set_status(view_data, view_data->status);
			evas_object_smart_callback_add(view_data->status_btn, "clicked", _status_button_cb, view_data);
			elm_layout_content_set(layout, "elm.swallow.content", view_data->status_btn);
			return layout;
		}
	}

	return NULL;
}

static bool _is_title_valid(const char *title)
{
	RETVM_IF(!title, false, "passed string is NULL");

	if (strlen(title) == 0) {
		return false;
	}

	while (isspace(*title)) {
		++title;
	}

	return *title != '\0';
}

static bool _is_datetime_valid(edit_view_data *ad)
{
	if (difftime(mktime(&ad->etm), mktime(&ad->stm)) < 0) {
		return false;
	}
	return true;
}

static void _popup_button_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	edit_view_data *ad = (edit_view_data *)data;
	RETM_IF(!ad, "Data NULL");
	evas_object_del(ad->popup);
	ad->popup = NULL;
}

static Evas_Object *_create_warning_popup(void *data, const char *popup_text)
{
	edit_view_data *ad = (edit_view_data *)data;
	RETVM_IF(!ad, NULL, "Passed NULL input data");

	Evas_Object *popup = elm_popup_add(ad->naviframe);
	RETVM_IF(!popup, NULL, "Can't create popup");

	Evas_Object *popup_content = elm_label_add(popup);
	elm_object_text_set(popup_content, popup_text);
	elm_object_content_set(popup, popup_content);

	Evas_Object *button_ok = elm_button_add(popup);
	RETVM_IF(!button_ok, NULL, "Cannot add button");
	elm_object_text_set(button_ok, "OK");
	elm_object_part_content_set(popup, "button1", button_ok);
	evas_object_smart_callback_add(button_ok, "clicked", _popup_button_ok_cb, ad);

	evas_object_show(popup);

	return popup;
}

static void _save_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	edit_view_data *view_data = (edit_view_data *)data;

	elm_toolbar_item_selected_set(event_info, EINA_FALSE);

	if (!_is_title_valid(event_data_get_value(view_data->view_temporary_data, EVENT_DATA_TITLE))) {
		view_data->popup = _create_warning_popup(view_data, WARNING_TITLE_POPUP_TEXT);
		return;
	}

	if (!_is_datetime_valid(view_data)) {
		view_data->popup = _create_warning_popup(view_data, WARNING_TIME_POPUP_TEXT);
		return;
	}

	calendar_error_e error = calendar_connect();
	RETM_IF(error != CALENDAR_ERROR_NONE, "calendar_connect() is failed(%x)", error);

	/* Title */
	set_record_title(view_data->event_record, event_data_get_value(view_data->view_temporary_data, EVENT_DATA_TITLE));

	/* Time */
	bool is_all_day = elm_check_state_get(view_data->allday_btn);
	set_record_time(&view_data->stm, &view_data->etm, view_data->event_record, is_all_day);

	/* Location */
	set_record_location(view_data->event_record,
			event_data_get_value(view_data->view_temporary_data, EVENT_DATA_LOCATION),
			CALENDAR_RECORD_NO_COORDINATE, CALENDAR_RECORD_NO_COORDINATE);

	/* Description */
	set_record_note(view_data->event_record,
			event_data_get_value(view_data->view_temporary_data, EVENT_DATA_DESCRIPTION));

	/* Reminder */
	set_record_reminder(view_data->event_record,
			event_data_get_value(view_data->view_temporary_data, EVENT_DATA_REMINDER));

	/* Recurrence */
	set_record_recurrence(view_data->event_record, view_data->recurrence_data.id);
	set_record_repeat_range_type(view_data->event_record, view_data->recurrence_data.range_type);
	set_record_repeat_count(view_data->event_record, view_data->recurrence_data.count);
	set_record_repeat_until_time(view_data->event_record, &view_data->recurrence_data.tm);

	/* Priority */
	set_record_priority(view_data->event_record, view_data->priority);

	/* Sensitivity */
	set_record_sensitivity(view_data->event_record, view_data->sensitivity);

	/* Status */
	set_record_status(view_data->event_record, view_data->status);

	error = calendar_db_update_record(view_data->event_record);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_update_record() is failed(%x)", error);

	error = calendar_disconnect();
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_disconnect() is failed(%x)", error);

	event_data_copy(view_data->view_parent_data, view_data->view_temporary_data);

	event_data_release(view_data->view_temporary_data);

	elm_naviframe_item_pop(view_data->naviframe);
}

static Eina_Bool _edit_view_navi_item_cb(void *data, Elm_Object_Item *it)
{
	RETVM_IF(!data, false, "view_data is NULL");
	edit_view_data *view_data = (edit_view_data *)data;

	if (_close_active_popup(view_data)) {
		return EINA_FALSE;
	} else {
		evas_object_del(view_data->layout);

		calendar_record_destroy(view_data->event_record, EINA_TRUE);

		evas_object_del(view_data->start_datetime);
		evas_object_del(view_data->end_datetime);

		free(view_data);

		return EINA_TRUE;
	}
}

static void genlist_items_append(edit_view_data *data)
{
	static Elm_Genlist_Item_Class itc_title = {
		.item_style = "full",
		.func.content_get = _title_content_cb,
	};

	static Elm_Genlist_Item_Class itc_from = {
		.item_style = "default",
		.func.text_get = _start_datetime_label_cb,
		.func.content_get = _start_datetime_content_cb,
	};

	static Elm_Genlist_Item_Class itc_to = {
		.item_style = "default",
		.func.text_get = _end_datetime_label_cb,
		.func.content_get = _end_datetime_content_cb,
	};

	static Elm_Genlist_Item_Class itc_timezone = {
		.item_style = "default",
		.func.text_get = _timezone_label_cb,
		.func.content_get = _timezone_content_cb,
	};

	static Elm_Genlist_Item_Class itc_allday = {
		.item_style = "default",
		.func.text_get = _allday_label_cb,
		.func.content_get = _allday_content_cb,
	};

	static Elm_Genlist_Item_Class itc_location = {
		.item_style = "full",
		.func.content_get = _location_content_cb,
	};

	static Elm_Genlist_Item_Class itc_description = {
		.item_style = "full",
		.func.content_get = _description_content_cb,
	};

	static Elm_Genlist_Item_Class itc_reminder = {
		.item_style = "default",
		.func.text_get = _reminder_label_cb,
		.func.content_get = _reminder_content_cb,
	};

	static Elm_Genlist_Item_Class itc_recurrence = {
		.item_style = "default",
		.func.text_get = _recurrence_label_cb,
		.func.content_get = _recurrence_content_cb,
	};

	static Elm_Genlist_Item_Class itc_priority = {
		.item_style = "default",
		.func.text_get = _priority_label_cb,
		.func.content_get = _priority_content_cb,
	};

	static Elm_Genlist_Item_Class itc_sensivity = {
		.item_style = "default",
		.func.text_get = _sensitivity_label_cb,
		.func.content_get = _sensivity_content_cb,
	};

	static Elm_Genlist_Item_Class itc_status = {
		.item_style = "default",
		.func.text_get = _status_label_cb,
		.func.content_get = _status_content_cb,
	};

	elm_genlist_item_append(data->genlist, &itc_title, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	data->genlist_from_item =
	elm_genlist_item_append(data->genlist, &itc_from, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	data->genlist_to_item =
	elm_genlist_item_append(data->genlist, &itc_to, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_timezone, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_allday, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	data->genlist_location_item =
	elm_genlist_item_append(data->genlist, &itc_location, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	data->genlist_description_item =
	elm_genlist_item_append(data->genlist, &itc_description, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	data->genlist_reminder_item =
	elm_genlist_item_append(data->genlist, &itc_reminder, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_recurrence, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_priority, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_sensivity, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_status, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	evas_object_smart_callback_add(data->genlist, "selected", _scroll_genlist_top_cb, data);
}

static void genlist_add(edit_view_data *data)
{
	data->genlist = ui_utils_create_genlist(data->layout);
	elm_layout_theme_set(data->layout, "layout", "application", "default");
	elm_genlist_select_mode_set(data->genlist, ELM_OBJECT_SELECT_MODE_ALWAYS);
	elm_genlist_highlight_mode_set(data->genlist, EINA_FALSE);
	evas_object_size_hint_weight_set(data->genlist, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->genlist, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_scroller_policy_set(data->genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	elm_object_part_content_set(data->layout, "elm.swallow.content", data->genlist);
	evas_object_show(data->genlist);
}

Evas_Object *edit_view_add(window_obj *win, Evas_Object *naviframe, int index, event_data *view_data)
{
	RETVM_IF(!win || !naviframe, NULL, "Passed NULL input data");

	int is_allday = 0;
	int priority = 0;
	int sensitivity = 0;
	int status = 0;
	edit_view_data *data = calloc(1, sizeof(edit_view_data));
	RETVM_IF(!data, NULL, "Cannot allocate memory");

	data->naviframe = naviframe;
	data->win = win;
	data->layout = ui_utils_layout_add(data->naviframe, NULL, data);
	data->view_parent_data = view_data;
	data->view_temporary_data = event_data_create();

	/* Copy data to temporary structure */
	event_data_copy(data->view_temporary_data, data->view_parent_data);

	/* Get time chosen previously */
	calendar_connect();

	if (CALENDAR_ERROR_NONE != calendar_db_get_record(_calendar_event._uri, index, &data->event_record)) {
		calendar_disconnect();
		free(data);
		return NULL;
	}

	/* All day */
	calendar_record_get_int(data->event_record, (unsigned int)_calendar_event.is_allday, &is_allday);
	data->is_allday = (Eina_Bool)is_allday;

	/* Reminder */
	get_record_reminder(data->event_record, &data->reminder_number, &data->reminder_type);
	event_data_set_value(data->view_temporary_data, EVENT_DATA_REMINDER, settings_reminder_name_get(data->reminder_type, data->reminder_number));

	/* Recurrence */
	_btn_recurrence_text_get(data);

	/* Priority */
	calendar_record_get_int(data->event_record, (unsigned int)_calendar_event.priority, &priority);
	data->priority = (calendar_event_priority_e)priority;

	/* Sensitivity */
	calendar_record_get_int(data->event_record, _calendar_event.sensitivity, &sensitivity);
	data->sensitivity = (calendar_sensitivity_e)sensitivity;

	/* Status */
	calendar_record_get_int(data->event_record, _calendar_event.event_status, &status);
	data->status = (calendar_event_status_e)status;

	/* Set start and end date and time */
	get_record_time(data->event_record, &data->stm, &data->etm);

	/* Setting layout properties */
	evas_object_size_hint_weight_set(data->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_layout_file_set(data->layout, GET_PATH(EDJ_NAME), "create_view_layout");

	/* Create genlist for Events control */
	genlist_add(data);
	genlist_items_append(data);

	/* Header for naviframe */
	data->naviframe_item = elm_naviframe_item_push(data->naviframe, "Edit event", NULL, NULL, data->layout, NULL);
	elm_naviframe_item_pop_cb_set(data->naviframe_item, _edit_view_navi_item_cb, data);
	evas_object_show(data->layout);

	/* Footer for naviframe */
	Evas_Object *toolbar = ui_utils_toolbar_add(data->naviframe, data->naviframe_item);
	elm_toolbar_select_mode_set(toolbar, ELM_OBJECT_SELECT_MODE_NONE);
	elm_toolbar_item_append(toolbar, NULL, SAVE, _save_button_clicked_cb, data);

	int calendar_book_id = 0;
	calendar_error_e error = calendar_record_get_int(data->event_record, _calendar_event.calendar_book_id, &calendar_book_id);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int is failed(%x)", error);

	calendar_disconnect();

	return data->layout;
}
