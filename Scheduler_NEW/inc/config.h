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

#ifndef __CONFIG_H__
#define __CONFIG_H__

#include <app.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>

static const char *TITLE                = "Title";
static const char *TITLE_HINT           = "Enter the title";
static const char *FROM                 = "From";
static const char *TO                   = "To";
static const char *TIME_ZONE            = "Time zone";
static const char *ALL_DAY              = "All day";
static const char *LOCATION             = "Location";
static const char *LOCATION_HINT        = "Enter the location";
static const char *DESCRIPTION          = "Description";
static const char *DESCRIPTION_HINT     = "Enter the description";
static const char *REMINDER             = "Reminder";
static const char *RECURRENCE           = "Recurrence";
static const char *PRIORITY             = "Priority";
static const char *SENSITIVITY          = "Sensitivity";
static const char *STATUS               = "Status";
static const char *NONE                 = "None";
static const char *ERROR                = "ERROR";
static const char *SAVE                 = "Save";
static const char *CANCEL               = "Cancel";
static const char *SET                  = "Set";
static const char *EDIT                 = "Edit";
static const char *DELETE               = "Delete";
static const char *OK                   = "OK";
static const char *DELETION_CONFIRM     = "Are you sure you want to delete?";
static const char *YES                  = "Yes";
static const char *NO                   = "No";
static const char *CREATE               = "Create";
static const char *EVENTS               = "Events";
static const char *ALL_DAY_EVENTS       = "All Day Events";
static const char *NEXT                 = "Next";
static const char *PREVIOUS             = "Previous";
static const char *NO_TITLE             = "No title";
static const char *LOW                  = "Low";
static const char *NORMAL               = "Normal";
static const char *HIGH                 = "High";
static const char *PUBLIC               = "Public";
static const char *PRIVATE              = "Private";
static const char *CONFIDENTIAL         = "Confidential";
static const char *REPEAT               = "Repeat";
static const char *REPEAT_UNTIL         = "Repeat until";

#define TEXT_ITEM_DEFAULT_SIZE          40
#define TEXT_MAX_GOOD_SIZE              60
#define FORMAT_BUFFER                   128
#define LABEL_FORMAT                    "<p font_size=%d>%s</p>"
#define ENTRY_LABEL_FORMAT              "<p color=#000 font_size=%d>%s</p>"
#define STYLE_FORMAT                    "DEFAULT='font_size=%d'"

#define KEY_PRIORITY_DATA               "KEY_PRIORITY_DATA"
#define WARNING_TITLE_POPUP_TEXT        "<align=center>Please enter title</align>"
#define WARNING_TIME_POPUP_TEXT         "<align=center>Invalid period selected</align>"
#define WARNING_REPEAT_UNTIL_POPUP_TEXT "<align=center>Please select repeat until range</align>"

#define MAX_REMINDERS_COUNT             5
#define DATE_TIME_BUF_LEN               64
#define DAYS_IN_WEEK                    7
#define SUBJECT_CHAR_LIMIT              100
#define SUBJECT_BYTE_LIMIT              256

#define BUTTON_WIDTH                    320
#define BUTTON_DATE_WIDTH               240
#define BUTTON_TIME_WIDTH               160
#define BUTTON_HEIGHT                   80
#define BOX_PADDING                     10
#define ENTRY_SPACER_WIDTH              32
#define ENTRY_MIN_HEIGHT                140

#define ELM_BOX_PADDING ELM_SCALE_SIZE(BOX_PADDING)
#define ELM_BUTTON_WIDTH ELM_SCALE_SIZE(BUTTON_WIDTH)
#define ELM_BUTTON_HEIGHT ELM_SCALE_SIZE(BUTTON_HEIGHT)
#define ELM_ENTRY_MIN_HEIGHT ELM_SCALE_SIZE(ENTRY_MIN_HEIGHT)
#define ELM_ENTRY_SPACER_WIDTH ELM_SCALE_SIZE(ENTRY_SPACER_WIDTH)
#define ELM_BUTTON_DATE_WIDTH ELM_SCALE_SIZE(BUTTON_DATE_WIDTH)
#define ELM_BUTTON_TIME_WIDTH ELM_SCALE_SIZE(BUTTON_TIME_WIDTH)

/* See tm structure documentation. */
#define TM_START_YEAR                   1900
#define TM_START_MONTH                  1
#define MONTHS                          12
#define SECONDS_IN_DAY                  (24*60*60)
#define SECONDS_IN_WEEK                 (7*24*60*60)

/* Chars in a path name including null. */
#define PATH_MAX                        4096
#define EDJ_NAME                        "edje/scheduler.edj"

static inline const char *GET_PATH(const char *file_path) {
    static char layout_edj_path[PATH_MAX] = {'\0'};

    char *res_path_buff = app_get_resource_path();
    snprintf(layout_edj_path, PATH_MAX, "%s%s", res_path_buff, file_path);
    free(res_path_buff);

    return layout_edj_path;
}

enum _ENTRY_TYPE {
    TITLE_ENTRY,
    LOCATION_ENTRY,
    DESCRIPTION_ENTRY
};
typedef enum _ENTRY_TYPE ENTRY_TYPE;

enum _EVENT_PARAM_TYPE {
    PARAM_REMINDER = 0,
    PARAM_PRIORITY = 1,
    PARAM_SENSITIVITY = 2,
    PARAM_STATUS = 3
};
typedef enum _EVENT_PARAM_TYPE EVENT_PARAM_TYPE;

enum _VIEW_TYPE {
    DAILY = 0,
    MONTHLY
};
typedef enum _VIEW_TYPE VIEW_TYPE;

enum _REPEAT_LABEL_TYPE {
    REPEAT_LABEL = 0,
    REPEAT_UNTIL_LABEL = 1
};
typedef enum _REPEAT_LABEL_TYPE REPEAT_LABEL_TYPE;

#endif /* __CONFIG_H__ */
