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

#ifndef __UI_UTILS_H__
#define __UI_UTILS_H__

#include <Evas.h>
#include <Elementary.h>
/**
 * @brief Create empty genlist
 * @param[in]	parent	The layout object
 * @return genlist object
 */
Evas_Object *ui_utils_create_genlist(Evas_Object *parent);

/**
 * @brief Add naviframe widget
 * @param[in]	parent		parent widget
 * @param[in]	cb_data		data to pass to back_cb
 * @return Naviframe on success, otherwise NULL
 */
Evas_Object *ui_utils_navi_add(Evas_Object *parent, void *cb_data);

/**
 * @brief Add layout widget
 * @param[in]	parent			parent widget
 * @param[in]	destroy_cb		layout destroy callback
 * @param[in]	cb_data			data to pass to destroy_cb
 * @return Layout on success, otherwise NULL
 */
Evas_Object *ui_utils_layout_add(Evas_Object *parent, Evas_Object_Event_Cb destroy_cb, void *cb_data);

/**
 * @brief Add genlist to naviframe
 *
 * @param[in]	navi		naviframe used in this function
 * @param[in]	navi_item	naviframe item used in this function
 * @return Toolbar on success, otherwise NULL
 */
Evas_Object *ui_utils_toolbar_add(Evas_Object *navi, Elm_Object_Item *navi_item);

#endif /* __UI_UTILS_H__ */
