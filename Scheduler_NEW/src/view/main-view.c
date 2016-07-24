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

#include <Elementary.h>
#include <time.h>
#include <efl_extension.h>

#include "main-app.h"
#include "config.h"

#include "view/main-view.h"
#include "view/create-view.h"
#include "view/details-view.h"

#include "utils/event-record.h"
#include "utils/ui-utils.h"
#include "utils/logger.h"
#include "utils/settings-utils.h"

typedef struct {
	window_obj		*win;
	Evas_Object		*naviframe;
	Elm_Object_Item	*naviframe_item;

	Evas_Object		*layout_content;

	Evas_Object		*gl_allday_events;
	Evas_Object		*gl_events;
	Elm_Object_Item	*item[2];
	Evas_Object		*tab_bar;
	VIEW_TYPE		current_view;
	Elm_Genlist_Item_Class	*itc;
	int				max_records;
	int				*index_array;
	struct tm		current_time;
	int				added_rec_pos;
	time_t			view_time;
} main_view_data;

static void _get_daily_events(void *data, Evas_Object *gen_list, Eina_Bool no_all_day, Eina_Bool daily);

/**
 * Callback function used for changing view when tabbar view changed
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _tabbar_daily_clicked_cb(void *data, Evas_Object *obj,
					void *event_info)
{
	DBG("%s:%d Daily\n", __PRETTY_FUNCTION__, __LINE__);
	main_view_data *ad = (main_view_data *)data;
	if (data && ad->gl_allday_events) {
		ad->added_rec_pos = 0;
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_TRUE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_TRUE);
	}
	ad->current_view = DAILY;
}

/**
 * Callback function used for changing view when tabbar view changed
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _tabbar_monthly_clicked_cb(void *data, Evas_Object *obj,
					void *event_info)
{
	DBG("%s:%d Monthly\n", __PRETTY_FUNCTION__, __LINE__);
	main_view_data *ad = (main_view_data *)data;
	if (data && ad->gl_events) {
		ad->added_rec_pos = 0;
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_FALSE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_FALSE);
	}
	ad->current_view = MONTHLY;
}

/**
 * Create tabbar
 *
 * @param[in]	parent	Parent of the new tabbar object,
 * @param[in]	ad		Data used in this function.
 *
 * @return	NULL if create is failed,
 *			Pointer to new tabbar object if create successfully.
 */
static Evas_Object *_tabbar_create(Evas_Object *parent, main_view_data *ad)
{
	RETVM_IF(!parent, NULL, "Passed NULL input data");

	Evas_Object *obj = elm_toolbar_add(parent);
	elm_toolbar_shrink_mode_set(obj, ELM_TOOLBAR_SHRINK_EXPAND);
	elm_toolbar_transverse_expanded_set(obj, EINA_TRUE);
	elm_object_style_set(obj, "tabbar");
	elm_toolbar_select_mode_set(obj, ELM_OBJECT_SELECT_MODE_ALWAYS);

	ad->item[0] =
		elm_toolbar_item_append(obj, NULL,
					"Daily",
					_tabbar_daily_clicked_cb, ad);
	ad->item[1] =
		elm_toolbar_item_append(obj, NULL,
					"Monthly",
					_tabbar_monthly_clicked_cb, ad);

	return obj;
}

/**
 * Callback function used for obtain text for genlist item
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	part		The name string of one of the existing
 *							text parts in the Edje group implementing
 *							the item's theme
 *
 * @return					A strdup'()ed string. The caller will free() it when done.
 */
static char *_get_event_cb(void *data, Evas_Object *obj, const char *part)
{
	main_view_data *ad = (main_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETVM_IF(!ad, NULL, "Passed NULL input data");

	/*get events list*/
	calendar_error_e error = CALENDAR_ERROR_NONE;
	error = calendar_connect();
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_connect() is failed(%x)", error);

	calendar_record_h record;

	int record_id = (int)data;

	const char *view_uri = "tizen.calendar_view.event";
	error = calendar_db_get_record(view_uri, record_id, &record);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_get_record() is failed(%x)", error);

	char *name = NULL;
	error = calendar_record_get_str(record, _calendar_event.summary, &name);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_get_record() is failed(%x)", error);

	if (record) {
		calendar_record_destroy(record, EINA_TRUE);
	}
	error = calendar_disconnect();
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_disconnect() is failed(%x)", error);

	if (!name || !strlen(name)) {
		return strdup(NO_TITLE);
	} else {
		char buffer[FORMAT_BUFFER] = {0};
		snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), name);
		free(name);
		return strdup(buffer);
	}
}

