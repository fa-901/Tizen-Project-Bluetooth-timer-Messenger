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

#include "main.h"
#include "user_callbacks.h"

Evas_Object *GLOBAL_DEBUG_BOX;

extern bt_gatt_client_h client;
extern int my_socket_fd;
extern int server_socket_fd;
extern bt_advertiser_h advertiser;

void _add_entry_text(const char *text)
{
    Evas_Coord c_y;

    elm_entry_entry_append(GLOBAL_DEBUG_BOX, text);
    elm_entry_entry_append(GLOBAL_DEBUG_BOX, "<br>");
    elm_entry_cursor_end_set(GLOBAL_DEBUG_BOX);
    elm_entry_cursor_geometry_get(GLOBAL_DEBUG_BOX, NULL, &c_y, NULL, NULL);
    elm_scroller_region_show(GLOBAL_DEBUG_BOX, 0, c_y, 0, 0);
}

static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
    elm_exit();
}

void _new_button(appdata_s *ad, Evas_Object *display, char *name, void *cb)
{
    // Create a button
    Evas_Object *bt = elm_button_add(display);
    elm_object_text_set(bt, name);
    evas_object_smart_callback_add(bt, "clicked", (Evas_Smart_Cb) cb, ad);
    evas_object_size_hint_weight_set(bt, EVAS_HINT_EXPAND, 0.0);
    evas_object_size_hint_align_set(bt, EVAS_HINT_FILL, EVAS_HINT_FILL);
    elm_box_pack_end(display, bt);
    evas_object_show(bt);
}

static void _btn_clear_cb(void *data, Evas_Object *btn, void *ev)
{
    elm_entry_entry_set(GLOBAL_DEBUG_BOX, "");
}

