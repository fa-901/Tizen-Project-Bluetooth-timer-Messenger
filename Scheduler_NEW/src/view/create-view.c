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

#include <string.h>
#include <stdlib.h>
#include <efl_extension.h>
#include <time.h>

#include "config.h"

#include "view/create-view.h"
#include "view/recurrence-view.h"

#include "utils/logger.h"
#include "utils/event-record.h"
#include "utils/ui-utils.h"
#include "utils/settings-utils.h"

typedef struct {
	window_obj			*win;
	Evas_Object			*naviframe;
	Elm_Object_Item		*naviframe_item;

	Evas_Object			*layout;
	Evas_Object			*genlist;

	char				*title_entry;
	char				*location_entry;
	char				*description_entry;
	char				*reminder_type_name;

	Evas_Object			*start_datetime;
	Evas_Object			*end_datetime;
	Evas_Object			*start_date_btn;
	Evas_Object			*start_time_btn;
	Evas_Object			*end_date_btn;
	Evas_Object			*end_time_btn;
	Evas_Object			*all_day_btn;
	Evas_Object			*reminder_btn;
	Evas_Object			*recurrence_btn;
	Evas_Object			*priority_btn;
	Evas_Object			*sensitivity_btn;
	Evas_Object			*status_btn;

	Evas_Object			*popup;
	Evas_Object			*date_time_popup;

	calendar_alarm_time_unit_type_e		reminder_type;
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


	Evas_Object			*reminder_ctxpopup;
	Evas_Object			*priority_ctxpopup;
	Evas_Object			*sensitivity_ctxpopup;
	Evas_Object			*status_ctxpopup;


} create_view_data;

static bool _close_active_popup(create_view_data *view_data)
{
	RETVM_IF(!view_data, false, "view_data is NULL");

	if (view_data->reminder_ctxpopup) {
		evas_object_del(view_data->reminder_ctxpopup);
		view_data->reminder_ctxpopup = NULL;
	} else if (view_data->sensitivity_ctxpopup) {
		evas_object_del(view_data->sensitivity_ctxpopup);
		view_data->sensitivity_ctxpopup = NULL;
	} else if (view_data->priority_ctxpopup) {
		evas_object_del(view_data->priority_ctxpopup);
		view_data->priority_ctxpopup = NULL;
	} else if (view_data->status_ctxpopup) {
		evas_object_del(view_data->status_ctxpopup);
		view_data->status_ctxpopup = NULL;
	} else if (view_data->popup) {
		evas_object_del(view_data->popup);
		view_data->popup = NULL;
	} else if (view_data->date_time_popup) {
		Evas_Object *obj = elm_object_content_get(view_data->date_time_popup);
		elm_object_content_unset(view_data->date_time_popup);
		evas_object_hide(obj);
		evas_object_del(view_data->date_time_popup);
		view_data->date_time_popup = NULL;
	} else {
		return false;
	}
	return true;
}

/**
 * Callback function used for destroy create-view
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					A strdup'()ed string. The caller will free() it when done.
 */
static void _create_view_destroy_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	evas_object_del(ad->start_datetime);
	evas_object_del(ad->end_datetime);
	free(ad->title_entry);
	free(ad->description_entry);
	free(ad->location_entry);
	free(data);
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

static bool _is_datetime_valid(create_view_data *ad)
{
	if (difftime(mktime(&ad->etm), mktime(&ad->stm)) < 0) {
		return false;
	}
	return true;
}

static void _popup_button_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Data NULL");
	evas_object_del(ad->popup);
	ad->popup = NULL;
}

