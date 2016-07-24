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
#include <string.h>

#include "config.h"

#include "utils/event-record.h"
#include "utils/logger.h"
#include "utils/settings-utils.h"

calendar_record_h create_record_with_presets()
{
	calendar_record_h record = NULL;
	calendar_error_e error = CALENDAR_ERROR_NONE;

	const char *view_uri = "tizen.calendar_view.event";
	error = calendar_record_create(view_uri, &record);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_create() is failed(%x)", error);

	const char *organizer_name = "0";
	error = calendar_record_set_str(record, _calendar_event.organizer_name, organizer_name);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_str() is failed(%x)", error);

	error = calendar_record_set_int(record, _calendar_event.calendar_book_id, DEFAULT_EVENT_CALENDAR_BOOK_ID);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

	return record;
}

void set_record_title(calendar_record_h record, const char *title)
{
	char *utf8_title = elm_entry_markup_to_utf8(title);
	calendar_error_e error = calendar_record_set_str(record, _calendar_event.summary, utf8_title);
	free(utf8_title);

	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_str() is failed(%x)", error);
}

void set_record_time(const struct tm *time_start, const struct tm *time_end, calendar_record_h record, Eina_Bool allday)
{
	RETM_IF(!time_start || !time_end || !record, "Passed NULL input data");
	calendar_error_e error = CALENDAR_ERROR_NONE;

	calendar_time_s start_time;
	memset(&start_time, 0x0, sizeof(start_time));
	calendar_record_get_caltime(record, _calendar_event.start_time, &start_time);

	calendar_time_s end_time;
	memset(&end_time, 0x0, sizeof(end_time));
	calendar_record_get_caltime(record, _calendar_event.end_time, &end_time);

	if (allday) {
		start_time.type = CALENDAR_TIME_LOCALTIME;
		end_time.type = CALENDAR_TIME_LOCALTIME;

		start_time.time.date.year = time_start->tm_year + TM_START_YEAR;
		start_time.time.date.month = time_start->tm_mon + TM_START_MONTH;
		start_time.time.date.mday = time_start->tm_mday;
		DBG("START TIME IS: Year:%d, Month:%d, Day:%d\n", start_time.time.date.year, start_time.time.date.month, start_time.time.date.mday);

		end_time.time.date.year = time_end->tm_year + TM_START_YEAR;
		end_time.time.date.month = time_end->tm_mon + TM_START_MONTH;
		end_time.time.date.mday = time_end->tm_mday;
		DBG("END TIME IS: Year:%d, Month:%d, Day:%d\n", end_time.time.date.year, end_time.time.date.month, end_time.time.date.mday);
	} else {
		struct tm start_time_buffer = *time_start;
		struct tm end_time_buffer = *time_end;

		start_time.type = CALENDAR_TIME_UTIME;
		end_time.type = CALENDAR_TIME_UTIME;
		start_time_buffer.tm_sec = 0;
		end_time_buffer.tm_sec = 0;
		start_time.time.utime = mktime(&start_time_buffer);
		end_time.time.utime = mktime(&end_time_buffer);
	}

	error = calendar_record_set_caltime(record, _calendar_event.start_time, start_time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_caltime() is failed(%x)", error);

	error = calendar_record_set_caltime(record, _calendar_event.end_time, end_time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_caltime() is failed(%x)", error);

	int alld = -1;
	error = calendar_record_get_int(record, _calendar_event.is_allday, &alld);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() is failed(%x)", error);
}

void get_record_time(calendar_record_h record, struct tm *time_start, struct tm *time_end)
{
	RETM_IF(!record, "Passed NULL record");
	calendar_error_e error = CALENDAR_ERROR_NONE;

	calendar_time_s start_time;
	memset(&start_time, 0x0, sizeof(start_time));

	calendar_time_s end_time;
	memset(&end_time, 0x0, sizeof(end_time));

	error = calendar_record_get_caltime(record, _calendar_event.start_time, &start_time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_caltime() is failed(%x)", error);

	error = calendar_record_get_caltime(record, _calendar_event.end_time, &end_time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_caltime() is failed(%x)", error);

	struct tm time_start_temp = {0};
	struct tm time_end_temp = {0};

	if (start_time.type == CALENDAR_TIME_UTIME) {
		const time_t date = start_time.time.utime;
		time_start_temp = *localtime(&date);
	} else {
		time_start_temp.tm_year = start_time.time.date.year - TM_START_YEAR;
		time_start_temp.tm_mon = start_time.time.date.month - TM_START_MONTH;
		time_start_temp.tm_mday = start_time.time.date.mday;
	}

	if (end_time.type == CALENDAR_TIME_UTIME) {
		const time_t date = end_time.time.utime;
		time_end_temp = *localtime(&date);
	} else {
		time_end_temp.tm_year = end_time.time.date.year - TM_START_YEAR;
		time_end_temp.tm_mon = end_time.time.date.month - TM_START_MONTH;
		time_end_temp.tm_mday = end_time.time.date.mday;
	}

	memcpy(time_start, &time_start_temp, sizeof(struct tm));
	memcpy(time_end, &time_end_temp, sizeof(struct tm));
}

/**
 * Get extended child record
 *
 * @param[in]	record			Calendar's record object
 * @param[in]	extended_key	The name string of one of the existing calendar's property key.
 *
 * @return						Child record of passed calendar's record object
 */
static calendar_record_h get_extended_record(calendar_record_h record, const char *extended_key)
{
	calendar_record_h child_record = NULL;

	calendar_error_e error = CALENDAR_ERROR_NONE;

	unsigned int child_record_count = 0;

	unsigned int property_id = _calendar_event.extended;

	error = calendar_record_get_child_record_count(record, property_id, &child_record_count);

	int i;
	for (i = 0; i < child_record_count; i++) {

		error = calendar_record_get_child_record_at_p(record, property_id, i, &child_record);
		if (error != CALENDAR_ERROR_NONE) {
			continue;
		}

		char *key = NULL;

		error = calendar_record_get_str_p(child_record, _calendar_extended_property.key, &key);
		if (error != CALENDAR_ERROR_NONE) {
			continue;
		}

		if (key && !strcmp(key, extended_key)) {
			return child_record;
		}

	}

	return NULL;
}

void set_record_timezone_city(calendar_record_h record)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	char time_zone_abbreviation[DATE_TIME_BUF_LEN] = {'\0'};
	char time_zone_shift[DATE_TIME_BUF_LEN] = {'\0'};
	char output_text[DATE_TIME_BUF_LEN] = {'\0'};

	time_t local_time = time(NULL);
	struct tm *tm_localtime = localtime(&local_time);

	strftime(time_zone_abbreviation, sizeof(time_zone_abbreviation), "%Z", tm_localtime);
	strftime(time_zone_shift, sizeof(time_zone_shift), "%z", tm_localtime);

	snprintf(output_text, sizeof(output_text), "%s, %s", time_zone_abbreviation, time_zone_shift);

	error = calendar_record_set_str(record, _calendar_event.start_tzid, output_text);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

	error = calendar_record_set_str(record, _calendar_event.end_tzid, output_text);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

	calendar_record_h child_record = get_extended_record(record, "city");

	unsigned int property_id = _calendar_event.extended;

	if (!child_record) {
		error = calendar_record_create(_calendar_extended_property._uri, &child_record);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

		error = calendar_record_add_child_record(record, property_id, child_record);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

		error = calendar_record_set_str(child_record, _calendar_extended_property.key, "city");
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
	}

	const char *city = "IDS_WCL_BODY_CITYNAME_SEOUL";
	error = calendar_record_set_str(child_record, _calendar_extended_property.value, city);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

void set_record_location(calendar_record_h record, const char *address, double latitude, double longitude)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	if (address && strlen(address)) {
		error = calendar_record_set_str(record, _calendar_event.location, address);
	} else {
		error = calendar_record_set_str(record, _calendar_event.location, NULL);
	}

	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_str() is failed(%x)", error);

	error = calendar_record_set_double(record, _calendar_event.latitude, latitude);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_double() is failed(%x)", error);

	error = calendar_record_set_double(record, _calendar_event.longitude, longitude);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_double() is failed(%x)", error);
}

void set_record_note(calendar_record_h record, const char *note_str)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_set_str(record, _calendar_event.description, note_str);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_str() is failed(%x)", error);
}

void set_record_priority(calendar_record_h record, int priority)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_set_int(record, _calendar_event.priority, priority);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

void set_record_sensitivity(calendar_record_h record, int sensitivity)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_set_int(record, _calendar_event.sensitivity, sensitivity);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

void set_record_status(calendar_record_h record, int status)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_set_int(record, _calendar_event.event_status, status);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

/**
 * Add child record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	reminder	The reminder time
 * @param[in]	type		The reminder type
 *
 * @return					Child record with reminder's alarm
 */
static void _set_alarm_reminder(calendar_record_h alarm, int reminder, calendar_alarm_time_unit_type_e type)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;
	if (CALENDAR_ALARM_NONE == type) {
		error = calendar_record_set_int(alarm, _calendar_alarm.tick_unit, CALENDAR_ALARM_NONE);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
		return;
	}
	error = calendar_record_set_int(alarm, _calendar_alarm.tick, reminder);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

	error = calendar_record_set_int(alarm, _calendar_alarm.tick_unit, type);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

static calendar_record_h create_reminder_child_record(int reminder, calendar_alarm_time_unit_type_e type)
{
	calendar_record_h calendar_alarm = NULL;
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_create(_calendar_alarm._uri, &calendar_alarm);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_add_child_record() is failed(%x)", error);

	_set_alarm_reminder(calendar_alarm, reminder, type);

	return calendar_alarm;
}

void set_record_reminder(calendar_record_h record, const char *name)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;
	unsigned int count = 0;
	calendar_record_h calendar_alarm = NULL;
	int reminder = settings_reminder_get(name);
	DBG("Type: %d, reminder: %d", settings_reminder_type_get(name), reminder);
	calendar_record_get_child_record_count(record, _calendar_event.calendar_alarm, &count);
	if (count > 0) {
		calendar_record_get_child_record_at_p(record, _calendar_event.calendar_alarm, 0, &calendar_alarm);
		_set_alarm_reminder(calendar_alarm, reminder, settings_reminder_type_get(name));
	} else {
		calendar_alarm = create_reminder_child_record(reminder, settings_reminder_type_get(name));
		error = calendar_record_add_child_record(record, _calendar_event.calendar_alarm, calendar_alarm);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_add_child_record() is failed(%x)", error);
	}
}

void get_record_reminder(calendar_record_h record, int *reminder, calendar_alarm_time_unit_type_e *type)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;
	calendar_record_h calendar_alarm = NULL;
	error = calendar_record_get_child_record_at_p(record, _calendar_event.calendar_alarm, 0, &calendar_alarm);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_child_record() is failed(%x)", error);

	if (reminder) {
		error = calendar_record_get_int(calendar_alarm, _calendar_alarm.tick, reminder);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() reminder tick is failed(%x)", error);
	}
	if (type) {
		error = calendar_record_get_int(calendar_alarm, _calendar_alarm.tick_unit, type);
		WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_get_int() reminder tick_unit is failed(%x)", error);
	}
}

