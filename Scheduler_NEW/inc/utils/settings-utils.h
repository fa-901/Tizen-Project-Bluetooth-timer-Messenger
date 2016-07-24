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

#ifndef __SETTINGS_UTILS_H__
#define __SETTINGS_UTILS_H__

#include <calendar.h>

/**
 * Status data
 */
typedef struct
{
	const char *name;
	calendar_event_status_e type;
}status_data;

/**
 * Status info array
 */
static const status_data status_info[] =
{
	{"None", CALENDAR_EVENT_STATUS_NONE},
	{"Tentative", CALENDAR_EVENT_STATUS_TENTATIVE},
	{"Confirmed", CALENDAR_EVENT_STATUS_CONFIRMED},
	{"Cancelled", CALENDAR_EVENT_STATUS_CANCELLED}
};

/**
 * Size of status_info array
 */
static const int status_info_size = sizeof(status_info)/sizeof(status_data);

/**
 * Reminder data
 */
typedef struct
{
	const char *name;
	int reminder;
	calendar_alarm_time_unit_type_e type;
}reminder_data;

/**
 * Reminder info array
 */
static const reminder_data reminder_info[] =
{
	{"None", 0, CALENDAR_ALARM_NONE},
	{"At start time", 0, CALENDAR_ALARM_TIME_UNIT_MINUTE},
	{"5 min before", 5, CALENDAR_ALARM_TIME_UNIT_MINUTE},
	{"15 min before", 15, CALENDAR_ALARM_TIME_UNIT_MINUTE},
	{"30 min before", 30, CALENDAR_ALARM_TIME_UNIT_MINUTE},
	{"1 hour before", 1, CALENDAR_ALARM_TIME_UNIT_HOUR},
	{"1 day before", 1, CALENDAR_ALARM_TIME_UNIT_DAY},
	{"1 week before", 1, CALENDAR_ALARM_TIME_UNIT_WEEK},
};

/**
 * Size of reminder_data array
 */
static const int reminder_info_size = sizeof(reminder_info)/sizeof(reminder_data);

/**
 * Get name by event status type
 *
 * @param[in]	status		Status type
 * @return					Status string representation
 */
const char *settings_status_name_get(calendar_event_status_e status);

/**
 * Get name by event reminder type
 *
 * @param[in]	reminder	Reminder type
 * @return					Reminder string representation
 */
const char *settings_reminder_name_get(calendar_alarm_time_unit_type_e reminder_type, int reminder);

/**
 * Get type by event reminder name
 *
 * @param[in]	reminder	Reminder name
 * @return					Reminder type representation
 */
const calendar_alarm_time_unit_type_e settings_reminder_type_get(const char *name);

/**
 * Get type by event reminder name
 *
 * @param[in]	reminder	Reminder name
 * @return					Reminder type representation
 */
const int settings_reminder_get(const char *name);

/**
 * Get current font size
 *
 * @return				Current font size
 */
const int get_system_font_size();

#endif /* __SETTINGS_UTILS_H__ */