static void _view_layout_del_cb(void *data, Evas *evas, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	main_view_data *ad = (main_view_data *)data;

	if (ad->current_view == DAILY) {
		ad->added_rec_pos = 0;
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_TRUE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_TRUE);
	} else {
		ad->added_rec_pos = 0;
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_FALSE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_FALSE);
	}
}

/**
 * Callback function called when the item is selected
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _item_sel_cb(void *data, Evas_Object *obj, void *event_info)
{
	main_view_data *ad = (main_view_data *)evas_object_data_get(obj, KEY_PRIORITY_DATA);
	RETM_IF(!ad, "Passed NULL input data");

	Elm_Object_Item *genlist_item = elm_genlist_selected_item_get(obj);

	int record_id = (int)data;
	Evas_Object *layout = details_view_add(ad->win, ad->naviframe, record_id);
	evas_object_event_callback_add(layout, EVAS_CALLBACK_DEL, _view_layout_del_cb, ad);
	elm_genlist_item_selected_set(genlist_item, EINA_FALSE);

	DBG("sel item data [%p] on genlist obj [%p], item pointer [%p]\n",
			data, obj, event_info);
}

/**
 * Set date-time for record
 *
 * @param[in]	record		Calendar's record object
 *
 * @return					Eina_True if event has duration all day
 *							and Eina_False if has a exact time
 */
static Eina_Bool _is_allday_record(calendar_record_h record)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	calendar_time_s start_time = {0};

	error = calendar_record_get_caltime(record, _calendar_event.start_time, &start_time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_caltime() is failed(%x)", error);

	if (start_time.type == CALENDAR_TIME_LOCALTIME)
		return EINA_TRUE;
	else
		return EINA_FALSE;
}

static Eina_Bool _is_date_inside_period(main_view_data *ad, calendar_time_s start_time, calendar_time_s end_time, Eina_Bool daily)
{
	struct tm cur_date = {0};
	cur_date.tm_year = ad->current_time.tm_year;
	cur_date.tm_mon = ad->current_time.tm_mon;

	struct tm start_date = {0};
	start_date.tm_year = start_time.time.date.year - TM_START_YEAR;
	start_date.tm_mon = start_time.time.date.month - TM_START_MONTH;

	struct tm end_date = {0};
	end_date.tm_year = end_time.time.date.year - TM_START_YEAR;
	end_date.tm_mon = end_time.time.date.month - TM_START_MONTH;

	if (daily) {
		cur_date.tm_mday = ad->current_time.tm_mday;
		start_date.tm_mday = start_time.time.date.mday;
		end_date.tm_mday = end_time.time.date.mday;
	}

	time_t cur_time_t = mktime(&cur_date);
	time_t start_time_t = mktime(&start_date);
	time_t end_time_t = mktime(&end_date);

	return ((cur_time_t >= start_time_t) &&(cur_time_t <= end_time_t));
}

static time_t _convert_calendar_time_to_time_t(calendar_time_s calendar_time, Eina_Bool daily)
{
	struct tm time_tm = {0};
	time_tm.tm_year = calendar_time.time.date.year - TM_START_YEAR;
	time_tm.tm_mon = calendar_time.time.date.month - TM_START_MONTH;

	if (daily) {
		time_tm.tm_mday = calendar_time.time.date.mday;
	}

	return mktime(&time_tm);
}

static time_t _convert_tm_time_to_time_t(struct tm *time, Eina_Bool daily)
{
	struct tm time_tm = {0};
	time_tm.tm_year = time->tm_year;
	time_tm.tm_mon = time->tm_mon;

	if (daily) {
		time_tm.tm_mday = time->tm_mday;
	}

	return mktime(&time_tm);
}

/**
 * Needs in case of increasing day from 31 to 32,
 * mktime resolve this problem increasing the day to appropriate date
 *
 * @param[out]	time_s	updated calendar_time_s struct
 */
static void _normalize_time(calendar_time_s *time_s)
{
	struct tm *converted_time;
	time_t rawtime = (*time_s).time.utime;
	converted_time = localtime(&rawtime);
	converted_time->tm_year = (*time_s).time.date.year - TM_START_YEAR;
	converted_time->tm_mon = (*time_s).time.date.month - TM_START_MONTH;
	converted_time->tm_mday = (*time_s).time.date.mday;
	mktime(converted_time);
	(*time_s).time.date.year = converted_time->tm_year + TM_START_YEAR;
	(*time_s).time.date.month = converted_time->tm_mon + TM_START_MONTH;
	(*time_s).time.date.mday = converted_time->tm_mday;
}

