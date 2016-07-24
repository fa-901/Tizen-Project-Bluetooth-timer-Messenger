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

#include "view/window.h"

#define APP_NAME "scheduler_new"

window_obj *win_create()
{
	window_obj *obj = calloc(1, sizeof(window_obj));
	if (!obj) {
		return NULL;
	}

	obj->win = elm_win_util_standard_add(APP_NAME, APP_NAME);
	elm_win_autodel_set(obj->win, EINA_TRUE);
	elm_win_conformant_set(obj->win, EINA_TRUE);
	evas_object_size_hint_weight_set(obj->win, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_indicator_mode_set(obj->win, ELM_WIN_INDICATOR_SHOW);
	evas_object_show(obj->win);

	obj->conform = elm_conformant_add(obj->win);
	evas_object_size_hint_weight_set(obj->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(obj->win, obj->conform);
	evas_object_show(obj->conform);

	obj->bg = elm_bg_add(obj->conform);
	evas_object_size_hint_weight_set(obj->bg, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(obj->bg);

	elm_object_part_content_set(obj->conform, "elm.swallow.bg", obj->bg);

	return obj;
}

void win_destroy(window_obj *obj)
{
	if (obj) {
		evas_object_del(obj->win);
		free(obj);
	}
}

void win_lower(window_obj *obj)
{
	if (obj) {
		elm_win_lower(obj->win);
	}
}

void win_set_layout(window_obj *obj, Evas_Object *layout)
{
	if (!obj || !layout) {
		return;
	}
	elm_object_part_content_set(obj->conform, "elm.swallow.content", layout);
	obj->layout = layout;
}

Evas_Object *win_get_host_layout(const window_obj *win)
{
	if (!win) {
		return NULL;
	}
	return win->conform;
}
