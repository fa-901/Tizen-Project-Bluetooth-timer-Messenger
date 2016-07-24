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

#include "config.h"

#include "view/recurrence-view.h"

#include "utils/ui-utils.h"
#include "utils/logger.h"
#include "utils/settings-utils.h"

typedef struct {
	window_obj				*win;
	Evas_Object				*naviframe;
	Elm_Object_Item			*naviframe_item;
	Evas_Object				*layout;
	Evas_Object				*genlist;
	Evas_Object				*main_radio_obj;
	Evas_Object				*main_radio_until_obj;
	Evas_Smart_Cb			save_cb;
	void					*save_cb_data;
	int						repeat_count;
	Evas_Object				*until_entry;
	recurrence_repeat_data	*rec_data;
	Evas_Object				*date_time_popup;
	Evas_Object				*datetime;

	Evas_Object				*date_btn;
	Evas_Object				*time_btn;
	Evas_Object				*popup;
} recurrence_view_data;

static void _recurrence_view_destroy_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	recurrence_view_data *ad = (recurrence_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	evas_object_del(ad->datetime);
	free(ad);
}

static Eina_Bool _recurrence_view_navi_pop_cb(void *data, Elm_Object_Item *it)
{
	RETVM_IF(!data, EINA_FALSE, "Passed NULL input data");
	recurrence_view_data *ad = (recurrence_view_data *)data;

	if (ad->date_time_popup) {
		evas_object_del(ad->date_time_popup);
		ad->date_time_popup = NULL;
		ad->datetime = NULL;
		return EINA_FALSE;
	} else if (ad->popup) {
		evas_object_del(ad->popup);
		ad->popup = NULL;
		return EINA_FALSE;
	}

	evas_object_del(ad->genlist);
	ad->genlist = NULL;
	return EINA_TRUE;
}

static char *_title_label_cb(void *data, Evas_Object *obj, const char *part)
{
	const char *label = NULL;
	if (strcmp(part, "elm.text") == 0) {
		REPEAT_LABEL_TYPE type = (REPEAT_LABEL_TYPE) data;
		switch (type) {
			case REPEAT_LABEL:
				label = REPEAT;
				break;
			case REPEAT_UNTIL_LABEL:
				label = REPEAT_UNTIL;
				break;
			default:
				break;
		}
	}

	return label ? strdup(label) : NULL;
}

static char *_repeat_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char label[FORMAT_BUFFER] = {0};
	if (strcmp(part, "elm.text") == 0) {
		calendar_recurrence_frequency_e type = (calendar_recurrence_frequency_e) data;

		switch (type) {
			case CALENDAR_RECURRENCE_NONE:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "None");
				break;
			case CALENDAR_RECURRENCE_DAILY:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "Daily");
				break;
			case CALENDAR_RECURRENCE_WEEKLY:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "Weekly");
				break;
			case CALENDAR_RECURRENCE_MONTHLY:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "Monthly");
				break;
			case CALENDAR_RECURRENCE_YEARLY:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "Yearly");
				break;
			default:
				break;
		}
	}

	return label ? strdup(label) : NULL;
}

static char *_repeat_until_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char label[FORMAT_BUFFER] = {0};
	if (strcmp(part, "elm.text") == 0) {
		calendar_range_type_e type = (calendar_range_type_e) data;
		switch (type) {
			case CALENDAR_RANGE_UNTIL:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "Until");
				break;
			case CALENDAR_RANGE_COUNT:
				snprintf(label, sizeof(label) - 1, LABEL_FORMAT, get_system_font_size(), "Count");
				break;
			default:
				break;
		}
	}

	return label ? strdup(label) : NULL;
}

static void _on_datetime_popup_cancel_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	recurrence_view_data *view = data;
	evas_object_del(view->datetime);
	view->datetime = NULL;
	evas_object_del(view->date_time_popup);
	view->date_time_popup = NULL;
}