static Evas_Object *_create_warning_popup(void *data, const char *popup_text)
{
	create_view_data *ad = (create_view_data *)data;
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
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");

	RETM_IF(!ad->title_entry, "title string NULL");

	elm_toolbar_item_selected_set(event_info, EINA_FALSE);

	if (!_is_title_valid(ad->title_entry)) {
		ad->popup = _create_warning_popup(ad, WARNING_TITLE_POPUP_TEXT);
		return;
	}

	if (!_is_datetime_valid(ad)) {
		ad->popup = _create_warning_popup(ad, WARNING_TIME_POPUP_TEXT);
		return;
	}

	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_connect();
	RETM_IF(error != CALENDAR_ERROR_NONE, "calendar_connect() is failed(%x)", error);

	calendar_record_h record = create_record_with_presets();

	set_record_title(record, ad->title_entry);

	set_record_time(&ad->stm, &ad->etm, record, ad->is_allday);

	set_record_timezone_city(record);

	set_record_location(record, ad->location_entry, CALENDAR_RECORD_NO_COORDINATE, CALENDAR_RECORD_NO_COORDINATE);

	set_record_note(record, ad->description_entry);

	set_record_priority(record, ad->priority);

	set_record_sensitivity(record, ad->sensitivity);

	set_record_status(record, ad->status);

	set_record_reminder(record, ad->reminder_type_name);

	set_record_recurrence(record, ad->recurrence_data.id);

	if (ad->recurrence_data.id != CALENDAR_RECURRENCE_NONE) {
		set_record_repeat_range_type(record, ad->recurrence_data.range_type);
		set_record_repeat_count(record, ad->recurrence_data.count);
		set_record_repeat_until_time(record, &ad->recurrence_data.tm);
	}

	int record_index = 0;
	error = calendar_db_insert_record(record, &record_index);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_insert_record() is failed(%x)", error);

	if (record) {
		calendar_record_destroy(record, EINA_TRUE);
	}

	error = calendar_disconnect();
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_disconnect() is failed(%x)", error);

	elm_naviframe_item_pop(ad->naviframe);
}

