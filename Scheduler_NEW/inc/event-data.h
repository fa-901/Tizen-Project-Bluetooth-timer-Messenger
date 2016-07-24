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

#ifndef __EVENT_DATA_H__
#define __EVENT_DATA_H__

#include <Evas.h>

typedef struct _event_data event_data;

typedef enum
{
	EVENT_DATA_TITLE		= 0x0,
	EVENT_DATA_LOCATION		= 0x01,
	EVENT_DATA_DESCRIPTION	= 0x02,
	EVENT_DATA_START_DATE	= 0x03,
	EVENT_DATA_END_DATE		= 0x04,
	EVENT_DATA_ALL_DAY		= 0x05,
	EVENT_DATA_TIMEZONE		= 0x06,
	EVENT_DATA_REMINDER		= 0x07,
	EVENT_DATA_RECURRENCE	= 0x08,
	EVENT_DATA_PRIORITY		= 0x09,
	EVENT_DATA_SENSITIVITY	= 0x0A,
	EVENT_DATA_STATUS		= 0x0B
} event_data_attributes;

/**
 * @brief Gets title attribute of event_data object. NULL may be returned.
 * @param[in]	data	event_data structure
 * @param[in]	key		keyword for determination which attribute is to be returned
 * @return title string
 */
const char* event_data_get_value(event_data *data, event_data_attributes key);

/**
 * @brief Sets attribute value of event_data object
 * @param[in]	data	event_data structure
 * @param[in]	key		keyword for determination which attribute is to be set
 */
void event_data_set_value(event_data *data, event_data_attributes key, const char *str);

/**
 * @brief Copies resources from one struct to another
 * @param[in]	dest	event_data structure to be filled
 * @param[in]	src		event_data structure to be copied
 */
void event_data_copy(event_data *dest, event_data *src);

/**
 * @brief Creates resources for event in event_data structure
 * @return Filled structure
 */
event_data *event_data_create();

/**
 * @brief Releases resources occupied by event_data structure
 * @param[in]	data	event_data structure
 */
void event_data_release(event_data *data);

#endif // __EVENT_DATA_H__
