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

#include <stdio.h>
#include <calendar.h>
#include <stdlib.h>

#include "config.h"
#include "event-data.h"

#include "view/edit-view.h"
#include "view/details-view.h"

#include "utils/logger.h"
#include "utils/event-record.h"
#include "utils/ui-utils.h"
#include "utils/settings-utils.h"

#define TAB_MULTYPLIER 0.35

typedef struct {
	window_obj			*win;
	Evas_Object			*naviframe;
	Elm_Object_Item		*naviframe_item;

	Evas_Object			*layout;
	Evas_Object			*genlist;

	event_data			*view_data;

	Evas_Object			*popup;
	Elm_Object_Item		*edit_button;
	Elm_Object_Item		*delete_button;
	calendar_record_h	event_record;
	calendar_record_h	alarm_record;
	int					event_record_index;
} details_view_data;

static void _details_view_destroy_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	details_view_data *ad = (details_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");

	if (ad->alarm_record) {
		calendar_record_remove_child_record(ad->event_record, _calendar_event.calendar_alarm, ad->alarm_record);
	}

	calendar_record_destroy(ad->event_record, EINA_TRUE);

	event_data_release(ad->view_data);

	free(ad);
}

static Evas_Object *_get_content(void *data, Evas_Object *obj, const char *labelText, const char *data_text)
{
	details_view_data *details_data = (details_view_data *)data;
	int width = 0;
	int heigth = 0;

	Evas_Object *box = elm_box_add(obj);
	elm_win_screen_size_get(details_data->win->win, NULL, NULL, &width, NULL);
	elm_box_horizontal_set(box, EINA_TRUE);
	elm_box_padding_set(box, ELM_BOX_PADDING, ELM_BOX_PADDING);
	Evas_Object *subject_header_label = elm_label_add(box);
	Evas_Object *label = elm_label_add(box);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

	Evas_Object *rect1 = evas_object_rectangle_add(box);
	evas_object_color_set(rect1, 0, 0, 0, 0);
	evas_object_size_hint_min_set(rect1, ELM_SCALE_SIZE(ENTRY_SPACER_WIDTH), ELM_SCALE_SIZE(ENTRY_MIN_HEIGHT));
	evas_object_show(rect1);

	Evas_Object *rect2 = evas_object_rectangle_add(box);
	evas_object_color_set(rect2, 0, 0, 0, 0);
	evas_object_size_hint_min_set(rect2, ELM_SCALE_SIZE(ENTRY_SPACER_WIDTH), ELM_SCALE_SIZE(ENTRY_MIN_HEIGHT));
	evas_object_show(rect2);

	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), labelText);
	elm_object_part_text_set(subject_header_label, "elm.text", buffer);
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), data_text);
	elm_object_part_text_set(label, "elm.text", buffer);

	Evas_Object *scroller = elm_scroller_add(box);
	elm_scroller_bounce_set(scroller, EINA_TRUE, EINA_FALSE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_AUTO, ELM_SCROLLER_POLICY_OFF);
	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);

	Evas_Object *scroll_box = elm_box_add(scroller);
	elm_box_horizontal_set(scroll_box, EINA_TRUE);
	elm_box_padding_set(box, ELM_BOX_PADDING, ELM_BOX_PADDING);
	evas_object_size_hint_weight_set(scroll_box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(scroll_box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_align_set(scroll_box, 0.0, 0.5);
	elm_object_content_set(scroller, scroll_box);
	elm_box_pack_end(scroll_box, label);

	elm_box_pack_end(box, rect1);
	elm_box_pack_end(box, subject_header_label);
	elm_box_pack_end(box, rect2);
	elm_box_pack_end(box, scroller);

	evas_object_size_hint_min_get(subject_header_label, NULL, &heigth);
	evas_object_size_hint_min_set(subject_header_label, width * TAB_MULTYPLIER, heigth);
	evas_object_size_hint_max_set(subject_header_label, width * TAB_MULTYPLIER, heigth);
	evas_object_size_hint_min_set(box, 0, ELM_SCALE_SIZE(ENTRY_MIN_HEIGHT));
	elm_box_align_set(box, 0.0, 0.5);

	evas_object_show(subject_header_label);
	evas_object_show(label);
	evas_object_show(scroller);
	evas_object_show(box);

	return box;
}

static char *get_event_start_date(void *data)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *details_data = (details_view_data *)data;
	calendar_time_s start_time;
	memset(&start_time, 0x0, sizeof(start_time));
	char *label = calloc(DATE_TIME_BUF_LEN, sizeof(char));

	if (CALENDAR_ERROR_NONE != calendar_record_get_caltime(details_data->event_record, _calendar_event.start_time, &start_time)) {
		return strdup(ERROR);
	}

	if (start_time.type == CALENDAR_TIME_UTIME) {
		const time_t date = start_time.time.utime;
		struct tm *loc_time = localtime(&date);
		strftime(label, DATE_TIME_BUF_LEN, "%x %R", loc_time);
	} else {
		snprintf(label, DATE_TIME_BUF_LEN, "%d/%d/%d ", start_time.time.date.mday, start_time.time.date.month, start_time.time.date.year);
	}

	return label;
}

