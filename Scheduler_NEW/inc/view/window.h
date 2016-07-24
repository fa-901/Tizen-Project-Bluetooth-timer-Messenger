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

#ifndef __WINDOW_OBJ_H__
#define __WINDOW_OBJ_H__

#include <Evas.h>

typedef struct
{
	Evas_Object *win;
	Evas_Object *bg;
	Evas_Object *conform;
	Evas_Object *layout;
} window_obj;

/**
 * @brief Create application main window
 * @return window on success, otherwise NULL
 */
window_obj *win_create();

/**
 * @brief Lower application window to hide application without exiting
 * @param[in]	win		application window
 */
void win_lower(window_obj *win);

/**
 * @brief Destroy application main window
 * @param[in]	win		application window
 */
void win_destroy(window_obj *win);

/**
 * @brief Set content to be displayed in window
 * @param[in]	win		application window
 * @param[in]	content window content
 */
void win_set_layout(window_obj *win, Evas_Object *layout);

/**
 * @brief Get window layout to use as a parent for window content
 * @param[in]	win		application window
 * @return window layout
 */
Evas_Object *win_get_host_layout(const window_obj *win);

#endif // __WINDOW_OBJ_H__
