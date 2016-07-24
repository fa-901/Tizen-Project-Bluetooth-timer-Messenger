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

#ifndef __MAIN_APP_H__
#define __MAIN_APP_H__

#include <Evas.h>
#include <stdio.h>
#include <app.h>
#include <Elementary.h>
#include <calendar.h>

#include "view/window.h"
#include "view/main-view.h"

typedef struct _app_data
{
	window_obj *win;
	Evas_Object *navi;
	void *main_view_data;
} app_data;

/**
 * @brief Create application instance
 * @return Application instance on success, otherwise NULL
 */
app_data *app_create();

/**
 * @brief Destroy application instance
 * @param[in]	app		application instance
 */
void app_destroy(app_data *app);

/**
 * @brief Run Tizen application
 * @param[in]	app		application instance
 * @param[in]	argc	argc paremeter received in main
 * @param[in]	argv	argv parameter received in main
 */
int app_run(app_data *app, int argc, char **argv);

#endif // __MAIN_APP_H__