void set_record_recurrence(calendar_record_h record, int recurrence_id)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	char id_str[DATE_TIME_BUF_LEN] = {'\0'};
	snprintf(id_str, DATE_TIME_BUF_LEN, "%d", recurrence_id);

	error = calendar_record_set_str(record, _calendar_event.recurrence_id, id_str);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_str() is failed(%x)", error);

	error = calendar_record_set_int(record, _calendar_event.freq, recurrence_id);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);

	error = calendar_record_set_int(record, _calendar_event.interval, 1);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

void set_record_repeat_range_type(calendar_record_h record, int type)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_set_int(record, _calendar_event.range_type, type);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

void set_record_repeat_count(calendar_record_h record, int count)
{
	calendar_error_e error = CALENDAR_ERROR_NONE;

	error = calendar_record_set_int(record, _calendar_event.count, count);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_int() is failed(%x)", error);
}

void set_record_repeat_until_time(calendar_record_h record, const struct tm *until_time)
{
	RETM_IF(!until_time, "Passed NULL input data");
	calendar_error_e error = CALENDAR_ERROR_NONE;

	calendar_time_s time = {0};
	calendar_record_get_caltime(record, _calendar_event.until_time, &time);

	struct tm time_buffer = *until_time;

	time.type = CALENDAR_TIME_UTIME;
	time.time.utime = mktime(&time_buffer);

	error = calendar_record_set_caltime(record, _calendar_event.until_time, time);
	WARN_IF(error != CALENDAR_ERROR_NONE, "calendar_record_set_caltime() is failed(%x)", error);
}