static void _on_date_popup_set_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	recurrence_view_data *view = data;

	elm_datetime_value_get(view->datetime, &view->rec_data->tm);

	char buf[DATE_TIME_BUF_LEN] = {'\0'};
	strftime(buf, DATE_TIME_BUF_LEN, "%x", &view->rec_data->tm);
	elm_object_text_set(view->date_btn, buf);
	evas_object_size_hint_weight_set(view->date_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_min_set(view->date_btn, ELM_BUTTON_DATE_WIDTH, ELM_BUTTON_HEIGHT);
	_on_datetime_popup_cancel_cb(view, NULL, NULL);
}

static void _on_time_popup_set_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	recurrence_view_data *view = data;

	elm_datetime_value_get(view->datetime, &view->rec_data->tm);

	char buf[DATE_TIME_BUF_LEN] = {'\0'};
	strftime(buf, DATE_TIME_BUF_LEN, "%R", &view->rec_data->tm);
	elm_object_text_set(view->time_btn, buf);
	evas_object_size_hint_weight_set(view->time_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_min_set(view->time_btn, ELM_BUTTON_TIME_WIDTH, ELM_BUTTON_HEIGHT);
	_on_datetime_popup_cancel_cb(view, NULL, NULL);
}

static Evas_Object *_date_time_popup_add(Evas_Object *parent, recurrence_view_data *view,
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

static void _get_datetime(recurrence_view_data *view, Evas_Object *parent, const char *format)
{
	RETM_IF(!view, "data is null");

	if (!view->datetime) {
		view->datetime = elm_datetime_add(parent);
		evas_object_size_hint_weight_set(view->datetime, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(view->datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
		elm_datetime_value_set(view->datetime, &view->rec_data->tm);
	}

	elm_datetime_format_set(view->datetime, format);
	evas_object_show(view->datetime);
}

static void _date_btn_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	recurrence_view_data *view = (recurrence_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_date_popup_set_cb, _on_datetime_popup_cancel_cb);

	_get_datetime(view, popup, "%d %b %Y");

	elm_object_content_set(popup, view->datetime);
}

static void _time_btn_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	recurrence_view_data *view = (recurrence_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_time_popup_set_cb, _on_datetime_popup_cancel_cb);

	_get_datetime(view, popup, "%R");

	elm_object_content_set(popup, view->datetime);
}

static void _until_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
recurrence_view_data *ad = (recurrence_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	int count = atoi(elm_entry_entry_get(ad->until_entry));
	if (count > MAX_REMINDERS_COUNT) {
		count = MAX_REMINDERS_COUNT;
	}
	ad->rec_data->count = count;
}

static void _scroll_genlist_top_cb(void *data, Evas_Object *obj, void *event_info)
{
	recurrence_view_data *ad = (recurrence_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");

	Elm_Object_Item *it = elm_genlist_last_item_get(ad->genlist);
	elm_genlist_item_show(it, ELM_GENLIST_ITEM_SCROLLTO_TOP);
}

static Evas_Object *_repeat_until_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	calendar_range_type_e type = (calendar_range_type_e)item_data;
	recurrence_view_data *data = (recurrence_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);

	switch (type) {
		case CALENDAR_RANGE_UNTIL:
		{
			Evas_Object *icon_obj = NULL;

			if (strcmp(part, "elm.swallow.end") == 0) {
				if (data->rec_data->range_type != CALENDAR_RANGE_UNTIL) {
					time_t time_now = time(0);

					struct tm *loc_tm = localtime(&time_now);
					if (loc_tm) {
						data->rec_data->tm = *loc_tm;
					}
				}

				Evas_Object *box = elm_box_add(obj);
				elm_box_horizontal_set(box, EINA_TRUE);
				elm_box_padding_set(box, ELM_BOX_PADDING, ELM_BOX_PADDING);
				evas_object_show(box);

				data->date_btn = elm_button_add(box);
				evas_object_show(data->date_btn);
				evas_object_smart_callback_add(data->date_btn, "clicked", _date_btn_cb, data);

				char buf[DATE_TIME_BUF_LEN] = {'\0'};
				strftime(buf, DATE_TIME_BUF_LEN, "%x", &data->rec_data->tm);
				elm_object_text_set(data->date_btn, buf);
				evas_object_size_hint_weight_set(data->date_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
				evas_object_size_hint_min_set(data->date_btn, ELM_BUTTON_DATE_WIDTH, ELM_BUTTON_HEIGHT);
				elm_box_pack_end(box, data->date_btn);

				data->time_btn = elm_button_add(box);
				evas_object_show(data->time_btn);
				evas_object_smart_callback_add(data->time_btn, "clicked", _time_btn_cb, data);

				strftime(buf, DATE_TIME_BUF_LEN, "%R", &data->rec_data->tm);
				elm_object_text_set(data->time_btn, buf);
				evas_object_size_hint_weight_set(data->time_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
				evas_object_size_hint_min_set(data->time_btn, ELM_BUTTON_TIME_WIDTH, ELM_BUTTON_HEIGHT);
				elm_box_pack_end(box, data->time_btn);


				icon_obj = box;
			} else if (strcmp(part, "elm.swallow.icon") == 0) {
				icon_obj = elm_radio_add(data->layout);
				elm_radio_value_set(icon_obj, type);
				elm_radio_state_value_set(icon_obj, type);

				elm_radio_group_add(icon_obj, data->main_radio_until_obj);
			}

			return icon_obj;
		}
		case CALENDAR_RANGE_COUNT:
		{
			Evas_Object *entry = NULL;

			if (strcmp(part, "elm.swallow.end") == 0) {
				entry = elm_entry_add(data->layout);
				RETVM_IF(!entry, NULL, "Can't create entry");

				evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
				evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);

				elm_entry_single_line_set(entry, EINA_TRUE);
				elm_entry_scrollable_set(entry, EINA_FALSE);

				elm_entry_cursor_end_set(entry);
				elm_entry_cnp_mode_set(entry, ELM_CNP_MODE_PLAINTEXT);

				char buffer[FORMAT_BUFFER] = {0};
				snprintf(buffer, sizeof(buffer) - 1, STYLE_FORMAT, get_system_font_size());
				elm_entry_text_style_user_push(entry, buffer);
				char str[FORMAT_BUFFER] = {0};
				snprintf(str, sizeof(str), "%d", data->rec_data->count);
				snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), str);
				elm_entry_entry_set(entry, buffer);
				elm_entry_input_panel_layout_set(entry, ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);

				Elm_Entry_Filter_Limit_Size count_numbers_filter;
				count_numbers_filter.max_char_count = 1;
				elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &count_numbers_filter);

				evas_object_smart_callback_add(entry, "changed", _until_entry_changed_cb, data);
				evas_object_smart_callback_add(entry, "clicked", _scroll_genlist_top_cb, data);
				data->until_entry = entry;
			} else if (strcmp(part, "elm.swallow.icon") == 0) {
				entry = elm_radio_add(data->layout);
				elm_radio_value_set(entry, type);
				elm_radio_state_value_set(entry, type);

				elm_radio_group_add(entry, data->main_radio_until_obj);
			}

			return entry;
		}
		default:
			break;
	}

	return NULL;
}

