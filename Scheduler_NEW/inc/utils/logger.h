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

#ifndef __DBG_H__
#define __DBG_H__

#include <dlog.h>

#ifdef LOG_TAG
#undef LOG_TAG
#endif
#define LOG_TAG "scheduler_new"

#define INF(fmt, arg...) dlog_print(DLOG_INFO, LOG_TAG, fmt, ##arg)
#define DBG(fmt, arg...) dlog_print(DLOG_DEBUG, LOG_TAG, fmt, ##arg)
#define WARN(fmt, arg...) dlog_print(DLOG_WARN, LOG_TAG, fmt, ##arg)
#define ERR(fmt, arg...) dlog_print(DLOG_ERROR, LOG_TAG, fmt, ##arg)
#define FATAL(fmt, arg...) dlog_print(DLOG_FATAL, LOG_TAG, fmt, ##arg)

#define RETM_IF(expr, fmt, arg...) \
{ \
	if (expr) { \
		ERR(fmt, ##arg); \
		return; \
	} \
}

#define RETVM_IF(expr, val, fmt, arg...) \
{ \
	if (expr) { \
		ERR(fmt, ##arg); \
		return (val); \
	} \
}

#define WARN_IF(expr, fmt, arg...)\
{ \
	if (expr) { \
		WARN("(%s) "fmt, #expr, ##arg); \
	} \
}

#endif /* __DBG_H__ */