static char *get_event_end_date(void *data)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *details_data = (details_view_data *)data;
	calendar_time_s end_time;
	memset(&end_time, 0x0, sizeof(end_time));
	char *label = calloc(DATE_TIME_BUF_LEN, sizeof(char));

	if (CALENDAR_ERROR_NONE != calendar_record_get_caltime(details_data->event_record, _calendar_event.end_time, &end_time)) {
		return strdup(ERROR);
	}

	if (end_time.type == CALENDAR_TIME_UTIME) {
		const time_t date = end_time.time.utime;
		const struct tm *loc_time = localtime(&date);
		strftime(label, DATE_TIME_BUF_LEN, "%x %R", loc_time);
	} else {
		snprintf(label, DATE_TIME_BUF_LEN, "%d/%d/%d ", end_time.time.date.mday, end_time.time.date.month, end_time.time.date.year);
	}

	return label;
}

static char *get_allday(void *data)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *details_data = (details_view_data *)data;
	calendar_time_s start_time;
	memset(&start_time, 0x0, sizeof(start_time));

	if (CALENDAR_ERROR_NONE != calendar_record_get_caltime(details_data->event_record, _calendar_event.start_time, &start_time)) {
		return strdup(ERROR);
	}

	if (start_time.type == CALENDAR_TIME_LOCALTIME) {
		return strdup(YES);
	} else {
		return strdup(NO);
	}
}

static char *get_event_reminder(void *data)
{
	details_view_data *details_data = (details_view_data *)data;
	int reminder = -1;

	get_record_reminder(details_data->event_record, &reminder, NULL);

	char *buffer;

	for (int i = 0; i < reminder_info_size; i++) {
		if (reminder_info[i].reminder == reminder) {
			buffer = strdup(reminder_info[i].name);
		}
	}

	return (!buffer) ? strdup(NONE) : buffer;
}

static char *get_event_recurrence(void *data)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *details_data = (details_view_data *)data;
	int freq = CALENDAR_RECURRENCE_NONE;
	char *id_str = NULL;
	const char *label = NULL;

	if (CALENDAR_ERROR_NONE == calendar_record_get_str(details_data->event_record, _calendar_event.recurrence_id, &id_str)) {
		if (id_str) {
			freq = atoi(id_str);
			free(id_str);
		} else {
			calendar_record_get_int(details_data->event_record, _calendar_event.freq, &freq);
		}
	}

	switch (freq) {
		case CALENDAR_RECURRENCE_DAILY:
			label = "Daily";
			break;
		case CALENDAR_RECURRENCE_WEEKLY:
			label = "Weekly";
			break;
		case CALENDAR_RECURRENCE_MONTHLY:
			label = "Monthly";
			break;
		case CALENDAR_RECURRENCE_YEARLY:
			label = "Yearly";
			break;
		case CALENDAR_RECURRENCE_NONE:
		default:
			label = NONE;
			break;
	}

	if (label) {
		return strdup(label);
	}
	return NULL;
}