/**
 * Callback function called when the allday changed
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _radio_changed(void *data, Evas_Object *obj, void *event_info)
{
	recurrence_view_data *ad = (recurrence_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");
	calendar_recurrence_frequency_e type = (calendar_recurrence_frequency_e)data;

	elm_radio_value_set(ad->main_radio_obj, type);
}

static void _radio_until_changed(void *data, Evas_Object *obj, void *event_info)
{
	recurrence_view_data *ad = (recurrence_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");
	calendar_recurrence_frequency_e type = (calendar_recurrence_frequency_e)data;

	elm_radio_value_set(ad->main_radio_until_obj, type);
	elm_radio_state_value_set(ad->main_radio_until_obj, type);
}

static Evas_Object *_repeat_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	recurrence_view_data *data = (recurrence_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETVM_IF(!data, NULL, "Passed NULL input data");

	if (strcmp(part, "elm.swallow.icon") == 0) {
		calendar_recurrence_frequency_e type = (calendar_recurrence_frequency_e)item_data;
		Evas_Object *radio_obj = elm_radio_add(data->layout);

		elm_radio_value_set(radio_obj, type);
		elm_radio_state_value_set(radio_obj, type);
		elm_radio_group_add(radio_obj, data->main_radio_obj);

		return radio_obj;
	}
	return NULL;
}

static void _popup_button_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	recurrence_view_data *ad = (recurrence_view_data *)data;
	RETM_IF(!ad, "Data NULL");
	if (ad->popup) {
		evas_object_del(ad->popup);
		ad->popup = NULL;
	}
}

static Evas_Object *_create_warning_popup(void *data, const char *popup_text)
{
	recurrence_view_data *ad = (recurrence_view_data *)data;
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

/**
 * Callback function called when the save button is clicked
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _save_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");

	elm_toolbar_item_selected_set(event_info, EINA_FALSE);

	recurrence_view_data *ad = (recurrence_view_data *)data;

	ad->rec_data->id = elm_radio_value_get(ad->main_radio_obj);

	int range_type = elm_radio_value_get(ad->main_radio_until_obj);
	if (ad->rec_data->id != CALENDAR_RECURRENCE_NONE && range_type == -1) {
		ad->popup = _create_warning_popup(ad, WARNING_REPEAT_UNTIL_POPUP_TEXT);
		return;
	}

	ad->rec_data->range_type = range_type;

	time_t curr_time;
	time(&curr_time);
	struct tm current_time = *localtime(&curr_time);

	if (ad->rec_data->range_type == CALENDAR_RANGE_UNTIL && difftime(mktime(&ad->rec_data->tm), mktime(&current_time)) < 0) {
		ad->popup = _create_warning_popup(ad, WARNING_TIME_POPUP_TEXT);
		return;
	}

	const char *entry_text = NULL;

	switch (ad->rec_data->range_type) {
		case CALENDAR_RANGE_UNTIL:
			elm_datetime_value_get(ad->datetime, &ad->rec_data->tm);
			break;
		case CALENDAR_RANGE_COUNT:
			entry_text = elm_entry_entry_get(ad->until_entry);
			if (entry_text != NULL) {
				int count = atoi(entry_text);
				if (count > MAX_REMINDERS_COUNT) {
					count = MAX_REMINDERS_COUNT;
				}
				ad->rec_data->count = count;
			}
			break;
		default:
			break;
	}

	ad->save_cb(ad->save_cb_data, obj, event_info);

	elm_naviframe_item_pop(ad->naviframe);
}

/**
 * Add items to genlist
 *
 * @param[in]	data	Data used in this function
 *
 */