/**
 * Fill genlist by obtained events
 *
 * @param[in]	ad			Data used in this function
 * @param[out]	gen_list	The genlist object
 * @param[in]	no_all_day	EINA_TRUE if event has a time
 *							EINA_FALSE if allday event
 * @param[in]	daily		Daily of Monthly event will be added
 *
 */
static void _get_daily_events(void *data, Evas_Object *gen_list, Eina_Bool no_all_day, Eina_Bool daily)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_connect();
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_connect() is failed(%x)", error);

	/*remove all events from genlist*/
	main_view_data *ad = (main_view_data *)data;
	elm_genlist_clear(gen_list);

	/*create new genlist*/
	if (!ad->itc) {
		ad->itc = elm_genlist_item_class_new();
		ad->itc->item_style = "default";
		ad->itc->func.text_get = _get_event_cb;
		ad->itc->func.content_get = NULL;
		ad->itc->func.state_get = NULL;
		ad->itc->func.del = NULL;
	}

	/*add new events*/
	calendar_list_h list = NULL;
	error = calendar_db_get_all_records(_calendar_event._uri, 0, 0, &list);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_get_all_records() is failed(%x)", error);

	int count = 0;
	error = calendar_list_get_count(list, &count);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_list_get_count() is failed(%x)", error);

	calendar_record_h record = NULL;
	int index = 0;
	Eina_List *index_list = NULL;

	if (ad->added_rec_pos == 0 && ad->index_array) {
		free(ad->index_array);
		ad->index_array = calloc(count, sizeof(int));
	} else if (!ad->index_array) {
		ad->index_array = calloc(count, sizeof(int));
	}

	ad->max_records = count;

	int i;
	for (i = 0; i < count; i++) {
		error = calendar_list_get_current_record_p(list, &record);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_list_get_current_record_p() is failed(%x)", error);

		calendar_time_s start_time;
		calendar_time_s end_time;
		memset(&start_time, 0x0, sizeof(calendar_time_s));
		memset(&end_time, 0x0, sizeof(calendar_time_s));
		calendar_record_get_caltime(record, _calendar_event.start_time, &start_time);
		calendar_record_get_caltime(record, _calendar_event.end_time, &end_time);

		char *name = NULL;
		error = calendar_record_get_str(record, _calendar_event.summary, &name);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_db_get_record() is failed(%x)", error);
		if (start_time.type == CALENDAR_TIME_UTIME) {
			struct tm *converted_time;
			time_t rawtime = start_time.time.utime;
			converted_time = localtime(&rawtime);
			start_time.time.date.year = converted_time->tm_year + TM_START_YEAR;
			start_time.time.date.month = converted_time->tm_mon + TM_START_MONTH;
			start_time.time.date.mday = converted_time->tm_mday;
		}
		if (end_time.type == CALENDAR_TIME_UTIME) {
			struct tm *converted_time;
			time_t rawtime = end_time.time.utime;
			converted_time = localtime(&rawtime);
			end_time.time.date.year = converted_time->tm_year + TM_START_YEAR;
			end_time.time.date.month = converted_time->tm_mon + TM_START_MONTH;
			end_time.time.date.mday = converted_time->tm_mday;
		}

		if (_is_allday_record(record) == no_all_day) {
			calendar_list_next(list);
			continue;
		}

		int recurrence_id = 0;
		error = calendar_record_get_int(record, _calendar_event.freq, &recurrence_id);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);

		if (recurrence_id != CALENDAR_RECURRENCE_NONE) {
			int req_count = 0;
			error = calendar_record_get_int(record, _calendar_event.count, &req_count);
			WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);

			calendar_range_type_e range_type = CALENDAR_RANGE_NONE;
			error = calendar_record_get_int(record, _calendar_event.range_type, (int *)&range_type);
			WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);

			if (req_count >= 0 && range_type == CALENDAR_RANGE_COUNT) {
				while (--req_count > 0) {
					if (daily
								&& (start_time.time.date.year <= (ad->current_time.tm_year + TM_START_YEAR)
								&& end_time.time.date.year >= (ad->current_time.tm_year + TM_START_YEAR)
								&& start_time.time.date.month <= (ad->current_time.tm_mon + TM_START_MONTH)
								&& end_time.time.date.month >= (ad->current_time.tm_mon + TM_START_MONTH)
								&& start_time.time.date.mday <= ad->current_time.tm_mday
								&& end_time.time.date.mday >= ad->current_time.tm_mday)
						) {
						break; }
					else if (!daily
							&& (start_time.time.date.year <= (ad->current_time.tm_year + TM_START_YEAR)
							&& end_time.time.date.year >= (ad->current_time.tm_year + TM_START_YEAR)
							&& start_time.time.date.month <= (ad->current_time.tm_mon + TM_START_MONTH)
							&& end_time.time.date.month >= (ad->current_time.tm_mon + TM_START_MONTH))
							) {
						break;
					}

					int freq = 0;
					error = calendar_record_get_int(record, _calendar_event.freq, &freq);
					WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);
					switch (freq) {
						case CALENDAR_RECURRENCE_NONE:
							break;
						case CALENDAR_RECURRENCE_DAILY:
							start_time.time.date.mday++;
							end_time.time.date.mday++;
							break;
						case CALENDAR_RECURRENCE_WEEKLY:
							start_time.time.date.mday += DAYS_IN_WEEK;
							end_time.time.date.mday += DAYS_IN_WEEK;
							break;
						case CALENDAR_RECURRENCE_MONTHLY:
							start_time.time.date.month++;
							end_time.time.date.month++;
							break;
						case CALENDAR_RECURRENCE_YEARLY:
							start_time.time.date.year++;
							end_time.time.date.year++;
							break;
						default:
							break;
					}

					_normalize_time(&start_time);
					_normalize_time(&end_time);
				}

				if (!_is_date_inside_period(ad, start_time, end_time, daily)) {
					calendar_list_next(list);
					continue;
				}
			} else {
				calendar_time_s untile_date = {0};
				error = calendar_record_get_caltime(record, _calendar_event.until_time, &untile_date);
				WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_caltime() is failed(%x)", error);

				time_t event_start_time = _convert_calendar_time_to_time_t(start_time, daily);

				time_t current_time = _convert_tm_time_to_time_t(&ad->current_time, daily);

				if (recurrence_id == CALENDAR_RECURRENCE_DAILY) {
					if ((event_start_time > current_time) || (current_time > untile_date.time.utime)) {
						calendar_list_next(list);
						continue;
					}
				} else if (recurrence_id == CALENDAR_RECURRENCE_WEEKLY) {
					time_t event_end_time = _convert_calendar_time_to_time_t(end_time, daily);

					if (current_time < event_start_time || current_time > untile_date.time.utime) {
						calendar_list_next(list);
						continue;
					} else if (daily) {
						double event_duration = difftime(event_end_time, event_start_time);
						double diff_current_time_from_start_time = difftime(current_time, event_start_time);

						long int diff_weeks = diff_current_time_from_start_time / SECONDS_IN_WEEK;
						event_start_time = event_start_time + diff_weeks * SECONDS_IN_WEEK;

						event_end_time = event_start_time + event_duration;

						if ((event_start_time > current_time) || (current_time > event_end_time)) {
							calendar_list_next(list);
							continue;
						}
					}
				} else if (recurrence_id == CALENDAR_RECURRENCE_MONTHLY) {
					if (current_time < event_start_time || current_time > untile_date.time.utime) {
						calendar_list_next(list);
						continue;
					} else if (daily) {
						if ((start_time.time.date.mday > ad->current_time.tm_mday) || (ad->current_time.tm_mday > end_time.time.date.mday)) {
							calendar_list_next(list);
							continue;
						}
					}
				} else if (recurrence_id == CALENDAR_RECURRENCE_YEARLY) {
					time_t event_end_time = _convert_calendar_time_to_time_t(end_time, daily);

					if (current_time > untile_date.time.utime || current_time < event_start_time) {
						calendar_list_next(list);
						continue;
					} else {
						start_time.time.date.year = ad->current_time.tm_year + TM_START_YEAR;
						end_time.time.date.year = ad->current_time.tm_year + TM_START_YEAR;

						event_start_time = _convert_calendar_time_to_time_t(start_time, daily);

						event_end_time = _convert_calendar_time_to_time_t(end_time, daily);

						if ((event_start_time > current_time) || (current_time > event_end_time)) {
							calendar_list_next(list);
							continue;
						}
					}
				}
			}
		} else {
			if (!_is_date_inside_period(ad, start_time, end_time, daily)) {
				calendar_list_next(list);
				continue;
			}
		}

		error = calendar_record_get_int(record, _calendar_event.id, &index);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);

		*(ad->index_array + ad->added_rec_pos) = index;
		if (index != DEFAULT_EVENT_CALENDAR_BOOK_ID && index != DEFAULT_TODO_CALENDAR_BOOK_ID) {
			index_list = eina_list_append(index_list, (void *)index);
		}

		evas_object_data_set(gen_list, KEY_PRIORITY_DATA, ad);
		elm_genlist_item_append(gen_list, ad->itc,
								(void *)index, NULL,
								ELM_GENLIST_ITEM_NONE,
								_item_sel_cb, (void *)index);

		calendar_list_next(list);
		ad->added_rec_pos++;
	}

	eina_list_free(index_list);
	error = calendar_list_destroy(list, true);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_list_destroy() is failed(%x)", error);

	error = calendar_disconnect();
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);

	elm_genlist_item_class_free(ad->itc);
	ad->itc = NULL;
}