static char *get_event_priority(void *data)
{
	details_view_data *details_data = (details_view_data *)data;
	calendar_error_e error = CALENDAR_ERROR_NONE;
	int priority = 0;
	const char *label = NULL;

	error = calendar_record_get_int(details_data->event_record, _calendar_event.priority, &priority);
	if (error != CALENDAR_ERROR_NONE || priority == 0) {
		label = NORMAL;
	}

	switch (priority) {
		case CALENDAR_EVENT_PRIORITY_LOW:
			label = LOW;
			break;
		case CALENDAR_EVENT_PRIORITY_NORMAL:
			label = NORMAL;
			break;
		case CALENDAR_EVENT_PRIORITY_HIGH:
		default:
			label = HIGH;
			break;
	}

	return strdup(label);
}

static char *get_event_sensivity(void *data)
{
	details_view_data *details_data = (details_view_data *)data;
	calendar_error_e error = CALENDAR_ERROR_NONE;
	int sensitivity = 0;
	const char *label = NULL;

	error = calendar_record_get_int(details_data->event_record, _calendar_event.sensitivity, &sensitivity);
	if (error != CALENDAR_ERROR_NONE || sensitivity == 0) {
		label = PUBLIC;
	}

	switch (sensitivity) {
		case CALENDAR_SENSITIVITY_PUBLIC:
			label = PUBLIC;
			break;
		case CALENDAR_SENSITIVITY_PRIVATE:
			label = PRIVATE;
			break;
		case CALENDAR_SENSITIVITY_CONFIDENTIAL:
		default:
			label = CONFIDENTIAL;
			break;
	}

	return strdup(label);
}

static char *get_event_status(void *data)
{
	details_view_data *details_data = (details_view_data *)data;
	calendar_error_e error = CALENDAR_ERROR_NONE;
	int status = 0;
	const char *label = NULL;

	error = calendar_record_get_int(details_data->event_record, _calendar_event.event_status, &status);
	if (error) {
		label = ERROR;
	} else {
		label = settings_status_name_get(status);
	}

	return strdup(label);
}

static Evas_Object *_title_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, TITLE, event_data_get_value(data_struct->view_data, EVENT_DATA_TITLE));

	return content;
}

static Evas_Object *_start_datetime_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, FROM, event_data_get_value(data_struct->view_data, EVENT_DATA_START_DATE));

	return content;
}

static Evas_Object *_end_datetime_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, TO, event_data_get_value(data_struct->view_data, EVENT_DATA_END_DATE));

	return content;
}

static Evas_Object *_allday_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, ALL_DAY, event_data_get_value(data_struct->view_data, EVENT_DATA_ALL_DAY));

	return content;
}

static Evas_Object *_timezone_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, TIME_ZONE, event_data_get_value(data_struct->view_data, EVENT_DATA_TIMEZONE));

	return content;
}

static Evas_Object *_location_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, LOCATION, event_data_get_value(data_struct->view_data, EVENT_DATA_LOCATION));

	return content;
}

static Evas_Object *_description_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, DESCRIPTION, event_data_get_value(data_struct->view_data, EVENT_DATA_DESCRIPTION));

	return content;
}

static Evas_Object *_reminder_content_cb(void *data, Evas_Object *obj, const char *part)
{
	if (strcmp(part, "elm.icon") != 0) {
		return NULL;
	}

	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, REMINDER, event_data_get_value(data_struct->view_data, EVENT_DATA_REMINDER));

	return content;
}

static Evas_Object *_recurrence_content_cb(void *data, Evas_Object *obj, const char *part)
{
	if (strcmp(part, "elm.icon") != 0) {
		return NULL;
	}

	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, RECURRENCE, event_data_get_value(data_struct->view_data, EVENT_DATA_RECURRENCE));

	return content;
}

