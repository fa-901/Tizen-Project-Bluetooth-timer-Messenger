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
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#ifndef __MAIN_H__
#define __MAIN_H__

#include <Elementary.h>
#include <app.h>
#include <dlog.h>
#include <efl_extension.h>
#include <storage.h>
#include <bluetooth.h>

#define _PRINT_MSG_LOG_BUFFER_SIZE_ 1024
#define PRINT_MSG(fmt, args...) do { char _log_[_PRINT_MSG_LOG_BUFFER_SIZE_]; \
    snprintf(_log_, _PRINT_MSG_LOG_BUFFER_SIZE_, fmt, ##args); _add_entry_text(_log_); } while (0)

/*typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *naviframe;
	Evas_Object *box;
	Evas_Object *label;
	Evas_Object *datebox;
	Evas_Object *timebox;
	Evas_Object *buttonbluetooth;
	//Evas_Object *anotherwin;
} appdata_s;*/

typedef struct {
    Evas_Object *win;
    Evas_Object *navi;
    Evas_Object *conform;
    Evas_Object *naviframe;
    Evas_Object *box;
    Evas_Object *label;
    Evas_Object *datebox;
    Evas_Object *timebox;
    Evas_Object *buttonbluetooth;
    int internal_storage_id;
} appdata_s;

void _add_entry_text(const char *text);
void _new_button(appdata_s *ad, Evas_Object *display, char *name, void *cb);
Evas_Object *_create_new_cd_display(appdata_s *ad, char *name, void *cb);

#ifndef PACKAGE
#define PACKAGE "org.example.bluetooth"
#endif

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "bluetooth"

#endif                           /* __MAIN_H__ */
