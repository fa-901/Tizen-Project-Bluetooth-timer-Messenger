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

#ifndef __DETAILS_VIEW_H__
#define __DETAILS_VIEW_H__

#include <app.h>
#include <Elementary.h>
#include "window.h"

/**
 * Add Details view
 *
 * @param[in]	win		Main window object
 * @param[in]	parent	Naviframe object
 * @param[in]	index	Record index
 * @return				ayout instance otherwise NULL
 *
 */
Evas_Object *details_view_add(window_obj *win, Evas_Object *naviframe, int index);

#endif /* __DETAILS_VIEW_H__ */
