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

#include "utils/ui-utils.h"
#include "utils/logger.h"


Evas_Object *ui_utils_create_genlist(Evas_Object *parent)
{
	Evas_Object *gen_list = elm_genlist_add(parent);
	elm_genlist_mode_set(gen_list, ELM_LIST_COMPRESS);
	RETVM_IF(!gen_list, NULL, "Cannot add genlist");

	return gen_list;
}

Evas_Object *ui_utils_navi_add(Evas_Object *parent, void *cb_data)
{
	RETVM_IF(!parent, NULL, "Wrong input data");

	Evas_Object *navi = elm_naviframe_add(parent);
	RETVM_IF(!navi, NULL, "Cannot add naviframe");

	elm_naviframe_prev_btn_auto_pushed_set(navi, EINA_FALSE);

	elm_object_part_content_set(parent, "elm.swallow.content", navi);
	evas_object_show(navi);

	return navi;
}

Evas_Object *ui_utils_layout_add(Evas_Object *parent, Evas_Object_Event_Cb destroy_cb, void *cb_data)
{
	Evas_Object *layout = elm_layout_add(parent);
	RETVM_IF(!layout, NULL, "Cannot add layout");

	elm_layout_theme_set(layout, "layout", "application", "default");
	evas_object_event_callback_add(layout, EVAS_CALLBACK_FREE, destroy_cb, cb_data);

	return layout;
}

Evas_Object *ui_utils_toolbar_add(Evas_Object *navi, Elm_Object_Item *navi_item)
{
	RETVM_IF(!navi || !navi_item, NULL, "Passed NULL input data");
	Evas_Object *toolbar = elm_toolbar_add(navi);
	RETVM_IF(!toolbar, NULL, "Cannot add toolbar");
	elm_toolbar_shrink_mode_set(toolbar, ELM_TOOLBAR_SHRINK_EXPAND);
	elm_toolbar_transverse_expanded_set(toolbar, EINA_TRUE);
	elm_object_item_part_content_set(navi_item, "toolbar", toolbar);

	return toolbar;
}
