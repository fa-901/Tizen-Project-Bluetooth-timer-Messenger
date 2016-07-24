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

#include "config.h"

#include "utils/settings-utils.h"
#include "utils/logger.h"

const char *settings_status_name_get(calendar_event_status_e status)
{
	int i;
	for (i = 0; i < status_info_size; i++) {
		if (status == status_info[i].type) {
			return status_info[i].name;
		}
	}
	return NULL;
}

const char *settings_reminder_name_get(calendar_alarm_time_unit_type_e reminder_type, int reminder)
{
	int i;
	for (i = 0; i < reminder_info_size; i++) {
		if (reminder_type == reminder_info[i].type && reminder == reminder_info[i].reminder) {
			return reminder_info[i].name;
		}
	}
	return reminder_info[0].name;
}

const calendar_alarm_time_unit_type_e settings_reminder_type_get(const char *name)
{
	int i;
	for (i = 0; i < reminder_info_size; i++) {
		if (0 == strcmp(reminder_info[i].name, name)) {
			return reminder_info[i].type;
		}
	}
	return reminder_info[0].type;
}

const int settings_reminder_get(const char *name)
{
	int i;
	for (i = 0; i < reminder_info_size; i++) {
		if (0 == strcmp(reminder_info[i].name, name)) {
			return reminder_info[i].reminder;
		}
	}
	return reminder_info[0].reminder;
}

const int get_system_font_size()
{
	int fontSize = 0;
	Eina_Bool res = edje_text_class_get("entry", NULL, &fontSize);
	if (!res)
	{
		fontSize = TEXT_ITEM_DEFAULT_SIZE;
	}
	else if (fontSize < 0)
	{
		fontSize = -fontSize * TEXT_ITEM_DEFAULT_SIZE / 100;
	}

	if (fontSize > TEXT_MAX_GOOD_SIZE)
	{
		fontSize = TEXT_MAX_GOOD_SIZE;
	}

	return fontSize;
}
