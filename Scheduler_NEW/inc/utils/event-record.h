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

#ifndef __EVENT_RECORD_H__
#define __EVENT_RECORD_H__

#include <Elementary.h>
#include <calendar.h>
#include <time.h>
#include "config.h"

/**
 * Create an record with basic presets
 *
 * @return		Calendar's record
 */
calendar_record_h create_record_with_presets();

/**
 * Set date-time for record
 *
 * @param[in]	time_start	date-time object, used by other time functions.
 * @param[in]	time_end	date-time object, used by other time functions.
 * @param[in]	record		Calendar's record object
 * @param[in]	is_all_day	Is all day event
 *
 */
void set_record_time(const struct tm *time_start, const struct tm *time_end, calendar_record_h record, Eina_Bool is_all_day);

/**
 * Get date-time from record
 *
 * @param[in]	record		Calendar's record object
 * @param[out]	time_start	date-time object, used by other time functions.
 * @param[out]	time_end	date-time object, used by other time functions.
 *
 */
void get_record_time(calendar_record_h record, struct tm *time_start, struct tm *time_end);

/**
 * Set current timezone for record
 *
 * @param[in]	record		Calendar's record object
 *
 */
void set_record_timezone_city(calendar_record_h record);

/**
 * Set location address for a record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	address		Location address of a record
 * @param[in]	latitude	Coordinate(latitude) of a record
 * @param[in]	longitude	Coordinate(longitude) of a record
 *
 */
void set_record_location(calendar_record_h record, const char *address, double latitude, double longitude);

/**
 * Set description for a record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	note_str	Description of a record
 *
 */
void set_record_note(calendar_record_h record, const char *note_str);

/**
 * Set title for a record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	title		Title of a record
 *
 */
void set_record_title(calendar_record_h record, const char *title);

/**
 * Set priority for record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	priority	Priority of a record
 *
 */
void set_record_priority(calendar_record_h record, int priority);

/**
 * Set sensitivity for record
 *
 * @param[in]	record			Calendar's record object
 * @param[in]	sensitivity		Sensitivity of a record
 *
 */
void set_record_sensitivity(calendar_record_h record, int sensitivity);

/**
 * Set status for record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	status		Status of a record
 *
 */
void set_record_status(calendar_record_h record, int status);

/**
 * Set status for record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	name		Reminder name.
 *
 */
void set_record_reminder(calendar_record_h record, const char *name);

/**
 * Get status for record
 *
 * @param[in]	record		Calendar's record object
 * @param[out]	reminder	Number of minutes, hours, days, weeks
 * @param[out]	type		Reminder type. Minutes, hours, days, weeks
 *
 */
void get_record_reminder(calendar_record_h record, int *reminder, calendar_alarm_time_unit_type_e *type);

/**
 * Set recurrence for record
 *
 * @param[in]	record			Calendar's record object
 * @param[in]	recurrence_id	The recurrence id
 *
 */
void set_record_recurrence(calendar_record_h record, int recurrence_id);

/**
 * Set repeat rangr type for record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	type		Repeat range type
 *
 */
void set_record_repeat_range_type(calendar_record_h record, int type);

/**
 * Set repeat count for record
 *
 * @param[in]	record		Calendar's record object
 * @param[in]	count		Repeat count
 *
 */
void set_record_repeat_count(calendar_record_h record, int count);

/**
 * Set date-time for record
 *
 * @param[in]	record			Calendar's record object
 * @param[in]	until_time		Time, until which event will repeats
 *
 */
void set_record_repeat_until_time(calendar_record_h record, const struct tm *until_time);

#endif /* __EVENT_RECORD_H__ */