/**
 * Callback function called when the user enter new title
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _title_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	if (ad->title_entry != NULL) {
		free(ad->title_entry);
		ad->title_entry = NULL;
	}
	ad->title_entry = strdup(elm_entry_entry_get(obj));
}

/**
 * Callback function called when the user enter new location
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _location_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	if (ad->location_entry != NULL) {
		free(ad->location_entry);
		ad->location_entry = NULL;
	}
	ad->location_entry = strdup(elm_entry_entry_get(obj));
}

/**
 * Callback function called when the user enter new description
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _description_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	if (ad->description_entry != NULL) {
		free(ad->description_entry);
		ad->description_entry = NULL;
	}
	ad->description_entry = strdup(elm_entry_entry_get(obj));
}

/**
 * Callback function called when the user selected new label
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _reminder_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");

	if (!data) {
		ERR("Passed NULL input data");
		evas_object_del(ad->reminder_ctxpopup);
		ad->reminder_ctxpopup = NULL;
		return;
	}

	char *name = (char *)data;
	calendar_alarm_time_unit_type_e reminder = settings_reminder_type_get(name);
	elm_object_text_set(ad->reminder_btn, name);
	evas_object_size_hint_weight_set(ad->reminder_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->reminder_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(ad->reminder_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
	ad->reminder_type = reminder;
	ad->reminder_type_name = name;

	evas_object_del(ad->reminder_ctxpopup);
	ad->reminder_ctxpopup = NULL;
}

/**
 * Callback function called when the user selected new label
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _recurrence_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
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
	evas_object_size_hint_min_set(ad->recurrence_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
}

/**
 * Callback function called when the user selected new label
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _priority_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");

	create_view_data *ad = (create_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");

	evas_object_del(ad->priority_ctxpopup);
	ad->priority_ctxpopup = NULL;

	calendar_event_priority_e prior = (calendar_event_priority_e)data;

	switch (prior) {
		case CALENDAR_EVENT_PRIORITY_LOW:
			elm_object_text_set(ad->priority_btn, "Low");
			break;
		case CALENDAR_EVENT_PRIORITY_NORMAL:
			elm_object_text_set(ad->priority_btn, "Normal");
			break;
		case CALENDAR_EVENT_PRIORITY_HIGH:
			elm_object_text_set(ad->priority_btn, "High");
			break;
		default:
			break;
	}
	evas_object_size_hint_weight_set(ad->priority_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->priority_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(ad->priority_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);

	ad->priority = prior;
}

/**
 * Callback function called when the user selected new label
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _sensitivity_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");

	calendar_sensitivity_e sensitivity = (calendar_sensitivity_e)data;

	switch (sensitivity) {
		case CALENDAR_SENSITIVITY_PUBLIC:
			elm_object_text_set(ad->sensitivity_btn, "Public");
			break;
		case CALENDAR_SENSITIVITY_PRIVATE:
			elm_object_text_set(ad->sensitivity_btn, "Private");
			break;
		case CALENDAR_SENSITIVITY_CONFIDENTIAL:
			elm_object_text_set(ad->sensitivity_btn, "Confidential");
			break;
		default:
			break;
	}
	evas_object_size_hint_weight_set(ad->sensitivity_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->sensitivity_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(ad->sensitivity_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
	ad->sensitivity = sensitivity;

	evas_object_del(ad->sensitivity_ctxpopup);
	ad->sensitivity_ctxpopup = NULL;
}

/**
 * Callback function called when the user selected new label
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _status_btn_lable_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");

	calendar_event_status_e status = (calendar_event_status_e)data;

	elm_object_text_set(ad->status_btn, settings_status_name_get(status));
	ad->status = status;
	evas_object_size_hint_weight_set(ad->status_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->status_btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(ad->status_btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);

	evas_object_del(ad->status_ctxpopup);
	ad->status_ctxpopup = NULL;
}

static void _dismiss_priority_context_popup(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *view_data = (create_view_data *)data;
	RETM_IF(!view_data, "Passed NULL input data");

	if (view_data->priority_ctxpopup) {
		evas_object_del(view_data->priority_ctxpopup);
		view_data->priority_ctxpopup = NULL;
	}
}

static void _show_priority_context_popup(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *view_data = (create_view_data *)data;
	RETM_IF(!view_data, "Passed NULL input data");

	if (view_data->priority_ctxpopup) {
		evas_object_del(view_data->priority_ctxpopup);
		view_data->priority_ctxpopup = NULL;
	}

	view_data->priority_ctxpopup = elm_ctxpopup_add(view_data->naviframe);
	evas_object_data_set(view_data->priority_ctxpopup, KEY_PRIORITY_DATA, view_data);

	elm_ctxpopup_item_append(view_data->priority_ctxpopup, "Low", NULL, _priority_btn_lable_changed_cb, (void *)CALENDAR_EVENT_PRIORITY_LOW);
	elm_ctxpopup_item_append(view_data->priority_ctxpopup, "Normal", NULL, _priority_btn_lable_changed_cb, (void *)CALENDAR_EVENT_PRIORITY_NORMAL);
	elm_ctxpopup_item_append(view_data->priority_ctxpopup, "High", NULL, _priority_btn_lable_changed_cb, (void *)CALENDAR_EVENT_PRIORITY_HIGH);

	evas_object_size_hint_weight_set(view_data->priority_ctxpopup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0;
	int y = 0;
	evas_object_geometry_get(view_data->priority_btn, &x, &y, NULL, NULL);
	evas_object_move(view_data->priority_ctxpopup, x, y);
	evas_object_smart_callback_add(view_data->priority_ctxpopup, "dismissed", _dismiss_priority_context_popup, view_data);

	evas_object_show(view_data->priority_ctxpopup);
}

static void _status_popup_dismiss_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	create_view_data *view_data = (create_view_data *)data;

	if (view_data->status_ctxpopup) {
		evas_object_del(view_data->status_ctxpopup);
		view_data->status_ctxpopup = NULL;
	}
}

static void _show_btn_status_context_popup(create_view_data *view)
{
	view->status_ctxpopup = elm_ctxpopup_add(view->naviframe);
	evas_object_data_set(view->status_ctxpopup, KEY_PRIORITY_DATA, view);

	int i;
	for (i = 0; i < status_info_size; i++) {
		elm_ctxpopup_item_append(view->status_ctxpopup, status_info[i].name, NULL, _status_btn_lable_changed_cb, (void *)status_info[i].type);
	}

	evas_object_size_hint_weight_set(view->status_ctxpopup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0;
	int y = 0;
	evas_object_geometry_get(view->status_btn, &x, &y, NULL, NULL);
	evas_object_move(view->status_ctxpopup, x, y);
	evas_object_smart_callback_add(view->status_ctxpopup, "dismissed", _status_popup_dismiss_cb, view);

	evas_object_show(view->status_ctxpopup);
}

static void _show_reminder_context_popup(create_view_data *ad)
{
	ad->reminder_ctxpopup = elm_ctxpopup_add(ad->naviframe);
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

/**
 * Callback function called when the user press reminder button
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _reminder_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	if (!ad->reminder_ctxpopup) {
		_show_reminder_context_popup(ad);
	} else {
		evas_object_del(ad->reminder_ctxpopup);
		ad->reminder_ctxpopup = NULL;
	}
}

/**
 * Callback function called when the user press recurrence button
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _recurrence_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	recurrence_view_add(ad->win, ad->naviframe, &ad->recurrence_data, _recurrence_btn_lable_changed_cb, ad);
}

static void _dismiss_sensitivity_context_popup(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *view_data = (create_view_data *)data;
	RETM_IF(!view_data, "Passed NULL input data");

	if (view_data->sensitivity_ctxpopup) {
		evas_object_del(view_data->sensitivity_ctxpopup);
		view_data->sensitivity_ctxpopup = NULL;
	}
}

static void _show_sensitivity_context_popup(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *view_data = (create_view_data *)data;
	RETM_IF(!view_data, "Passed NULL input data");

	if (view_data->sensitivity_ctxpopup) {
		evas_object_del(view_data->sensitivity_ctxpopup);
		view_data->sensitivity_ctxpopup = NULL;
	}

	view_data->sensitivity_ctxpopup = elm_ctxpopup_add(view_data->naviframe);
	evas_object_data_set(view_data->sensitivity_ctxpopup, KEY_PRIORITY_DATA, view_data);

	elm_ctxpopup_item_append(view_data->sensitivity_ctxpopup, "Public", NULL, _sensitivity_btn_lable_changed_cb, (void *)CALENDAR_SENSITIVITY_PUBLIC);
	elm_ctxpopup_item_append(view_data->sensitivity_ctxpopup, "Private", NULL, _sensitivity_btn_lable_changed_cb, (void *)CALENDAR_SENSITIVITY_PRIVATE);
	elm_ctxpopup_item_append(view_data->sensitivity_ctxpopup, "Confidential", NULL, _sensitivity_btn_lable_changed_cb, (void *)CALENDAR_SENSITIVITY_CONFIDENTIAL);

	evas_object_size_hint_weight_set(view_data->sensitivity_ctxpopup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	int x = 0;
	int y = 0;
	evas_object_geometry_get(view_data->sensitivity_btn, &x, &y, NULL, NULL);
	evas_object_move(view_data->sensitivity_ctxpopup, x, y);
	evas_object_smart_callback_add(view_data->sensitivity_ctxpopup, "dismissed", _dismiss_sensitivity_context_popup, view_data);

	evas_object_show(view_data->sensitivity_ctxpopup);
}

/**
 * Callback function called when the user press status button
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _status_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");
	if (!ad->status_ctxpopup) {
		_show_btn_status_context_popup(data);
	} else {
		evas_object_del(ad->status_ctxpopup);
		ad->status_ctxpopup = NULL;
	}
}

static void _scroll_genlist_top_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	RETM_IF(!ad, "Passed NULL input data");

	if (ad->genlist_location_item == (Elm_Object_Item *)event_info
	|| ad->genlist_description_item == (Elm_Object_Item *)event_info
	|| ad->genlist_reminder_item == (Elm_Object_Item *)event_info) {
		elm_genlist_item_show((Elm_Object_Item *)event_info, ELM_GENLIST_ITEM_SCROLLTO_MIDDLE);
	}
}

/**
 * Add title entry to create-view layout
 *
 * @param[in]	data	Data used in this function
 * @param[in]	part	The container's part name to set (some might accept
 *						@c NULL for the default part)
 * @param[in]	func	Func the callback function
 *
 * @return				An entry object
 */
