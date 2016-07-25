#include <tizen.h>
#include "newbasicui.h"
#define TIME_STRING_FORMAT_BUFFER_SIZE 10
/*typedef struct appdata {
 Evas_Object *win;
 Evas_Object *conform;
 Evas_Object *label;
 } appdata_s;*/
typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *naviframe;
	Evas_Object *box;
	Evas_Object *label;
	Evas_Object *datebox;
	Evas_Object *timebox;
	Evas_Object *buttonbluetooth;
	Evas_Object *buttonwifi;
	Evas_Object *anotherwin;
} appdata_s;
typedef struct _Eo_Opaque Ecore_Timer;

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	elm_exit();
}

static void close_button_clicked_cb(void *data, Evas_Object *obj,
		void *event_info) {
	elm_exit();
}


/* Called after wifi_activate() is completed */
void _wifi_activated_cb(wifi_error_e result, void *user_data) {
	appdata_s *ad = user_data;
	if (result == WIFI_ERROR_NONE) {
		elm_object_text_set(ad->label,
				"<align=center>Wi-Fi is active now.</align>");
	}
}


void _wifi_scenario(appdata_s *ad, Evas_Object *obj, void *event_info) {
	int error_code;
	bool wifi_activated = false;
	error_code = wifi_initialize();
	if (error_code != WIFI_ERROR_NONE)
		return;
	error_code = wifi_is_activated(&wifi_activated);
	if (error_code != WIFI_ERROR_NONE) {
		elm_object_text_set(ad->label,
				"<align=center>Wi-Fi status not found.</align>");
	}
	if (wifi_activated) {
		elm_object_text_set(ad->label,
				"<align=center>Wi-Fi is activated.</align>");
	} else {
		elm_object_text_set(ad->label,
				"<align=center>Activating Wi-Fi.</align>");
		error_code = wifi_activate(_wifi_activated_cb, ad);
		if (error_code != WIFI_ERROR_NONE) {
			elm_object_text_set(ad->label, "Activating Wi-Fi failed.");
		}
	}
}

int _bluetooth_scenario(appdata_s *ad, Evas_Object *obj, void *event_info) {
	//PRINT_MSG("Bluetooth activated!");
	int ret = 0;
	app_control_h service = NULL;
	app_control_create(&service);

	if (service == NULL) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "service_create failed!\n");
		return 0;
	}

	app_control_set_operation(service,
			"http://tizen.org/appcontrol/operation/edit");
	app_control_set_mime(service, "application/x-bluetooth-visibility");
	ret = app_control_send_launch_request(service, NULL, NULL);

	app_control_destroy(service);
	if (ret == APP_CONTROL_ERROR_NONE) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to Bluetooth On/Off app!\n");
		return 0;
	} else {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to relaunch Bluetooth On/Off app!\n");
		return -1;
	}
}

/*
 * Function returns current local time in string format: HH:MM:SS
 * Obtained char buffer must be released using free() function.
 */
static char* _get_current_time(void) {
	char *time_buff = (char *) calloc(TIME_STRING_FORMAT_BUFFER_SIZE,
			sizeof(char));
	time_t current_time;

	time(&current_time);
	strftime(time_buff, TIME_STRING_FORMAT_BUFFER_SIZE, "%H:%M:%S",
			localtime(&current_time));

	return time_buff;
}
void _activate_wifi(void *data) {
	int error_code;
	bool wifi_activated = false;
	appdata_s *ad = data;
	error_code = wifi_initialize();
	if (error_code != WIFI_ERROR_NONE)
		return;
	error_code = wifi_is_activated(&wifi_activated);
	if (error_code != WIFI_ERROR_NONE) {
		elm_object_text_set(ad->label,
				"<align=center>Wi-Fi status not found.</align>");
	}
	if (wifi_activated) {
		elm_object_text_set(ad->label,
				"<align=center>Wi-Fi is activated.</align>");
	} else {
		elm_object_text_set(ad->label,
				"<align=center>Activating Wi-Fi.</align>");
		error_code = wifi_activate(_wifi_activated_cb, ad);
		if (error_code != WIFI_ERROR_NONE) {
			elm_object_text_set(ad->label, "Activating Wi-Fi failed.");
		}
	}
}

