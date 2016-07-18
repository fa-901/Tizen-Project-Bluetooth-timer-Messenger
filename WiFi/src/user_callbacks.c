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

#include "user_callbacks.h"
#include "main.h"

Evas_Object *ap_name_entry = NULL;
Evas_Object *password_entry = NULL;

/* Called after wifi_activate() is completed */
static void _wifi_activated_cb(wifi_error_e result, void *user_data)
{
    if (result == WIFI_ERROR_NONE) {
        PRINT_MSG("Succeeded to activate Wi-Fi device");
        dlog_print(DLOG_DEBUG, LOG_TAG, "[_wifi_activated_cb] Succeeded to activate Wi-Fi device");
    }
}

const char *str_disconected = "Disconnected";
const char *str_association = "Association";
const char *str_connected = "Connected";
const char *str_configuration = "Configuration";
const char *str_failure = "Connection failure";
const char *str_default = "Invalid case";

/* WiFi tutorial data */
static const char *print_state(wifi_connection_state_e state)
{
    switch (state) {
    case WIFI_CONNECTION_STATE_DISCONNECTED:
        return str_disconected;

    case WIFI_CONNECTION_STATE_ASSOCIATION:
        return str_association;

    case WIFI_CONNECTION_STATE_CONNECTED:
        return str_connected;

    case WIFI_CONNECTION_STATE_CONFIGURATION:
        return str_configuration;

    case WIFI_CONNECTION_STATE_FAILURE:
        return str_failure;

    default:
        return str_default;
    }
}

/* Provide a notification about the result of the connection */
static void __connected_cb(wifi_error_e result, void *user_data)
{
    if (result == WIFI_ERROR_NONE) {
        PRINT_MSG("Wi-Fi Connection Succeeded");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Wi-Fi Connection Succeeded");
    } else {
        PRINT_MSG("Wi-Fi Connection Failed");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Wi-Fi Connection Failed");
    }
}

/* Get some WI-FI conection information, and connect with entered access point */
static bool __wifi_found_ap_cb(wifi_ap_h ap, void *user_data)
{
    int error_code = 0;
    char *ap_name = NULL;
    wifi_connection_state_e state;

    /* Get ESSID (Extended Service Set Identifier) */
    error_code = wifi_ap_get_essid(ap, &ap_name);
    if (error_code != WIFI_ERROR_NONE) {
        PRINT_MSG("[__wifi_found_ap_cb] Failed to get AP name.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to get AP name.");
        return false;
    }

    /* Gets the connection state */
    error_code = wifi_ap_get_connection_state(ap, &state);
    if (error_code != WIFI_ERROR_NONE) {
        PRINT_MSG("[__wifi_found_ap_cb] Failed to get state.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to get state.");
        return false;
    }

    PRINT_MSG(" - %s, state : %s", ap_name, print_state(state));
    dlog_print(DLOG_DEBUG, LOG_TAG, "AP name : %s, state : %s", ap_name, print_state(state));

    /* Check whether this access point is the entered one */
    const char *ap_name_part = (const char *)user_data;
    if (state != WIFI_CONNECTION_STATE_CONNECTED && strstr(ap_name, ap_name_part) != NULL && strcmp(ap_name_part, "") != 0) {
        PRINT_MSG("");
        PRINT_MSG("Found entered Wi-Fi. Connecting...");

        bool required = false;

        /* Check whether the AP requires a passphrase */
        if (wifi_ap_is_passphrase_required(ap, &required) == WIFI_ERROR_NONE) {
            PRINT_MSG("   Passphrase required: %s",
                    required ? "True" : "False");
            dlog_print(DLOG_DEBUG, LOG_TAG, "[__found_connect_ap_cb] Passphrase required: %s",
                    required ? "True" : "False");
        } else {
            PRINT_MSG("   Failed to get Passphrase required");
            dlog_print(DLOG_DEBUG, LOG_TAG,
                    "[__found_connect_ap_cb] Failed to get Passphrase required");
        }

        if (required) {
            PRINT_MSG("   Password required for %s network", ap_name);
            dlog_print(DLOG_DEBUG, LOG_TAG,
                    "[__found_connect_ap_cb] Password required for %s network", ap_name);

            const char *passphrase = elm_object_part_text_get(password_entry, NULL);

            if (!strcmp(passphrase, "")) {
                PRINT_MSG("   Please enter passphrase first");
                return true;
            }

            /* Set the passphrase */
            error_code = wifi_ap_set_passphrase(ap, passphrase);
            if (error_code != WIFI_ERROR_NONE) {
                PRINT_MSG("   Failed to set passphrase");
                dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to set passphrase");
            }
        }

        /* Connect to a specific access point */
        error_code = wifi_connect(ap, __connected_cb, NULL);
        if (error_code != WIFI_ERROR_NONE) {
            PRINT_MSG("   Failed to request connection");
            dlog_print(DLOG_DEBUG, LOG_TAG,
                    "[__found_connect_ap_cb] Failed to request connection");
        } else {
            PRINT_MSG("   Succeeded to request connection. Wait for callback.");
            dlog_print(DLOG_DEBUG, LOG_TAG,
                    "[__found_connect_ap_cb] Succeeded to request connection");
        }
        PRINT_MSG("");
    }

    return true;
}


