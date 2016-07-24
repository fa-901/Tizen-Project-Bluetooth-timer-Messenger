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

#ifndef __RECCURENCE_VIEW_H__
#define __RECCURENCE_VIEW_H__

#include <app.h>
#include <Elementary.h>
#include <calendar.h>

#include "window.h"
#include "config.h"

typedef struct
{
	calendar_recurrence_frequency_e		id;
	calendar_range_type_e				range_type;
	int									count;
	struct tm							tm;
} recurrence_repeat_data;

/**
 * Add Recurrence view
 *
 * @param[in]	win					Main window object
 * @param[in]	parent				Naviframe object
 * @param[out]	recurrence_data		Recurrence's type, count and time data
 * @param[in]	func				Callback function
 * @param[in]	func_data			Callback function's data
 */

void recurrence_view_add(window_obj *win, Evas_Object *parent, recurrence_repeat_data *recurrence_data, Evas_Smart_Cb func, void *func_data);

#endif /* __RECCURENCE_VIEW_H__ */