int _activate_bluetooth(void *data) {
	//PRINT_MSG("Bluetooth activated!");
	int ret = 0;
	app_control_h service = NULL;
	app_control_create(&service);

	if (service == NULL) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "service_create failed!\n");
		return 0;
	}

	app_control_set_operation(service,
			"http://tizen.org/appcontrol/operation/edit");
	app_control_set_mime(service, "application/x-bluetooth-visibility");
	ret = app_control_send_launch_request(service, NULL, NULL);

	app_control_destroy(service);
	if (ret == APP_CONTROL_ERROR_NONE) {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to Bluetooth On/Off app!\n");
		return 0;
	} else {
		//dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to relaunch Bluetooth On/Off app!\n");
		return -1;
	}
}

static void ecore_timer_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	const char *input = elm_object_text_get(ad->timebox);
	const char *currenttime = _get_current_time();
	elm_object_text_set(ad->label, currenttime);
	if (strcmp(input, currenttime) == 0) {
		_activate_wifi(ad);
		_activate_bluetooth(ad);
	}
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void create_base_gui(appdata_s *ad) {
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_conformant_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}
	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);
    evas_object_smart_callback_add(ad->win, "delete, request", win_delete_request_cb, NULL);

	ad->conform = elm_conformant_add(ad->win);

	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);

	elm_win_resize_object_add(ad->win, ad->conform);

	evas_object_show(ad->conform);

	ad->naviframe = elm_naviframe_add(ad->conform);
	elm_object_content_set(ad->conform, ad->naviframe);
	evas_object_show(ad->naviframe);

	ad->box = elm_box_add(ad->naviframe);
	elm_box_horizontal_set(ad->box, EINA_FALSE);
	evas_object_size_hint_weight_set(ad->box, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->box, EVAS_HINT_FILL,
	EVAS_HINT_FILL);
	elm_naviframe_item_push(ad->naviframe, "Wi-Fi, Bluetooth and Timer", NULL,
			NULL, ad->box, NULL);
	evas_object_show(ad->box);

	/*ad->datebox = elm_datetime_add(ad->box);
	 evas_object_size_hint_weight_set(ad->datebox, EVAS_HINT_EXPAND,
	 EVAS_HINT_EXPAND);
	 evas_object_size_hint_align_set(ad->datebox, EVAS_HINT_FILL,
	 EVAS_HINT_FILL);
	 elm_box_pack_end(ad->box, ad->datebox);
	 evas_object_show(ad->datebox);*/

	ad->timebox = elm_entry_add(ad->box);
	evas_object_size_hint_weight_set(ad->timebox, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->timebox, EVAS_HINT_FILL,
	EVAS_HINT_FILL);
	elm_box_pack_end(ad->box, ad->timebox);
	evas_object_show(ad->timebox);
	ad->label = elm_label_add(ad->box);
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->label, EVAS_HINT_FILL, EVAS_HINT_FILL);
	/*elm_object_text_set(ad->label,
	 "<align=center>Hello World!</align><br>"
	 "<br>"
	 "<wrap = word>Clicking on the button below closes the application.</wrap>");*/
	elm_box_pack_end(ad->box, ad->label);
	evas_object_show(ad->label);

	ad->buttonwifi = elm_button_add(ad->box);
	evas_object_size_hint_weight_set(ad->buttonwifi, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->buttonwifi, EVAS_HINT_FILL, 1);
	elm_object_text_set(ad->buttonwifi, "Activate Wifi");

	evas_object_smart_callback_add(ad->buttonwifi, "clicked", _wifi_scenario,
			ad);
	elm_box_pack_end(ad->box, ad->buttonwifi);
	evas_object_show(ad->buttonwifi);

	ad->buttonbluetooth = elm_button_add(ad->box);
	evas_object_size_hint_weight_set(ad->buttonbluetooth, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->buttonbluetooth, EVAS_HINT_FILL, 1);
	elm_object_text_set(ad->buttonbluetooth, "Activate Bluetooth");

	evas_object_smart_callback_add(ad->buttonbluetooth, "clicked",
			_bluetooth_scenario, ad);
	elm_box_pack_end(ad->box, ad->buttonbluetooth);
	evas_object_show(ad->buttonbluetooth);
	evas_object_show(ad->win);
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;
	create_base_gui(ad);
	Ecore_Timer *timer = ecore_timer_add(1, ecore_timer_cb, ad);
	return true;
}

static void app_control(app_control_h app_control, void *data) {
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
			&locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