/**
 * Callback function called when the create button is clicked
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _create_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Passed NULL input data");
	main_view_data *ad = (main_view_data *)data;

	elm_toolbar_item_selected_set(elm_toolbar_selected_item_get(obj), EINA_FALSE);

	Evas_Object *create_layout = create_view_add(ad->win, ad->naviframe);
	evas_object_event_callback_add(create_layout, EVAS_CALLBACK_DEL, _view_layout_del_cb, data);
}

/**
 * Callback function called when previous button pressed
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _prev_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	main_view_data *ad = (main_view_data *)data;
	if (ad->current_view == DAILY) {
		ad->view_time -= SECONDS_IN_DAY;
		ad->current_time = *(localtime(&ad->view_time));
	} else {
		ad->current_time.tm_mon--;
		int tm_month = ad->current_time.tm_mon;
		if (tm_month < 0) {
			tm_month += MONTHS;
		}
		ad->view_time = mktime(&ad->current_time);
		ad->current_time = *(localtime(&ad->view_time));
		if (tm_month != ad->current_time.tm_mon) {
			ad->current_time.tm_mon++;
			ad->view_time = mktime(&ad->current_time);
			ad->current_time = *(localtime(&ad->view_time));
		}
		while (tm_month != ad->current_time.tm_mon) {
			ad->view_time -= SECONDS_IN_DAY;
			ad->current_time = *(localtime(&ad->view_time));
		}
	}

	char time_str[DATE_TIME_BUF_LEN] = {'\0'};
	strftime(time_str, DATE_TIME_BUF_LEN, "%d %b %Y", &ad->current_time);
	elm_object_item_text_set(ad->naviframe_item, time_str);

	ad->added_rec_pos = 0;
	if (ad->current_view == DAILY) {
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_TRUE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_TRUE);
	} else {
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_FALSE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_FALSE);
	}
}

/**
 * Callback function called when next button pressed
 *
 * @param[in]	data		Data used in this function
 * @param[in]	obj			Evas_Object which emit this event
 * @param[in]	event_info	Information about such event
 *
 */