static Evas_Object *_prepare_entry_box(create_view_data *item_data, const char *name, const char *hint, Evas_Smart_Cb func)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

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

	Evas_Object *entry = elm_entry_add(box);
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

	elm_box_pack_end(box, rect1);
	elm_box_pack_end(box, label);
	elm_box_pack_end(box, rect2);
	elm_box_pack_end(box, entry);

	return box;
}

/**
 * Add title entry to create-view layout
 *
 * @param[in]	data	Data used in this function
 *
 * @return				An entry object
 */
static Evas_Object *_entry_add(create_view_data *data, ENTRY_TYPE entry_type)
{
	RETVM_IF(!data, NULL, "Passed NULL input data");

	Evas_Object *box = NULL;
	switch (entry_type) {
		case TITLE_ENTRY:
			box = _prepare_entry_box(data, TITLE, TITLE_HINT, _title_entry_changed_cb);
			break;
		case LOCATION_ENTRY:
			box = _prepare_entry_box(data, LOCATION, LOCATION_HINT, _location_entry_changed_cb);
			break;
		case DESCRIPTION_ENTRY:
			box = _prepare_entry_box(data, DESCRIPTION, DESCRIPTION_HINT, _description_entry_changed_cb);
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
static char *_start_datetime_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), FROM);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static char *_end_datetime_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), TO);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static char *_timezone_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), TIME_ZONE);
	return strdup(buffer);
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
	create_view_data *data = (create_view_data *)item_data;

	return _entry_add(data, TITLE_ENTRY);
}