static Evas_Object *_priority_content_cb(void *data, Evas_Object *obj, const char *part)
{
	if (strcmp(part, "elm.icon") != 0) {
		return NULL;
	}

	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, PRIORITY, event_data_get_value(data_struct->view_data, EVENT_DATA_PRIORITY));

	return content;
}

static Evas_Object *_sensivity_content_cb(void *data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, SENSITIVITY, event_data_get_value(data_struct->view_data, EVENT_DATA_SENSITIVITY));

	return content;
}

static Evas_Object *_status_content_cb(void *data, Evas_Object *obj, const char *part)
{
	if (strcmp(part, "elm.icon") != 0) {
		return NULL;
	}

	RETVM_IF(!data, NULL, "Passed NULL input data");
	details_view_data *data_struct = (details_view_data *)data;

	Evas_Object *content = _get_content(data, obj, STATUS, event_data_get_value(data_struct->view_data, EVENT_DATA_STATUS));

	return content;
}

static void genlist_update(details_view_data *view_data)
{
	RETM_IF(!view_data, "Passed NULL input data");
	calendar_error_e error = CALENDAR_ERROR_NONE;
	calendar_connect();
	error = calendar_db_get_record(_calendar_event._uri, view_data->event_record_index, &view_data->event_record);
	if (CALENDAR_ERROR_NONE == error) {
		elm_genlist_realized_items_update(view_data->genlist);
	}
	calendar_disconnect();
}

static void delete_event(calendar_record_h record)
{
	calendar_error_e error = calendar_connect();
	if (error == CALENDAR_ERROR_NONE) {
		int index = 0;
		error = calendar_record_get_int(record, _calendar_event.id, &index);
		if (error == CALENDAR_ERROR_NONE) {
			error = calendar_db_delete_record(_calendar_event._uri, index);
			WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_delete_record() is failed(%x)", error);
		} else {
			WARN("getting event id is failed(%x)", error);
		}
		calendar_disconnect();
	}
}

static void popup_ok_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	details_view_data *app = (details_view_data *)data;

	delete_event(app->event_record);

	evas_object_del(app->popup);
	app->popup = NULL;
	elm_naviframe_item_pop(app->naviframe);
}

static void popup_cancel_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	details_view_data *app = (details_view_data *)data;

	evas_object_del(app->popup);
	app->popup = NULL;
}

static void create_confirmation_popup(details_view_data *app)
{
	RETM_IF(!app, "Passed NULL input data");

	Evas_Object *popup = elm_popup_add(app->naviframe);

	Evas_Object *popup_content = elm_label_add(popup);
	elm_object_text_set(popup_content, DELETION_CONFIRM);
	elm_object_content_set(popup, popup_content);

	Evas_Object *cancel_button = elm_button_add(popup);
	elm_object_text_set(cancel_button, CANCEL);
	elm_object_part_content_set(popup, "button1", cancel_button);
	evas_object_smart_callback_add(cancel_button, "clicked", popup_cancel_button_cb, app);

	Evas_Object *ok_button = elm_button_add(popup);
	elm_object_text_set(ok_button, OK);
	elm_object_part_content_set(popup, "button2", ok_button);
	evas_object_smart_callback_add(ok_button, "clicked", popup_ok_button_cb, app);

	app->popup = popup;
	evas_object_show(popup);
}

static void delete_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	details_view_data *app = (details_view_data *)data;

	create_confirmation_popup(app);
}

static void edit_view_layout_del_cb(void *data, Evas *evas, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	details_view_data *view_data = (details_view_data *)data;
	genlist_update(view_data);
}

static void edit_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	details_view_data *view_data = (details_view_data *)data;

	Evas_Object *layout = edit_view_add(view_data->win, view_data->naviframe, view_data->event_record_index, view_data->view_data);
	evas_object_event_callback_add(layout, EVAS_CALLBACK_DEL, edit_view_layout_del_cb, data);
}