static void _next_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	main_view_data *ad = (main_view_data *)data;

	if (ad->current_view == DAILY) {
		ad->view_time += SECONDS_IN_DAY;
		ad->current_time = *(localtime(&ad->view_time));
	} else {
		ad->current_time.tm_mon++;
		int tm_month = ad->current_time.tm_mon;
		tm_month %= MONTHS;
		ad->view_time = mktime(&ad->current_time);
		ad->current_time = *(localtime(&ad->view_time));
		while (tm_month != ad->current_time.tm_mon) {
			ad->view_time -= SECONDS_IN_DAY;
			ad->current_time = *(localtime(&ad->view_time));
		}
	}

	char time_str[DATE_TIME_BUF_LEN] = {'\0'};
	strftime(time_str, DATE_TIME_BUF_LEN, "%d %b %Y", &ad->current_time);
	elm_object_item_text_set(ad->naviframe_item, time_str);

	ad->added_rec_pos = 0;
	if (ad->current_view == DAILY) {
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_TRUE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_TRUE);
	} else {
		_get_daily_events(data, ad->gl_allday_events, EINA_FALSE, EINA_FALSE);
		_get_daily_events(data, ad->gl_events, EINA_TRUE, EINA_FALSE);
	}
}

static void _main_view_hardware_buttons_cb(void *data, Evas_Object *type, void *event)
{
	RETM_IF(!data, "input data == NULL");
	main_view_data *ad = data;

	if (ad->naviframe_item == elm_naviframe_top_item_get(ad->naviframe)) {
		elm_win_lower(ad->win->win);
	} else {
		elm_naviframe_item_pop(ad->naviframe);
	}
}