static Evas_Object *_timezone_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;
	if (strcmp(part, "elm.swallow.end") != 0) {
		return NULL;
	}

	char time_zone_abbreviation[DATE_TIME_BUF_LEN] = {'\0'};
	char time_shift[DATE_TIME_BUF_LEN] = {'\0'};
	char output_text[DATE_TIME_BUF_LEN] = {'\0'};

	time_t local_time = time(NULL);
	struct tm *tm_localtime = localtime(&local_time);

	strftime(time_zone_abbreviation, sizeof(time_zone_abbreviation), "%Z", tm_localtime);
	strftime(time_shift, sizeof(time_shift), "%z", tm_localtime);

	snprintf(output_text, sizeof(output_text), "%s, %s", time_zone_abbreviation, time_shift);

	Evas_Object *label = elm_label_add(data->layout);
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), output_text);
	elm_object_text_set(label, buffer);
	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(label, EVAS_HINT_FILL, EVAS_HINT_FILL);

	return label;
}

static void _on_datetime_popup_cancel_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	create_view_data *view = data;
	_close_active_popup(view);
}

static void _on_datetime_popup_set_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	create_view_data *view = (create_view_data *)data;

	Elm_Object_Item *selected_item = elm_genlist_selected_item_get(view->genlist);

	if (selected_item == view->genlist_from_item) {
		elm_datetime_value_get(view->start_datetime, &view->stm);
		_close_active_popup(view);
	} else if (selected_item == view->genlist_to_item) {
		elm_datetime_value_get(view->end_datetime, &view->etm);
		_close_active_popup(view);
	}
	elm_genlist_item_update(selected_item);
}

static Evas_Object *_date_time_popup_add(Evas_Object *parent, create_view_data *view,
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

static void _get_start_datetime(create_view_data *view, Evas_Object *parent, const char *format)
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

static void _get_end_datetime(create_view_data *view, Evas_Object *parent, const char *format)
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
	create_view_data *view = (create_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_start_datetime(view, popup, "%d %b %Y");

	elm_object_content_set(popup, view->start_datetime);
}

static void _start_time_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	create_view_data *view = (create_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_start_datetime(view, popup, "%R");

	elm_object_content_set(popup, view->start_datetime);
}

static void _end_date_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	create_view_data *view = (create_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_end_datetime(view, popup, "%d %b %Y");

	elm_object_content_set(popup, view->end_datetime);
}

static void _end_time_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	RETM_IF(!data, "data is null");
	create_view_data *view = (create_view_data *)data;

	Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_end_datetime(view, popup, "%R");

	elm_object_content_set(popup, view->end_datetime);
}