/* Connecting as a server */
/*
void _bluetooth_services_init()
{
     To establish a connection, create a RFCOMM Bluetooth socket
    int ret = bt_socket_create_rfcomm(my_uuid, &my_socket_fd);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("bt_socket_create_rfcomm() failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "bt_socket_create_rfcomm() failed.");
        return;
    }

     Get notified about which device connects to your device
    ret = bt_socket_set_connection_state_changed_cb(socket_connection_state_changed, NULL);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_socket_set_connection_state_changed_cb] failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_set_connection_state_changed_cb] failed.");
        return;
    }

     Listen for an incoming connection
    ret = bt_socket_listen_and_accept_rfcomm(my_socket_fd, 5);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_socket_listen_and_accept_rfcomm] failed. %d", ret);
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_listen_and_accept_rfcomm] failed.");
        return;
    }

     Read data from other devices
    ret = bt_socket_set_data_received_cb(_bt_socket_data_received_cb, NULL);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_socket_set_data_received_cb] failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_set_data_received_cb] failed.");
        return;
    }

     Register a callback for connection state changes
    ret = bt_gatt_set_connection_state_changed_cb(__bt_gatt_connection_state_changed_cb, NULL);
    if (ret != BT_ERROR_NONE) {
        PRINT_MSG("[bt_gatt_set_connection_state_changed_cb] failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_gatt_set_connection_state_changed_cb] failed.");
        return;
    }
}
*/

/* Show the result of the scan */
static void __scan_request_cb(wifi_error_e error_code, void *user_data)
{
    /* Select an access point */
    PRINT_MSG("");
    PRINT_MSG("Access points names:");

    const char *ap_name = elm_object_text_get(ap_name_entry);

    error_code = wifi_foreach_found_aps(__wifi_found_ap_cb, (void *)ap_name);
    if (error_code != WIFI_ERROR_NONE) {
        PRINT_MSG("[__scan_request_cb] Failed to get AP list");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to scan");
    }
}

void _wifi_scenario(appdata_s *ad, Evas_Object *obj, void *event_info)
{
    int error_code;
    bool wifi_activated = false;

    /* Check Wi-Fi connection */
    error_code = wifi_is_activated(&wifi_activated);
    if (error_code != WIFI_ERROR_NONE) {
        PRINT_MSG("[wifi_is_activated] failed");
        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_is_activated] failed");
    }

    if (wifi_activated) {
        PRINT_MSG("Wi-Fi is activated.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to get Wi-Fi device state.");
    } else {
        PRINT_MSG("Wi-Fi is not activated.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to get Wi-Fi device state.");

        /* Activate Wi-Fi */
        PRINT_MSG("Activating Wi-Fi");
        error_code = wifi_activate(_wifi_activated_cb, NULL);
        if (error_code != WIFI_ERROR_NONE) {
            PRINT_MSG("Activation failed %d", error_code);
            dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_activate] failed %d", error_code);
        }

        PRINT_MSG("Wi-Fi connection is established");
        return;
    }

    /*PRINT_MSG("");
    PRINT_MSG("Scanning for access points");
    PRINT_MSG("");

    const char *ap_name = elm_object_text_get((void *)ap_name_entry);
    PRINT_MSG("Access point to connect: %s", ap_name);
    error_code = wifi_scan(__scan_request_cb, NULL);
    if (error_code != WIFI_ERROR_NONE) {
        PRINT_MSG("[wifi_scan] failed");
        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_scan] failed");
        return;
    }*/
}


