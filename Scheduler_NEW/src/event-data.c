/*
 * Copyright (c) 2015 Samsung Electronics Co., Ltd All Rights Reserved
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

#include "event-data.h"

struct _event_data
{
	char				*title;
	char				*timezone;
	char				*start_date;
	char				*end_date;
	char				*allday;
	char				*location;
	char				*description;
	char				*reminder;
	char				*recurrence;
	char				*priority;
	char				*sensivity;
	char				*status;
};

const char* event_data_get_value(event_data *data, event_data_attributes key)
{
	if (!data) {
		return NULL;
	}

	switch (key) {
		case EVENT_DATA_TITLE:
			return data->title;
		case EVENT_DATA_LOCATION:
			return data->location;
		case EVENT_DATA_DESCRIPTION:
			return data->description;
		case EVENT_DATA_START_DATE:
			return data->start_date;
		case EVENT_DATA_END_DATE:
			return data->end_date;
		case EVENT_DATA_ALL_DAY:
			return data->allday;
		case EVENT_DATA_TIMEZONE:
			return data->timezone;
		case EVENT_DATA_REMINDER:
			return data->reminder;
		case EVENT_DATA_RECURRENCE:
			return data->recurrence;
		case EVENT_DATA_PRIORITY:
			return data->priority;
		case EVENT_DATA_SENSITIVITY:
			return data->sensivity;
		case EVENT_DATA_STATUS:
			return data->status;
		default:
			return "";
	}
};

void event_data_set_value(event_data *data, event_data_attributes key, const char *str)
{
	if (!data || !str) {
		return;
	}

	switch (key) {
		case EVENT_DATA_TITLE:
			free(data->title);
			data->title = strdup(str);
			break;
		case EVENT_DATA_LOCATION:
			free(data->location);
			data->location = strdup(str);
			break;
		case EVENT_DATA_DESCRIPTION:
			free(data->description);
			data->description = strdup(str);
			break;
		case EVENT_DATA_START_DATE:
			free(data->start_date);
			data->start_date = strdup(str);
			break;
		case EVENT_DATA_END_DATE:
			free(data->end_date);
			data->end_date = strdup(str);
			break;
		case EVENT_DATA_ALL_DAY:
			free(data->allday);
			data->allday = strdup(str);
			break;
		case EVENT_DATA_TIMEZONE:
			free(data->timezone);
			data->timezone = strdup(str);
			break;
		case EVENT_DATA_REMINDER:
			free(data->reminder);
			data->reminder = strdup(str);
			break;
		case EVENT_DATA_RECURRENCE:
			free(data->recurrence);
			data->recurrence = strdup(str);
			break;
		case EVENT_DATA_PRIORITY:
			free(data->priority);
			data->priority = strdup(str);
			break;
		case EVENT_DATA_SENSITIVITY:
			free(data->sensivity);
			data->sensivity = strdup(str);
			break;
		case EVENT_DATA_STATUS:
			free(data->status);
			data->status = strdup(str);
			break;
		default:
			break;
	}
};

void event_data_copy(event_data *dest, event_data *src)
{
	if (src->title) {
		dest->title = strdup(src->title);
	}
	if (src->location) {
		dest->location = strdup(src->location);
	}
	if (src->description) {
		dest->description = strdup(src->description);
	}
	if (src->start_date) {
		dest->start_date = strdup(src->start_date);
	}
	if (src->end_date) {
		dest->end_date = strdup(src->end_date);
	}
	if (src->allday) {
		dest->allday = strdup(src->allday);
	}
	if (src->timezone) {
		dest->timezone = strdup(src->timezone);
	}
	if (src->reminder) {
		dest->reminder = strdup(src->reminder);
	}
	if (src->recurrence) {
		dest->recurrence = strdup(src->recurrence);
	}
	if (src->sensivity) {
		dest->sensivity = strdup(src->sensivity);
	}
	if (src->priority) {
		dest->priority = strdup(src->priority);
	}
	if (src->status) {
		dest->status = strdup(src->status);
	}
};

event_data *event_data_create()
{
	return calloc(1, sizeof(event_data));
};

void event_data_release(event_data *data)
{
	free(data->title);
	free(data->location);
	free(data->description);
	free(data->start_date);
	free(data->end_date);
	free(data->allday);
	free(data->timezone);
	free(data->reminder);
	free(data->recurrence);
	free(data->priority);
	free(data->sensivity);
	free(data->status);
	free(data);
};