static Evas_Object *_start_datetime_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

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

static Evas_Object *_end_datetime_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

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

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Allday label
 */
static char *_allday_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), ALL_DAY);
	return strdup(buffer);
}

/**
 * Callback function called when the allday changed
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _allday_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	create_view_data *ad = (create_view_data *)data;

	ad->is_allday = !ad->is_allday;

	elm_genlist_item_update(ad->genlist_from_item);
	elm_genlist_item_update(ad->genlist_to_item);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Checkbox object
 */
static Evas_Object *_allday_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") != 0) {
		return NULL;
	}

	data->all_day_btn = elm_check_add(data->layout);

	data->is_allday = EINA_FALSE;
	elm_check_state_set(data->all_day_btn, data->is_allday);
	elm_object_style_set(data->all_day_btn, "on&off");
	elm_check_state_set(data->all_day_btn, data->is_allday);
	evas_object_propagate_events_set(data->all_day_btn, EINA_FALSE);
	evas_object_smart_callback_add(data->all_day_btn, "changed", _allday_changed_cb, data);

	return data->all_day_btn;
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
	create_view_data *data = (create_view_data *)item_data;

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
	create_view_data *data = (create_view_data *)item_data;

	return _entry_add(data, DESCRIPTION_ENTRY);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Reminder label
 */
static char *_reminder_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), REMINDER);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Entry or button objects
 */
static Evas_Object *_reminder_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			Evas_Object *btn = elm_button_add(layout);
			evas_object_smart_callback_add(btn, "clicked", _reminder_btn_clicked_cb, data);
			elm_object_text_set(btn, data->reminder_type_name);
			data->reminder_btn = btn;
			evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
			elm_layout_content_set(layout, "elm.swallow.content", btn);
			return layout;
		}
	}

	return NULL;
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Recurrence label
 */
static char *_recurrence_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), RECURRENCE);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Button object
 */
static Evas_Object *_recurrence_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			Evas_Object *btn = elm_button_add(layout);
			elm_object_text_set(btn, "None");
			evas_object_smart_callback_add(btn, "clicked", _recurrence_btn_clicked_cb, data);
			data->recurrence_btn = btn;
			evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
			elm_layout_content_set(layout, "elm.swallow.content", btn);
			return layout;
		}
	}

	return NULL;
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Priority label
 */
static char *_priority_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), PRIORITY);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Button object
 */
static Evas_Object *_priority_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			Evas_Object *btn = elm_button_add(layout);
			evas_object_smart_callback_add(btn, "clicked", _show_priority_context_popup, data);
			data->priority_btn = btn;
			switch (data->priority) {
				case CALENDAR_EVENT_PRIORITY_LOW:
					elm_object_text_set(data->priority_btn, "Low");
					break;
				case CALENDAR_EVENT_PRIORITY_NORMAL:
					elm_object_text_set(data->priority_btn, "Normal");
					break;
				case CALENDAR_EVENT_PRIORITY_HIGH:
					elm_object_text_set(data->priority_btn, "High");
					break;
				default:
					break;
			}
			evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
			elm_layout_content_set(layout, "elm.swallow.content", btn);
			return layout;
		}
	}

	return NULL;
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Sensitivity label
 */
static char *_sensitivity_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), SENSITIVITY);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Button object
 */
static Evas_Object *_sensivity_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			Evas_Object *btn = elm_button_add(layout);
			evas_object_smart_callback_add(btn, "clicked", _show_sensitivity_context_popup, data);

			data->sensitivity_btn = btn;

			switch (data->sensitivity) {
				case CALENDAR_SENSITIVITY_PUBLIC:
					elm_object_text_set(data->sensitivity_btn, "Public");
					break;
				case CALENDAR_SENSITIVITY_PRIVATE:
					elm_object_text_set(data->sensitivity_btn, "Private");
					break;
				case CALENDAR_SENSITIVITY_CONFIDENTIAL:
					elm_object_text_set(data->sensitivity_btn, "Confidential");
					break;
			}
			evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
			elm_layout_content_set(layout, "elm.swallow.content", btn);
			return layout;
		}
	}

	return NULL;
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Status label
 */