static void genlist_items_append(recurrence_view_data *data)
{
	static Elm_Genlist_Item_Class itc_title = {
		.item_style = "group_index",
		.func.text_get = _title_label_cb,
	};

	static Elm_Genlist_Item_Class itc_radio_repeats = {
		.item_style = "default",
		.func.text_get = _repeat_label_cb,
		.func.content_get = _repeat_content_cb,
	};

	static Elm_Genlist_Item_Class itc_radio_repeats_until = {
		.item_style = "default",
		.func.text_get = _repeat_until_label_cb,
		.func.content_get = _repeat_until_content_cb,
	};

	elm_genlist_item_append(data->genlist, &itc_title,
							(void *)REPEAT_LABEL, NULL,
							ELM_GENLIST_ITEM_NONE,
							NULL, NULL);
	evas_object_data_set(data->genlist, KEY_PRIORITY_DATA, data);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats,
							(void *)CALENDAR_RECURRENCE_NONE, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_changed, (void *)CALENDAR_RECURRENCE_NONE);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats,
							(void *)CALENDAR_RECURRENCE_DAILY, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_changed, (void *)CALENDAR_RECURRENCE_DAILY);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats,
							(void *)CALENDAR_RECURRENCE_WEEKLY, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_changed, (void *)CALENDAR_RECURRENCE_WEEKLY);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats,
							(void *)CALENDAR_RECURRENCE_MONTHLY, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_changed, (void *)CALENDAR_RECURRENCE_MONTHLY);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats,
							(void *)CALENDAR_RECURRENCE_YEARLY, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_changed, (void *)CALENDAR_RECURRENCE_YEARLY);
	elm_genlist_item_append(data->genlist, &itc_title,
							(void *)REPEAT_UNTIL_LABEL, NULL,
							ELM_GENLIST_ITEM_NONE,
							NULL, NULL);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats_until,
							(void *)CALENDAR_RANGE_UNTIL, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_until_changed, (void *)CALENDAR_RANGE_UNTIL);
	elm_genlist_item_append(data->genlist, &itc_radio_repeats_until,
							(void *)CALENDAR_RANGE_COUNT, NULL,
							ELM_GENLIST_ITEM_NONE,
							_radio_until_changed, (void *)CALENDAR_RANGE_COUNT);
}