int _bluetooth_scenario(appdata_s *ad, Evas_Object *obj, void *event_info)
{
   PRINT_MSG("Bluetooth activated!");
   int ret = 0;
   app_control_h service = NULL;
   app_control_create(&service);

   if (service == NULL) {
	   dlog_print(DLOG_DEBUG, LOG_TAG, "service_create failed!\n");
	   return 0;
   }

   app_control_set_operation(service, "http://tizen.org/appcontrol/operation/edit");
   app_control_set_mime(service, "application/x-bluetooth-visibility");
   ret = app_control_send_launch_request(service, NULL, NULL);

   app_control_destroy(service);
   if (ret == APP_CONTROL_ERROR_NONE) {
	   dlog_print(DLOG_DEBUG, LOG_TAG, "Succeeded to Bluetooth On/Off app!\n");
	   return 0;
   } else {
	   dlog_print(DLOG_DEBUG, LOG_TAG, "Failed to relaunch Bluetooth On/Off app!\n");
	   return -1;
   }
}

void create_buttons_in_main_window(appdata_s *ad)
{
    wifi_deactivate(NULL, NULL);
    Evas_Object *display = _create_new_cd_display(ad, "Wi-Fi", _pop_cb);
    int error_code;

    /* Initialize Wi-Fi */
    error_code = wifi_initialize();
    if (error_code == WIFI_ERROR_NOT_SUPPORTED) {
        PRINT_MSG("WiFi is not supported on this device");
        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_initialize] Failed.");
        return;
    } else if (error_code != WIFI_ERROR_NONE) {
        PRINT_MSG("[wifi_initialize] Failed.");
        dlog_print(DLOG_ERROR, LOG_TAG, "[wifi_initialize] Failed.");
        return;
    } else {
        PRINT_MSG("[wifi_initialize] Success.");
        dlog_print(DLOG_DEBUG, LOG_TAG, "[wifi_initialize] Success.");
    }

    /*Evas_Object *ap_name_title = elm_entry_add(display);
    elm_object_text_set(ap_name_title, "Enter WiFi SSID(or part of it):");
    elm_box_pack_end(display, ap_name_title);
    evas_object_size_hint_weight_set(ap_name_title, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(ap_name_title, EVAS_HINT_FILL, EVAS_HINT_FILL);
    elm_entry_editable_set(ap_name_title, FALSE);
    evas_object_show(ap_name_title);

    ap_name_entry = elm_entry_add(display);
    elm_object_part_text_set(ap_name_entry, "guide", "SSID");
    elm_box_pack_end(display, ap_name_entry);
    evas_object_size_hint_weight_set(ap_name_entry, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(ap_name_entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(ap_name_entry);

    Evas_Object *text = elm_entry_add(display);
    elm_object_text_set(text, "Enter password to WiFi in range:");
    elm_box_pack_end(display, text);
    evas_object_size_hint_weight_set(text, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(text, EVAS_HINT_FILL, EVAS_HINT_FILL);
    elm_entry_editable_set(text, FALSE);
    evas_object_show(text);

    password_entry = elm_entry_add(display);
    elm_object_part_text_set(password_entry, "guide", "WiFi Password");
    elm_box_pack_end(display, password_entry);
    evas_object_size_hint_weight_set(password_entry, EVAS_HINT_EXPAND, 0);
    evas_object_size_hint_align_set(password_entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_show(password_entry);
    elm_entry_password_set(password_entry, TRUE);*/

    _new_button(ad, display, "Activate Wifi", _wifi_scenario);
    _new_button(ad, display, "Activate Bluetooth", _bluetooth_scenario);
}