/**
 * Create main view
 *
 * @param[in]	app			Global app data
 * @param[in]	parent		Naviframe object
 *
 */
void main_view_add(struct _app_data *app, Evas_Object *parent)
{
	RETM_IF(!app || !parent, "Passed NULL input data");

	main_view_data *data = calloc(1, sizeof(main_view_data));
	data->win = app->win;
	data->naviframe = parent;
	app->main_view_data = data;

	data->layout_content = elm_layout_add(data->naviframe);
	elm_layout_file_set(data->layout_content, GET_PATH(EDJ_NAME), "scheduler_layout");
	evas_object_size_hint_weight_set(data->layout_content, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->layout_content, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(data->layout_content);

	/*create buttons*/
	Evas_Object *btn_prev = elm_button_add(data->layout_content);
	elm_object_part_content_set(data->layout_content, "elm.swallow.btn.prev", btn_prev);
	elm_object_text_set(btn_prev, PREVIOUS);
	evas_object_show(btn_prev);
	Evas_Object *btn_next = elm_button_add(data->layout_content);
	elm_object_part_content_set(data->layout_content, "elm.swallow.btn.next", btn_next);
	elm_object_text_set(btn_next, NEXT);
	evas_object_show(btn_next);
	evas_object_smart_callback_add(btn_prev, "clicked", _prev_btn_clicked_cb, data);
	evas_object_smart_callback_add(btn_next, "clicked", _next_btn_clicked_cb, data);

	/*create Labels for genlist*/
	Evas_Object *label_all_days = elm_label_add(data->layout_content);
	evas_object_size_hint_weight_set(label_all_days, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(label_all_days, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_content_set(data->layout_content, "elm.swallow.label.allday", label_all_days);
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), ALL_DAY_EVENTS);
	elm_object_text_set(label_all_days, buffer);
	evas_object_show(label_all_days);

	/*Create genlist All Day Events*/
	data->gl_allday_events = ui_utils_create_genlist(data->layout_content);
	evas_object_size_hint_weight_set(data->gl_allday_events, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->gl_allday_events, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_content_set(data->layout_content, "elm.swallow.genlist.allday", data->gl_allday_events);
	evas_object_show(data->gl_allday_events);

	Evas_Object *label_object_events = elm_label_add(data->layout_content);
	evas_object_size_hint_weight_set(label_object_events, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(label_object_events, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_content_set(data->layout_content, "elm.swallow.label.events", label_object_events);
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), EVENTS);
	elm_object_text_set(label_object_events, buffer);
	evas_object_show(label_object_events);

	/*Create genlist Events*/
	data->gl_events = ui_utils_create_genlist(data->layout_content);
	evas_object_size_hint_weight_set(data->gl_events, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->gl_events, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_content_set(data->layout_content, "elm.swallow.genlist.events", data->gl_events);
	evas_object_show(data->gl_events);

	/*Header for naviframe*/
	char time_str[DATE_TIME_BUF_LEN] = {'\0'};
	time(&data->view_time);
	data->current_time = *localtime(&data->view_time);
	strftime(time_str, DATE_TIME_BUF_LEN, "%d %b %Y", &data->current_time);

	data->naviframe_item = elm_naviframe_item_push(data->naviframe, time_str, NULL, NULL, data->layout_content, NULL);

	/*create tabbar*/
	data->tab_bar = _tabbar_create(data->layout_content, data);
	if (data->tab_bar) {
		elm_object_part_content_set(data->layout_content, "elm.swallow.tabbar", data->tab_bar);
		evas_object_show(data->tab_bar);
		data->current_view = DAILY;
	}

	/*Footer for naviframe*/
	Evas_Object *toolbar = elm_toolbar_add(data->naviframe);
	if (toolbar) {
		elm_toolbar_shrink_mode_set(toolbar, ELM_TOOLBAR_SHRINK_EXPAND);
		elm_toolbar_transverse_expanded_set(toolbar, EINA_TRUE);
		if (data->naviframe_item) {
			elm_object_item_part_content_set(data->naviframe_item, "toolbar", toolbar);
		}
	}
	elm_toolbar_item_append(toolbar, NULL, CREATE, _create_btn_clicked_cb, data);

	eext_object_event_callback_add(data->naviframe, EEXT_CALLBACK_BACK, _main_view_hardware_buttons_cb, data);
	eext_object_event_callback_add(data->layout_content, EEXT_CALLBACK_BACK, _main_view_hardware_buttons_cb, data);
}
