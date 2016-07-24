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

#include <app.h>
#include <stdlib.h>
#include <Elementary.h>

#include "main-app.h"
#include "utils/ui-utils.h"
#include "view/main-view.h"
#include "utils/logger.h"


/* app event callbacks */
static bool _on_create_cb(void *user_data);
static void _on_terminate_cb(void *user_data);
static void _on_pause_cb(void *user_data);
static void _on_resume_cb(void *user_data);
static void _on_app_control_cb(app_control_h app_control, void *user_data);

static Evas_Object *_add_naviframe(app_data *app);

app_data *app_create()
{
	app_data *app = calloc(1, sizeof(app_data));
	return app;
}

void app_destroy(app_data *app)
{
	if (app) {
		free(app);
	}
}

int app_run(app_data *app, int argc, char **argv)
{
	if (!app) {
		return -1;
	}

	ui_app_lifecycle_callback_s cbs = {
		.create = _on_create_cb,
		.terminate = _on_terminate_cb,
		.pause = _on_pause_cb,
		.resume = _on_resume_cb,
		.app_control = _on_app_control_cb,
	};

	return ui_app_main(argc, argv, &cbs, app);
}

static Evas_Object *_add_naviframe(app_data *app)
{
	Evas_Object *result = NULL;
	Evas_Object *parent = win_get_host_layout(app->win);
	if (parent) {
		result = ui_utils_navi_add(parent, app);
		if (result) {
			win_set_layout(app->win, result);
		}
	}
	return result;
}

static bool _on_create_cb(void *user_data)
{
	app_data *ad = user_data;
	elm_app_base_scale_set(2.6);

	if (!ad) {
		return false;
	}

	ad->win = win_create();
	if (!ad->win) {
		return false;
	}
	ad->navi = _add_naviframe(ad);


	if (!ad->navi) {
		return false;
	}

	main_view_add(ad, ad->navi);
	return true;
}

static void _on_terminate_cb(void *user_data)
{
	app_data *app = user_data;

	if (!app) {
		return;
	}

	free(app->main_view_data);
	app->main_view_data = NULL;

	win_destroy(app->win);
	app->win = NULL;
}

static void _on_pause_cb(void *user_data)
{
}

static void _on_resume_cb(void *user_data)
{
}

static void _on_app_control_cb(app_control_h app_control, void *user_data)
{
}