Evas_Object *_create_new_cd_display(appdata_s *ad, char *name, void *cb)
{
    // Create a scroller
    Evas_Object *scroller = elm_scroller_add(ad->win);
    evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

    // Create a new item
    Elm_Object_Item *item = elm_naviframe_item_push(ad->navi, "Network", NULL, NULL, scroller, NULL);
    elm_object_item_part_text_set(item, "subtitle", name);

    if (cb != NULL)
        elm_naviframe_item_pop_cb_set(item, (Elm_Naviframe_Item_Pop_Cb) cb, (void *)ad);

    // Create main box
    Evas_Object *box = elm_box_add(scroller);
    elm_object_content_set(scroller, box);
    elm_box_horizontal_set(box, EINA_FALSE);
    evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    evas_object_show(box);

    // Create a box for adding content
    Evas_Object *bbox = elm_box_add(box);
    Evas_Coord padding_between_buttons = 3;
    elm_box_padding_set(bbox, 0, padding_between_buttons);
    elm_box_horizontal_set(bbox, EINA_FALSE);
    evas_object_size_hint_align_set(bbox, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_size_hint_weight_set(bbox, EVAS_HINT_EXPAND, 0.0);
    evas_object_show(bbox);

    // Create "Clear" button
    Evas_Object *bt = elm_button_add(box);
    elm_object_text_set(bt, "Clear");
    evas_object_size_hint_align_set(bt, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_size_hint_weight_set(bt, EVAS_HINT_EXPAND, 0.0);
    evas_object_smart_callback_add(bt, "clicked", _btn_clear_cb, NULL);
    evas_object_show(bt);

    // Create a box for entry
    Evas_Object *ebox = elm_box_add(box);
    elm_box_horizontal_set(ebox, EINA_FALSE);
    evas_object_size_hint_align_set(ebox, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_size_hint_weight_set(ebox, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    evas_object_show(ebox);

    // Create a message box
    Evas_Object *display_window = elm_entry_add(ebox);
    evas_object_size_hint_align_set(display_window, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_size_hint_weight_set(display_window, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    evas_object_show(display_window);

    elm_entry_editable_set(display_window, EINA_FALSE);
    elm_entry_scrollable_set(display_window, EINA_TRUE);

    GLOBAL_DEBUG_BOX = display_window;
    elm_scroller_policy_set(GLOBAL_DEBUG_BOX, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_ON);
    elm_box_pack_end(ebox, display_window);

    elm_box_pack_end(box, bbox);
    elm_box_pack_end(box, ebox);
    elm_box_pack_end(box, bt);

    return bbox;
}

static void create_base_gui(appdata_s *ad)
{
    // Setting the window
    ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
    elm_win_conformant_set(ad->win, EINA_TRUE);
    elm_win_autodel_set(ad->win, EINA_TRUE);
    elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
    elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
    evas_object_smart_callback_add(ad->win, "delete, request", win_delete_request_cb, NULL);

    /* Create conformant */
    Evas_Object *conform = elm_conformant_add(ad->win);

    evas_object_size_hint_weight_set(conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_win_resize_object_add(ad->win, conform);
    evas_object_show(conform);

    // Create a naviframe
    ad->navi = elm_naviframe_add(conform);
    evas_object_size_hint_align_set(ad->navi, EVAS_HINT_FILL, EVAS_HINT_FILL);
    evas_object_size_hint_weight_set(ad->navi, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

    elm_object_content_set(conform, ad->navi);
    evas_object_show(ad->navi);

    // Fill the list with items
    create_buttons_in_main_window(ad);

    eext_object_event_callback_add(ad->navi, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);

    // Show the window after base gui is set up
    evas_object_show(ad->win);
}

static bool storage_info_cb(int storage_id, storage_type_e type, storage_state_e state,
                            const char *path, void *user_data)
{
    int *id = (int *) user_data;
    if (type == STORAGE_TYPE_INTERNAL) {
        *id = storage_id;
        return false;
    }
    return true;
}

static int get_internal_storage_id(int *id)
{
    int found_id;
    int error = storage_foreach_device_supported(storage_info_cb, &found_id);
    if (error != STORAGE_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "storage_foreach_device_supported() failed: %d", error);
        return error;
    }
    *id = found_id;
    return STORAGE_ERROR_NONE;
}

static bool app_create(void *data)
{
    /*
     * Hook to take necessary actions before main event loop starts
     * Initialize UI resources and application's data
     * If this function returns true, the main loop of application starts
     * If this function returns false, the application is terminated
     */
    create_base_gui(data);
    appdata_s *ad = (appdata_s *)data;
    ad->internal_storage_id = -1;
    int error = get_internal_storage_id(&ad->internal_storage_id);
    if (error != STORAGE_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "Could not get internal storage ID");
        return false;
    }
    return true;
}

static void app_terminate(void *data)
{
    /* Release resources */
    bt_adapter_unset_state_changed_cb();
    bt_adapter_unset_device_discovery_state_changed_cb();
    bt_device_unset_service_searched_cb();
    bt_socket_unset_data_received_cb();
    bt_socket_unset_connection_state_changed_cb();
    bt_opp_client_deinitialize();
    bt_opp_server_deinitialize();

    /* Disconnecting from the connected device using SPP */
    bt_socket_destroy_rfcomm(my_socket_fd);

    bt_socket_disconnect_rfcomm(server_socket_fd);

    /* Unregister the callback registered for connection state changes */
    bt_gatt_unset_connection_state_changed_cb();

    /* Destroy the client created to connect to the remote service device */
    bt_gatt_client_destroy(client);

    /* Destroy the LE advertiser */
    int ret = bt_adapter_le_destroy_advertiser(advertiser);
    if (ret != BT_ERROR_NONE)
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_adapter_le_destroy_advertiser] Failed.");

    /* Deinitialize Bluetooth */
    ret = bt_deinitialize();
    if (ret != BT_ERROR_NONE)
        dlog_print(DLOG_ERROR, LOG_TAG, "[bt_deinitialize] Failed.");
}

int main(int argc, char *argv[])
{
    appdata_s ad;
    memset(&ad, 0x00, sizeof(appdata_s));

    ui_app_lifecycle_callback_s event_callback;
    memset(&event_callback, 0x00, sizeof(ui_app_lifecycle_callback_s));

    event_callback.create = app_create;
    event_callback.terminate = app_terminate;

    int ret = ui_app_main(argc, argv, &event_callback, &ad);
    if (ret != APP_ERROR_NONE)
        dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() failed with error: %d", ret);

    return ret;
}