/**
 * Add genlist to naviframe
 *
 * @param[in]	data	Data used in this function
 *
 */
static void genlist_add(recurrence_view_data *data)
{
	data->genlist = ui_utils_create_genlist(data->layout);
	elm_layout_theme_set(data->layout, "layout", "application", "default");
	elm_genlist_select_mode_set(data->genlist, ELM_OBJECT_SELECT_MODE_ALWAYS);
	elm_genlist_highlight_mode_set(data->genlist, EINA_FALSE);
	evas_object_size_hint_weight_set(data->genlist, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->genlist, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_genlist_homogeneous_set(data->genlist, EINA_TRUE);
	elm_scroller_policy_set(data->genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	elm_object_part_content_set(data->layout, "elm.swallow.content", data->genlist);
	evas_object_show(data->genlist);
}

void recurrence_view_add(window_obj *win, Evas_Object *parent, recurrence_repeat_data *recurrence_data, Evas_Smart_Cb func, void *func_data)
{
	RETM_IF(!win || !parent, "Passed NULL input data");

	recurrence_view_data *data = calloc(1, sizeof(recurrence_view_data));
	RETM_IF(!data, "Cannot allocate memory");

	data->win = win;
	data->naviframe = parent;
	data->rec_data = recurrence_data;
	data->save_cb = func;
	data->save_cb_data = func_data;
	data->layout = ui_utils_layout_add(data->naviframe, _recurrence_view_destroy_cb, data);

	/* repeat radio group */
	data->main_radio_obj = elm_radio_add(data->layout);
	evas_object_hide(data->main_radio_obj);
	elm_radio_value_set(data->main_radio_obj, -1);

	/* repeat until radio group */
	data->main_radio_until_obj = elm_radio_add(data->layout);
	evas_object_hide(data->main_radio_until_obj);
	elm_radio_value_set(data->main_radio_until_obj, -1);

	/*Create genlist for Events control*/
	genlist_add(data);
	genlist_items_append(data);

	/*Header for naviframe*/
	data->naviframe_item = elm_naviframe_item_push(data->naviframe, "Recurrence", NULL, NULL, data->layout, NULL);
	elm_naviframe_item_pop_cb_set(data->naviframe_item, _recurrence_view_navi_pop_cb, data);
	evas_object_show(data->layout);

	/*Footer for naviframe*/
	Evas_Object *toolbar = ui_utils_toolbar_add(data->naviframe, data->naviframe_item);
	elm_toolbar_item_append(toolbar, NULL, SAVE, _save_btn_clicked_cb, data);

	elm_radio_value_set(data->main_radio_obj, data->rec_data->id);
	if (data->rec_data->id != CALENDAR_RECURRENCE_NONE) {
		elm_radio_value_set(data->main_radio_until_obj, data->rec_data->range_type);
	}
}