static char *_status_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), STATUS);
	return strdup(buffer);
}

/**
 * Callback function called when the genlist item creates
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 * @return					Button object
 */
static Evas_Object *_status_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *layout = elm_layout_add(data->layout);
		if (layout) {
			elm_layout_theme_set(layout, "layout", "application", "default");
			Evas_Object *btn = elm_button_add(layout);
			evas_object_smart_callback_add(btn, "clicked", _status_btn_clicked_cb, data);

			data->status_btn = btn;
			elm_object_text_set(data->status_btn, settings_status_name_get(data->status));
			evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
			evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, EVAS_HINT_FILL);
			evas_object_size_hint_min_set(btn, ELM_BUTTON_WIDTH, ELM_BUTTON_HEIGHT);
			elm_layout_content_set(layout, "elm.swallow.content", btn);
			return layout;
		}
	}

	return NULL;
}

static Eina_Bool _create_view_navi_pop_cb(void *data, Elm_Object_Item *it)
{
	RETVM_IF(!data, EINA_FALSE, "Passed NULL input data");
	create_view_data *app = (create_view_data *)data;
	if (_close_active_popup(app)) {
		return EINA_FALSE;
	} else {
		evas_object_del(app->genlist);
		app->genlist = NULL;
		return EINA_TRUE;
	}
}

/**
 * Add items to genlist
 *
 * @param[in]	data	Data used in this function
 *
 */
static void genlist_items_append(create_view_data *data)
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

/**
 * Add genlist to naviframe
 *
 * @param[in]	data	Data used in this function
 *
 */
static void genlist_add(create_view_data *data)
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

/**
 * Add Create view
 *
 * @param[in]	win			Main window object
 * @param[in]	parent		Naviframe object
 * @return					Created layout or otherwise NULL
 *
 */
Evas_Object *create_view_add(window_obj *win, Evas_Object *parent)
{
	RETVM_IF(!win || !parent, NULL, "Passed NULL input data");

	create_view_data *data = calloc(1, sizeof(create_view_data));
	RETVM_IF(!data, NULL, "Cannot allocate memory");

	time_t time_now = time(0);

	data->win = win;
	data->naviframe = parent;
	data->is_allday = EINA_FALSE;
	data->priority = CALENDAR_EVENT_PRIORITY_LOW;
	data->sensitivity = CALENDAR_SENSITIVITY_PUBLIC;
	data->status = CALENDAR_EVENT_STATUS_NONE;
	data->recurrence_data.id = CALENDAR_RECURRENCE_NONE;
	data->recurrence_data.range_type = CALENDAR_RANGE_NONE;
	data->layout = ui_utils_layout_add(data->naviframe, _create_view_destroy_cb, data);
	data->reminder_type = CALENDAR_ALARM_TIME_UNIT_MINUTE;
	data->reminder_type_name = "None";

	/* Set current time */
	struct tm *loc_tm = localtime(&time_now);
	if (loc_tm) {
		data->stm = *loc_tm;
		data->etm = *loc_tm;
	}

	/* Setting layout properties */
	evas_object_size_hint_weight_set(data->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_layout_file_set(data->layout, GET_PATH(EDJ_NAME), "create_view_layout");

	/* Create genlist for Events control */
	genlist_add(data);
	genlist_items_append(data);

	/* Header for naviframe */
	data->naviframe_item = elm_naviframe_item_push(data->naviframe, "Add event", NULL, NULL, data->layout, NULL);
	elm_naviframe_item_pop_cb_set(data->naviframe_item, _create_view_navi_pop_cb, data);
	evas_object_show(data->layout);

	/* Footer for naviframe */
	Evas_Object *toolbar = ui_utils_toolbar_add(data->naviframe, data->naviframe_item);
	elm_toolbar_select_mode_set(toolbar, ELM_OBJECT_SELECT_MODE_NONE);
	elm_toolbar_item_append(toolbar, NULL, SAVE, _save_btn_clicked_cb, data);

	return data->layout;
}