static bool close_active_popup(details_view_data *view_data)
{
	RETVM_IF(!view_data, false, "view_data is NULL");

	if (view_data->popup) {
		evas_object_del(view_data->popup);
		view_data->popup = NULL;
		return true;
	}
	return false;
}

static Eina_Bool details_view_navi_pop_cb(void *data, Elm_Object_Item *it)
{
	RETVM_IF(!data, EINA_FALSE, "Passed NULL input data");
	details_view_data *app = (details_view_data *)data;

	if (close_active_popup(app)) {
		return EINA_FALSE;
	} else {
		evas_object_del(app->genlist);
		app->genlist = NULL;
		return EINA_TRUE;
	}
}

static void genlist_items_append(details_view_data *data)
{
	static Elm_Genlist_Item_Class itc_title = {
		.item_style = "full",
		.func.content_get = _title_content_cb,
	};

	static Elm_Genlist_Item_Class itc_from = {
		.item_style = "full",
		.func.content_get = _start_datetime_content_cb,
	};

	static Elm_Genlist_Item_Class itc_to = {
		.item_style = "full",
		.func.content_get = _end_datetime_content_cb,
	};

	static Elm_Genlist_Item_Class itc_timezone = {
		.item_style = "full",
		.func.content_get = _timezone_content_cb,
	};

	static Elm_Genlist_Item_Class itc_allday = {
		.item_style = "full",
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
		.item_style = "full",
		.func.content_get = _reminder_content_cb,
	};

	static Elm_Genlist_Item_Class itc_recurrence = {
		.item_style = "full",
		.func.content_get = _recurrence_content_cb,
	};

	static Elm_Genlist_Item_Class itc_priority = {
		.item_style = "full",
		.func.content_get = _priority_content_cb,
	};

	static Elm_Genlist_Item_Class itc_sensivity = {
		.item_style = "full",
		.func.content_get = _sensivity_content_cb,
	};

	static Elm_Genlist_Item_Class itc_status = {
		.item_style = "full",
		.func.content_get = _status_content_cb,
	};

	elm_genlist_item_append(data->genlist, &itc_title, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_from, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_to, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_timezone, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_allday, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_location, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_description, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_reminder, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_recurrence, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_priority, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_sensivity, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	elm_genlist_item_append(data->genlist, &itc_status, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

	//TODO
	//evas_object_smart_callback_add(data->genlist, "selected", _scroll_genlist_top_cb, data);
}

static void genlist_add(details_view_data *data)
{
	data->genlist = ui_utils_create_genlist(data->layout);
	elm_layout_theme_set(data->layout, "layout", "application", "default");
	elm_genlist_select_mode_set(data->genlist, ELM_OBJECT_SELECT_MODE_NONE);
	evas_object_size_hint_weight_set(data->genlist, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->genlist, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_scroller_policy_set(data->genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	elm_object_part_content_set(data->layout, "elm.swallow.content", data->genlist);
	evas_object_show(data->genlist);
}

Evas_Object *details_view_add(window_obj *win, Evas_Object *naviframe, int index)
{
	RETVM_IF(!win || !naviframe, NULL, "Passed NULL input data");

	details_view_data *data = calloc(1, sizeof(details_view_data));
	RETVM_IF(!data, NULL, "Cannot allocate memory");

	data->view_data = event_data_create();
	if (!data->view_data) {
		free(data);
		return NULL;
	}

	data->win = win;
	data->naviframe = naviframe;
	data->event_record_index = index;
	calendar_connect();

	if (CALENDAR_ERROR_NONE != calendar_db_get_record(_calendar_event._uri, index, &data->event_record)) {
		calendar_disconnect();
		free(data);
		return NULL;
	}

	char *buffer = NULL;

	/** TITLE */
	calendar_record_get_str_p(data->event_record, _calendar_event.summary, &buffer);
	if (buffer) {
		event_data_set_value(data->view_data, EVENT_DATA_TITLE, buffer);
	}

	/** LOCATION */
	calendar_record_get_str_p(data->event_record, _calendar_event.location, &buffer);
	if (buffer) {
		event_data_set_value(data->view_data, EVENT_DATA_LOCATION, buffer);
	}

	/** DESCRIPTION */
	calendar_record_get_str_p(data->event_record, _calendar_event.description, &buffer);
	if (buffer) {
		event_data_set_value(data->view_data, EVENT_DATA_DESCRIPTION, buffer);
	}

	/** TIMEZONE */
	calendar_record_get_str_p(data->event_record, _calendar_event.start_tzid, &buffer);
	if (buffer) {
		event_data_set_value(data->view_data, EVENT_DATA_TIMEZONE, buffer);
	}

	/** RECURRENCE */
	event_data_set_value(data->view_data, EVENT_DATA_RECURRENCE, get_event_recurrence(data));

	/** START DATE */
	event_data_set_value(data->view_data, EVENT_DATA_START_DATE, get_event_start_date(data));

	/** END DATE */
	event_data_set_value(data->view_data, EVENT_DATA_END_DATE, get_event_end_date(data));

	/** ALLDAY */
	event_data_set_value(data->view_data, EVENT_DATA_ALL_DAY, get_allday(data));

	/** REMINDER */
	event_data_set_value(data->view_data, EVENT_DATA_REMINDER, get_event_reminder(data));

	/** EVENT PRIORITY */
	event_data_set_value(data->view_data, EVENT_DATA_PRIORITY, get_event_priority(data));

	/** SENSITIVITY */
	event_data_set_value(data->view_data, EVENT_DATA_SENSITIVITY, get_event_sensivity(data));

	/** STATUS */
	event_data_set_value(data->view_data, EVENT_DATA_STATUS, get_event_status(data));

	size_t alarm_count = 0;
	calendar_record_get_child_record_count(data->event_record, _calendar_event.calendar_alarm, &alarm_count);

	if (alarm_count > 0) {
		calendar_record_get_child_record_at_p(data->event_record, _calendar_event.calendar_alarm, 0, &data->alarm_record);
	}

	data->layout = ui_utils_layout_add(data->naviframe, _details_view_destroy_cb, data);
	evas_object_size_hint_weight_set(data->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_layout_file_set(data->layout, GET_PATH(EDJ_NAME), "create_view_layout");

	/*Create genlist for Events control*/
	genlist_add(data);
	genlist_items_append(data);

	/*Header for naviframe*/
	data->naviframe_item = elm_naviframe_item_push(data->naviframe, "Details", NULL, NULL, data->layout, NULL);
	elm_naviframe_item_pop_cb_set(data->naviframe_item, details_view_navi_pop_cb, data);
	evas_object_show(data->layout);

	/*Footer for naviframe*/
	Evas_Object *toolbar = ui_utils_toolbar_add(data->naviframe, data->naviframe_item);
	elm_toolbar_select_mode_set(toolbar, ELM_OBJECT_SELECT_MODE_NONE);

	data->edit_button = elm_toolbar_item_append(toolbar, NULL, EDIT, edit_button_cb, data);
	data->delete_button = elm_toolbar_item_append(toolbar, NULL, DELETE, delete_button_cb, data);

	int calendar_book_id = 0;
	calendar_error_e error = calendar_record_get_int(data->event_record, _calendar_event.calendar_book_id, &calendar_book_id);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int is failed(%x)", error);

	if (calendar_book_id != DEFAULT_EVENT_CALENDAR_BOOK_ID
		&& calendar_book_id != DEFAULT_TODO_CALENDAR_BOOK_ID
		&& calendar_book_id != DEFAULT_BIRTHDAY_CALENDAR_BOOK_ID) {
		elm_object_item_disabled_set(data->edit_button, EINA_TRUE);
		elm_object_item_disabled_set(data->delete_button, EINA_TRUE);
	}

	calendar_disconnect();

	return data->layout;
}

