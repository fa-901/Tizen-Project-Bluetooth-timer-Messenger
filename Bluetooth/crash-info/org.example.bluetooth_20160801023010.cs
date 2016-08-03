S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: bluetooth
PID: 11456
Date: 2016-08-01 02:30:10+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/bluetooth
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 11456, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002cc0
r2   = 0x00000006, r3   = 0xb447c4c0
r4   = 0x00000002, r5   = 0xb447c000
r6   = 0xb678109c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb69c9300
ip   = 0x00000000, sp   = 0xbe9bff34
lr   = 0xb6677f18, pc   = 0xb6676b84
cpsr = 0x200d0010

Memory Information
MemTotal:   730440 KB
MemFree:     36748 KB
Buffers:     29660 KB
Cached:     264796 KB
VmPeak:     110180 KB
VmSize:     103232 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25428 KB
VmRSS:       25428 KB
VmData:      34836 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36092 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11456 TID = 11456
11456 11463 12374 

Maps Information
b1d1f000 b251e000 rw-p [stack:12374]
b251e000 b252f000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b253f000 b2544000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b25d0000 b25d8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25e9000 b25ea000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b25fa000 b260e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2622000 b2623000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2633000 b2636000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2647000 b2648000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2658000 b265a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b266a000 b266c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b267c000 b268c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b269c000 b26a8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28f8000 b2936000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2947000 b294e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b295f000 b2994000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29a7000 b29ad000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29bd000 b29ca000 r-xp /opt/usr/apps/org.example.bluetooth/bin/bluetooth
b2aeb000 b2bce000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c05000 b2c2d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c3f000 b343e000 rw-p [stack:11463]
b343e000 b3440000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3450000 b345a000 r-xp /lib/libnss_files-2.20-2014.11.so
b346b000 b3474000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3485000 b3496000 r-xp /lib/libnsl-2.20-2014.11.so
b34a9000 b34af000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34c0000 b34c1000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b34e9000 b34f0000 r-xp /usr/lib/libminizip.so.1.0.0
b3500000 b3505000 r-xp /usr/lib/libstorage.so.0.1
b3515000 b356a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3580000 b3594000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35a4000 b35e8000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b35f8000 b3600000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3610000 b3640000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3653000 b370c000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3720000 b3774000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3785000 b37a0000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37b0000 b3871000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3884000 b3896000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38a6000 b38aa000 r-xp /usr/lib/libogg.so.0.7.1
b38ba000 b38dc000 r-xp /usr/lib/libvorbis.so.0.4.3
b38ec000 b39d0000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b39ec000 b39f9000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a0a000 b3a4d000 r-xp /usr/lib/libsndfile.so.1.0.25
b3a62000 b3aa9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3aba000 b3ac0000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ad1000 b3ad8000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3ae8000 b3b28000 r-xp /usr/lib/libmdm.so.1.2.10
b3b38000 b3b40000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b4f000 b3b5f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3b80000 b3be0000 r-xp /usr/lib/libasound.so.2.0.0
b3bf2000 b3c28000 r-xp /usr/lib/libpulse.so.0.16.2
b3c39000 b3c3c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c4c000 b3c4f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3c5f000 b3c64000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3c74000 b3c75000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3c85000 b3c90000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3ca4000 b3cab000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cbb000 b3cc1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3cd1000 b3cd6000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3ce6000 b3d01000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d11000 b3d18000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d28000 b3d2b000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d3c000 b3d6a000 r-xp /usr/lib/libidn.so.11.5.44
b3d7a000 b3d90000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3da1000 b3dab000 r-xp /usr/lib/libcares.so.2.1.0
b3dbb000 b3dc5000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3dd5000 b3dd7000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3de7000 b3de8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3df8000 b3dfc000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e0d000 b3e35000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e46000 b3e6f000 r-xp /usr/lib/libturbojpeg.so
b3e8f000 b3e95000 r-xp /usr/lib/libgif.so.4.1.6
b3ea5000 b3eeb000 r-xp /usr/lib/libcurl.so.4.3.0
b3efc000 b3f1d000 r-xp /usr/lib/libexif.so.12.3.3
b3f38000 b3f4d000 r-xp /usr/lib/libtts.so
b3f5e000 b3f66000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f76000 b4036000 r-xp /usr/lib/libdali-core.so.0.0.0
b4041000 b4134000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4154000 b422e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4245000 b4247000 r-xp /usr/lib/libboost_system.so.1.51.0
b4257000 b425d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b426d000 b4290000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42a1000 b42a3000 r-xp /usr/lib/libappsvc.so.0.1.0
b42b3000 b42b5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42c6000 b42cb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42e2000 b42e4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b42f4000 b42fb000 r-xp /usr/lib/libsensord-share.so
b430b000 b4323000 r-xp /usr/lib/libsensor.so.1.1.0
b4334000 b4337000 r-xp /usr/lib/libXv.so.1.0.0
b4347000 b434c000 r-xp /usr/lib/libutilX.so.1.1.0
b435c000 b4361000 r-xp /usr/lib/libappcore-common.so.1.1
b4371000 b4378000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b438b000 b438f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43a0000 b446a000 r-xp /usr/lib/libCOREGL.so.4.0
b4481000 b4484000 r-xp /usr/lib/libuuid.so.1.3.0
b4495000 b44ac000 r-xp /usr/lib/libblkid.so.1.1.0
b44bd000 b44bf000 r-xp /usr/lib/libXau.so.6.0.0
b44cf000 b44d2000 r-xp /usr/lib/libEGL.so.1.4
b44da000 b44e0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b44f0000 b44f2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4503000 b4511000 r-xp /usr/lib/libGLESv2.so.2.0
b451a000 b457c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4591000 b45a9000 r-xp /usr/lib/libmount.so.1.1.0
b45ba000 b45ce000 r-xp /usr/lib/libxcb.so.1.1.0
b45df000 b45e6000 r-xp /lib/libcrypt-2.20-2014.11.so
b461e000 b462f000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4640000 b4642000 r-xp /usr/lib/libiri.so
b4652000 b465d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b466e000 b4683000 r-xp /lib/libexpat.so.1.5.2
b4695000 b4753000 r-xp /usr/lib/libcairo.so.2.11200.14
b4766000 b476e000 r-xp /usr/lib/libdrm.so.2.4.0
b477e000 b4781000 r-xp /usr/lib/libdri2.so.0.0.0
b4792000 b47e0000 r-xp /usr/lib/libssl.so.1.0.0
b47f5000 b4801000 r-xp /usr/lib/libeeze.so.1.13.0
b4811000 b481a000 r-xp /usr/lib/libethumb.so.1.13.0
b482a000 b482d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b483d000 b49f4000 r-xp /usr/lib/libcrypto.so.1.0.0
b564b000 b5654000 r-xp /usr/lib/libXi.so.6.1.0
b5664000 b5666000 r-xp /usr/lib/libXgesture.so.7.0.0
b5676000 b567a000 r-xp /usr/lib/libXtst.so.6.1.0
b568a000 b5690000 r-xp /usr/lib/libXrender.so.1.3.0
b56a0000 b56a6000 r-xp /usr/lib/libXrandr.so.2.2.0
b56b7000 b56b9000 r-xp /usr/lib/libXinerama.so.1.0.0
b56c9000 b56cc000 r-xp /usr/lib/libXfixes.so.3.1.0
b56dc000 b56e7000 r-xp /usr/lib/libXext.so.6.4.0
b56f7000 b56f9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5709000 b570b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b571c000 b57fe000 r-xp /usr/lib/libX11.so.6.3.0
b5811000 b5818000 r-xp /usr/lib/libXcursor.so.1.0.2
b5828000 b5840000 r-xp /usr/lib/libudev.so.1.6.0
b5842000 b5845000 r-xp /lib/libattr.so.1.1.0
b5855000 b5875000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5877000 b587c000 r-xp /usr/lib/libffi.so.6.0.2
b588c000 b58a4000 r-xp /lib/libz.so.1.2.8
b58b4000 b58b6000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58c6000 b599b000 r-xp /usr/lib/libxml2.so.2.9.2
b59b0000 b5a4b000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a67000 b5a6a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a7a000 b5a93000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aa4000 b5ab5000 r-xp /lib/libresolv-2.20-2014.11.so
b5ac9000 b5b43000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b58000 b5b5a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b6a000 b5b71000 r-xp /usr/lib/libembryo.so.1.13.0
b5b81000 b5b99000 r-xp /usr/lib/libpng12.so.0.50.0
b5baa000 b5bcd000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bee000 b5c02000 r-xp /usr/lib/libector.so.1.13.0
b5c13000 b5c2b000 r-xp /usr/lib/liblua-5.1.so
b5c3c000 b5c93000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ca7000 b5ccf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce0000 b5cf3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d04000 b5d3b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d4c000 b5d5a000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d6a000 b5d72000 r-xp /usr/lib/libtbm.so.1.0.0
b5d82000 b5d8f000 r-xp /usr/lib/libeio.so.1.13.0
b5d9f000 b5da1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5db1000 b5db6000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dc6000 b5ddd000 r-xp /usr/lib/libefreet.so.1.13.0
b5def000 b5e0f000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e1f000 b5e3f000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e41000 b5e47000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e57000 b5e68000 r-xp /usr/lib/libemotion.so.1.13.0
b5e79000 b5e80000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e90000 b5e9f000 r-xp /usr/lib/libeo.so.1.13.0
b5eb0000 b5ec2000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed3000 b5ed8000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ee8000 b5f01000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f11000 b5f2e000 r-xp /usr/lib/libeet.so.1.13.0
b5f47000 b5f8f000 r-xp /usr/lib/libeina.so.1.13.0
b5fa0000 b5fb0000 r-xp /usr/lib/libefl.so.1.13.0
b5fc1000 b60a6000 r-xp /usr/lib/libicuuc.so.51.1
b60c3000 b6203000 r-xp /usr/lib/libicui18n.so.51.1
b621a000 b6252000 r-xp /usr/lib/libecore_x.so.1.13.0
b6264000 b6267000 r-xp /lib/libcap.so.2.21
b6277000 b62a0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62b1000 b62b8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62ca000 b6301000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6312000 b63fd000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6410000 b6489000 r-xp /usr/lib/libsqlite3.so.0.8.6
b649b000 b64a0000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64b0000 b64ba000 r-xp /usr/lib/libvconf.so.0.2.45
b64ca000 b64cc000 r-xp /usr/lib/libvasum.so.0.3.1
b64dc000 b64de000 r-xp /usr/lib/libttrace.so.1.1
b64ee000 b64f1000 r-xp /usr/lib/libiniparser.so.0
b6501000 b6527000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6537000 b653c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b654d000 b6564000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6575000 b65e0000 r-xp /lib/libm-2.20-2014.11.so
b65f1000 b65f7000 r-xp /lib/librt-2.20-2014.11.so
b6608000 b6615000 r-xp /usr/lib/libunwind.so.8.0.1
b664b000 b676f000 r-xp /lib/libc-2.20-2014.11.so
b6784000 b679d000 r-xp /lib/libgcc_s-4.9.so.1
b67ad000 b688f000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68a0000 b68ca000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68db000 b6917000 r-xp /usr/lib/libsystemd.so.0.4.0
b6919000 b699b000 r-xp /usr/lib/libedje.so.1.13.0
b69ae000 b69cc000 r-xp /usr/lib/libecore.so.1.13.0
b69ec000 b6b73000 r-xp /usr/lib/libevas.so.1.13.0
b6ba8000 b6bbc000 r-xp /lib/libpthread-2.20-2014.11.so
b6bd0000 b6e05000 r-xp /usr/lib/libelementary.so.1.13.0
b6e33000 b6e37000 r-xp /usr/lib/libsmack.so.1.0.0
b6e47000 b6e4e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e5e000 b6e60000 r-xp /usr/lib/libdlog.so.0.0.0
b6e70000 b6e73000 r-xp /usr/lib/libbundle.so.0.1.22
b6e83000 b6e85000 r-xp /lib/libdl-2.20-2014.11.so
b6e96000 b6eae000 r-xp /usr/lib/libaul.so.0.1.0
b6ec2000 b6ec7000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed8000 b6ee5000 r-xp /usr/lib/liblptcp.so
b6ef7000 b6efb000 r-xp /usr/lib/libsys-assert.so
b6f0c000 b6f2c000 r-xp /lib/ld-2.20-2014.11.so
b6f3d000 b6f42000 r-xp /usr/bin/launchpad-loader
b88cd000 b8c20000 rw-p [heap]
be9a0000 be9c1000 rw-p [stack]
b88cd000 b8c20000 rw-p [heap]
be9a0000 be9c1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11456)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6676b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.bluetooth
Package ID : org.example.bluetooth
Version: 1.0.0
Package Type: tpk
App Name: bluetooth
App ID: org.example.bluetooth
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
08-01 02:02:26.120+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:26.140+0600 E/weather-agent(17240): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
08-01 02:02:26.140+0600 I/CAPI_APPFW_APPLICATION(17240): service_app_main.c: service_app_exit(446) > service_app_exit
08-01 02:02:26.140+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 02:02:26.140+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 02:02:26.140+0600 E/weather-agent(17240): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
08-01 02:02:26.180+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:26.240+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:26.290+0600 W/AUL_AMD (  630): amd_request.c: __send_app_termination_signal(613) > send dead signal done
08-01 02:02:26.290+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17240
08-01 02:02:26.290+0600 I/Tizen::App( 1185): (243) > App[com.samsung.weather-m-agent] pid[17240] terminate event is forwarded
08-01 02:02:26.290+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 02:02:26.290+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 17240, ]
08-01 02:02:26.290+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 02:02:26.290+0600 I/Tizen::App( 1185): (506) > TerminatedApp(com.samsung.weather-m-agent)
08-01 02:02:26.290+0600 I/Tizen::App( 1185): (512) > Not registered pid(17240)
08-01 02:02:26.290+0600 I/Tizen::System( 1185): (246) > Terminated app [com.samsung.weather-m-agent]
08-01 02:02:26.300+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 02:02:26.300+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 17240
08-01 02:02:26.300+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:26.300+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 02:02:26.300+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 17240.
08-01 02:02:26.360+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:26.480+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:26.630+0600 I/Tizen::Net::Wifi( 1185): (941) > The background scan result updated.
08-01 02:02:26.730+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:26.790+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:27.451+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:27.811+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 02:02:30.684+0600 I/APP_CORE(  908): appcore-efl.c: __do_app(520) > [APP 908] Event: MEM_FLUSH State: PAUSED
08-01 02:02:31.155+0600 W/AUL_AMD (  630): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-01 02:02:36.810+0600 I/Tizen::Net::Wifi( 1185): (941) > The background scan result updated.
08-01 02:02:48.692+0600 I/Tizen::System( 1185): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
08-01 02:02:54.808+0600 I/Tizen::Net::Wifi( 1185): (941) > The background scan result updated.
08-01 02:02:55.689+0600 E/VOLUME  ( 1087): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-01 02:02:55.689+0600 E/VOLUME  ( 1087): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
08-01 02:02:55.709+0600 E/cluster-home(  947): homescreen.cpp: OnPause(260) >  app pause
08-01 02:02:55.719+0600 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __provider_pause_cb(304) > widget obj was paused
08-01 02:02:55.719+0600 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __check_status_for_cgroup(152) > enter background group
08-01 02:02:55.719+0600 W/AUL     ( 1292): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1292, appid: com.samsung.weather-m-widget, status: bg
08-01 02:02:55.719+0600 W/LOCKSCREEN(  908): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
08-01 02:02:55.719+0600 W/LOCKSCREEN(  908): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
08-01 02:02:55.719+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
08-01 02:02:55.719+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:10e7450
08-01 02:02:55.719+0600 W/LOCKSCREEN(  908): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:3
08-01 02:02:55.719+0600 W/LOCKSCREEN(  908): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
08-01 02:02:55.729+0600 E/LOCKSCREEN(  908): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
08-01 02:02:55.729+0600 W/APP_CORE(11456): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
08-01 02:02:55.729+0600 I/APP_CORE(11456): appcore-efl.c: __do_app(520) > [APP 11456] Event: PAUSE State: RUNNING
08-01 02:02:55.729+0600 I/CAPI_APPFW_APPLICATION(11456): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-01 02:02:55.739+0600 E/LOCKSCREEN(  908): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
08-01 02:02:55.769+0600 E/VCONF   ( 7262): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
08-01 02:02:55.769+0600 E/VCONF   ( 7262): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
08-01 02:02:55.769+0600 E/LOCKSCREEN(  908): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
08-01 02:02:55.779+0600 W/INDICATOR(  661): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
08-01 02:02:56.279+0600 E/cluster-home(  947): homescreen.cpp: OnPause(260) >  app pause
08-01 02:02:56.279+0600 E/VOLUME  ( 1087): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-01 02:02:56.279+0600 E/VOLUME  ( 1087): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
08-01 02:02:56.289+0600 I/APP_CORE(11456): appcore-efl.c: __do_app(520) > [APP 11456] Event: PAUSE State: PAUSED
08-01 02:02:56.299+0600 I/TIZEN_N_EFL_UTIL_WINDOW(11456): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
08-01 02:02:56.299+0600 E/APP_CORE(11456): appcore-efl.c: _capture_and_make_file(1631) > win[7e00002] widget[480] height[800]
08-01 02:02:56.299+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 33
08-01 02:02:56.309+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e298f8), gem(12), surface(0xb7e198f8)
08-01 02:02:56.359+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e30910), gem(21), surface(0xb7da9528)
08-01 02:02:56.359+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 02:02:56.359+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 02:02:56.389+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(908) status(3)
08-01 02:02:56.389+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 02:02:56.389+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 02:02:56.389+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(908)
08-01 02:02:56.389+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 908, appid: com.samsung.lockscreen, status: fg
08-01 02:02:56.389+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(11456) status(4)
08-01 02:02:56.389+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.bluetooth(11456)
08-01 02:02:56.389+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 11456, appid: org.example.bluetooth, status: bg
08-01 02:02:56.399+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:56.399+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 02:02:56.409+0600 I/Tizen::System( 1185): (259) > Active app [com.samsun], current [org.exampl] 
08-01 02:02:56.409+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 02:02:56.419+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 02:02:56.419+0600 I/Tizen::System( 1185): (458) > org.tizen.system.deviced.display - CurrentBrightness (41)
08-01 02:02:56.439+0600 I/APP_CORE(  661): appcore-efl.c: __do_app(520) > [APP 661] Event: MEM_FLUSH State: CREATED
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:1:LOCK
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:1 event_info:0
08-01 02:02:56.509+0600 E/LOCKSCREEN(  908): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): lockscreen.c: _window_visibility_cb(346) > [_window_visibility_cb:346:W] Window [0x1200007] is [visible]
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:10001:WIN_BECOME_VISIBLE
08-01 02:02:56.509+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:10001 event_info:0
08-01 02:02:56.509+0600 W/INDICATOR(  661): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
08-01 02:02:56.519+0600 E/LOCKSCREEN(  908): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
08-01 02:02:56.519+0600 W/APP_CORE(  908): appcore-efl.c: __visibility_cb(1001) > LCD status is off, skip the AE_RESUME event
08-01 02:02:56.519+0600 E/VCONF   ( 7262): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
08-01 02:02:56.519+0600 E/VCONF   ( 7262): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
08-01 02:02:56.519+0600 W/INDICATOR(  661): main.c: _indicator_lock_status_cb(413) > Hide Clock
08-01 02:02:56.519+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7d77518), gem(13), surface(0xb7e6b0c0)
08-01 02:02:56.519+0600 E/EFL     (  908): edje<908> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 02:02:56.519+0600 E/EFL     (  908): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 02:02:56.519+0600 E/EFL     (  908): edje<908> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 02:02:56.519+0600 E/EFL     (  908): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 02:02:56.529+0600 W/AUL     (  908): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
08-01 02:02:56.529+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 0
08-01 02:02:56.529+0600 W/AUL_AMD (  630): amd_launch.c: _start_app(2527) > caller pid : 908
08-01 02:02:56.529+0600 I/AUL_AMD (  630): amd_launch.c: __check_app_control_privilege(1849) > Skip the privilege check in case of preloaded apps
08-01 02:02:56.539+0600 W/AUL_AMD (  630): amd_launch.c: _start_app(3262) > loading shared rule
08-01 02:02:56.539+0600 I/SHAREDRULE_CLIENT(  630): SharedruleClient.cpp: loadSharedrule(285) > Enter
08-01 02:02:56.539+0600 I/SHAREDRULE_CLIENT(  630): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.weather-m has already loaded
08-01 02:02:56.539+0600 I/SHAREDRULE_CLIENT(  630): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
08-01 02:02:56.539+0600 W/AUL_AMD (  630): amd_launch.c: start_process(648) > child process: 17446
08-01 02:02:56.549+0600 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
08-01 02:02:56.579+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7d6e068), gem(24), surface(0xb7d7ac50)
08-01 02:02:56.600+0600 W/AUL_AMD (  630): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 17446
08-01 02:02:56.600+0600 W/AUL     (  630): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 17446, appid: com.samsung.weather-m-agent
08-01 02:02:56.600+0600 W/AUL     (  908): launch.c: app_request_to_launchpad(425) > request cmd(0) result(17446)
08-01 02:02:56.600+0600 W/LOCKSCREEN(  908): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
08-01 02:02:56.600+0600 W/LOCKSCREEN(  908): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
08-01 02:02:56.600+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
08-01 02:02:56.600+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
08-01 02:02:56.600+0600 W/LOCKSCREEN(  908): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
08-01 02:02:56.600+0600 W/LOCKSCREEN(  908): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
08-01 02:02:56.630+0600 E/LOCKSCREEN(  908): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
08-01 02:02:56.630+0600 E/LOCKSCREEN(  908): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
08-01 02:02:56.630+0600 E/LOCKSCREEN(  908): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
08-01 02:02:56.630+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
08-01 02:02:56.630+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
08-01 02:02:56.660+0600 I/Tizen::App( 1185): (499) > LaunchedApp(com.samsung.weather-m-agent)
08-01 02:02:56.660+0600 I/Tizen::App( 1185): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 17446.
08-01 02:02:56.720+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:56.720+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 02:02:56.720+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:56.720+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 02:02:56.720+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:56.720+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 02:02:56.720+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:56.720+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 02:02:56.720+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:56.760+0600 E/weather-agent(17446): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
08-01 02:02:56.760+0600 E/weather-common(17446): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
08-01 02:02:56.760+0600 E/weather-agent(17446): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
08-01 02:02:56.760+0600 E/weather-agent(17446): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
08-01 02:02:56.770+0600 I/MESSAGE_PORT(17446): message-port.c: __initialize(872) > initialize
08-01 02:02:56.780+0600 I/MESSAGE_PORT(17446): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
08-01 02:02:56.810+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
08-01 02:02:56.810+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
08-01 02:02:56.810+0600 I/MESSAGE_PORT(17446): message-port.c: __message_port_send_message(972) > port exist check !!
08-01 02:02:56.810+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
08-01 02:02:56.810+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
08-01 02:02:56.810+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
08-01 02:02:56.820+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
08-01 02:02:56.820+0600 I/MESSAGE_PORT(  908): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
08-01 02:02:56.820+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __message_port_send_message(972) > port exist check !!
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
08-01 02:02:56.820+0600 E/MESSAGE_PORT(17446): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
08-01 02:02:56.820+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __message_port_send_message(972) > port exist check !!
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
08-01 02:02:56.820+0600 E/MESSAGE_PORT(17446): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
08-01 02:02:56.820+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __message_port_send_message(972) > port exist check !!
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
08-01 02:02:56.820+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __message_port_send_message(972) > port exist check !!
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
08-01 02:02:56.830+0600 I/MESSAGE_PORT( 1292): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
08-01 02:02:56.830+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 02:02:56.830+0600 E/MESSAGE_PORT(17446): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : Dhaka[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Dhaka[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 32.200000[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 34.300000[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 78.800000[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 3[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1469946300[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
08-01 02:02:56.830+0600 E/weather-common(17446): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
08-01 02:02:56.830+0600 E/weather-agent(17446): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
08-01 02:02:56.830+0600 E/weather-agent(17446): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
08-01 02:02:56.830+0600 I/MESSAGE_PORT(17446): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
08-01 02:02:56.840+0600 I/MESSAGE_PORT(17446): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
08-01 02:02:56.860+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 02:02:56.900+0600 E/weather-widget( 1292): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
08-01 02:02:56.900+0600 E/weather-widget( 1292): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
08-01 02:02:57.130+0600 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_create(409) > New handle created[0xb806d9e0]
08-01 02:02:57.140+0600 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_get_type(463) > Connected Network = 0
08-01 02:02:57.140+0600 E/weather-common( 1292): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
08-01 02:02:57.140+0600 E/weather-common( 1292): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
08-01 02:02:57.140+0600 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_destroy(427) > Destroy handle: 0xb806d9e0
08-01 02:02:57.140+0600 E/weather-common( 1292): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
08-01 02:02:57.140+0600 W/LOCATION( 1292): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
08-01 02:02:57.140+0600 E/weather-common( 1292): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
08-01 02:02:57.140+0600 E/weather-widget( 1292): Widget4x4Page.cpp: UpdatePage(322) > [0;40;31mNot updated bottomline : network is not available[0;m
08-01 02:02:57.150+0600 E/weather-widget( 1292): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
08-01 02:02:57.150+0600 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __provider_update_cb(287) > received updating signal
08-01 02:02:57.170+0600 E/EFL     ( 1292): edje<1292> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
08-01 02:02:57.190+0600 E/EFL     ( 1292): evas_main<1292> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8009b29f is not stable during recalc loop
08-01 02:02:57.250+0600 E/EFL     ( 1292): evas_main<1292> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8009b29f is not stable during recalc loop
08-01 02:02:57.250+0600 E/EFL     ( 1292): edje<1292> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
08-01 02:02:57.260+0600 E/cluster-home(  947): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
08-01 02:02:57.841+0600 E/weather-agent(17446): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
08-01 02:02:57.841+0600 I/CAPI_APPFW_APPLICATION(17446): service_app_main.c: service_app_exit(446) > service_app_exit
08-01 02:02:57.841+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 02:02:57.841+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 02:02:57.841+0600 E/weather-agent(17446): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
08-01 02:02:57.991+0600 W/AUL_AMD (  630): amd_request.c: __send_app_termination_signal(613) > send dead signal done
08-01 02:02:57.991+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17446
08-01 02:02:57.991+0600 I/Tizen::App( 1185): (243) > App[com.samsung.weather-m-agent] pid[17446] terminate event is forwarded
08-01 02:02:57.991+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 02:02:57.991+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 17446, ]
08-01 02:02:57.991+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 02:02:57.991+0600 I/Tizen::App( 1185): (506) > TerminatedApp(com.samsung.weather-m-agent)
08-01 02:02:57.991+0600 I/Tizen::App( 1185): (512) > Not registered pid(17446)
08-01 02:02:57.991+0600 I/Tizen::System( 1185): (246) > Terminated app [com.samsung.weather-m-agent]
08-01 02:02:57.991+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 02:02:57.991+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 17446
08-01 02:02:57.991+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:57.991+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 02:02:57.991+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 17446.
08-01 02:02:59.412+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:59.412+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 02:02:59.412+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:02:59.412+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 02:03:00.744+0600 I/APP_CORE(11456): appcore-efl.c: __do_app(520) > [APP 11456] Event: MEM_FLUSH State: PAUSED
08-01 02:03:02.846+0600 W/AUL_AMD (  630): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-01 02:04:11.222+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 29
08-01 02:04:11.222+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:04:11.222+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:04:11.222+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:04:11.232+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:06:21.349+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:06:21.349+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 30
08-01 02:06:21.349+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:06:21.349+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:06:21.349+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:08:31.486+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:08:31.486+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 31
08-01 02:08:31.486+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:08:31.486+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:08:31.486+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:10:31.603+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:10:31.613+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 32
08-01 02:10:31.613+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:10:31.613+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:10:31.613+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:12:41.740+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 33
08-01 02:12:41.740+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:12:41.740+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:12:41.740+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:12:41.740+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:14:41.868+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 34
08-01 02:14:41.868+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:14:41.868+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:14:41.868+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:14:41.888+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:16:51.995+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 35
08-01 02:16:51.995+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:16:51.995+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:16:51.995+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:16:52.015+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:18:52.112+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 36
08-01 02:18:52.112+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:18:52.112+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:18:52.112+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:18:52.122+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:21:02.239+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 37
08-01 02:21:02.239+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:21:02.239+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:21:02.239+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:21:02.259+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:23:02.386+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:23:02.386+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 38
08-01 02:23:02.386+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:23:02.386+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:23:02.386+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:25:02.503+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:25:02.503+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 39
08-01 02:25:02.503+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:25:02.503+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:25:02.503+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:27:12.630+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:27:12.640+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 40
08-01 02:27:12.640+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:27:12.640+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:27:12.640+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:29:22.777+0600 W/LOCKSCREEN(  908): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 41
08-01 02:29:22.777+0600 W/LOCKSCREEN(  908): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 02:29:22.777+0600 W/LOCKSCREEN(  908): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 02:29:22.777+0600 W/LOCKSCREEN(  908): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 02:29:22.777+0600 E/INDICATOR(  661): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-01 02:30:10.594+0600 E/PKGMGR_SERVER(29072): pkgmgr-server.c: main(2414) > package manager server start
08-01 02:30:10.664+0600 E/PKGMGR  (29068): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 14
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 11456
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 12
08-01 02:30:10.714+0600 W/AUL     (29075): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11456)
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 5
08-01 02:30:10.714+0600 I/APP_CORE(11456): appcore-efl.c: __do_app(520) > [APP 11456] Event: TERMINATE State: PAUSED
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_launch.c: __reply_handler(1102) > listen fd(26) , send fd(25), pid(11456), cmd(4)
08-01 02:30:10.714+0600 W/AUL     (29075): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 14
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 02:30:10.714+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 02:30:10.724+0600 I/TIZEN_N_EFL_UTIL_WINDOW(11456): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 2
08-01 02:30:10.724+0600 E/APP_CORE(11456): appcore-efl.c: _capture_and_make_file(1631) > win[7e00002] widget[480] height[800]
08-01 02:30:10.724+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 33
08-01 02:30:10.724+0600 E/APP_CORE(11456): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
08-01 02:30:10.724+0600 I/CAPI_APPFW_APPLICATION(11456): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
08-01 02:30:10.734+0600 E/PKGMGR_SERVER(29072): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29075]
08-01 02:30:10.824+0600 E/CAPI_NETWORK_BLUETOOTH(11456): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
08-01 02:30:10.824+0600 E/CAPI_NETWORK_BLUETOOTH(11456): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
08-01 02:30:10.824+0600 E/bluetooth(11456): [bt_adapter_le_destroy_advertiser] Failed.
08-01 02:30:10.844+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(947) status(3)
08-01 02:30:10.844+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 02:30:10.844+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 02:30:10.844+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(947)
08-01 02:30:10.844+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 947, appid: com.samsung.homescreen, status: fg
08-01 02:30:10.854+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 02:30:10.864+0600 W/HOME_APPS(  947): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2156) >  finished path[/opt/usr/apps/org.example.bluetooth/shared/res/bluetooth.png], Loading state:[1]
08-01 02:30:10.864+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7dcc358), gem(22), surface(0xb7cd8000)
08-01 02:30:10.884+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d87820), gem(15), surface(0xb7e46ac0)
08-01 02:30:10.894+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d6e068), gem(24), surface(0xb7db8850)
08-01 02:30:10.894+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d77518), gem(13), surface(0xb7dbe7f8)
08-01 02:30:10.934+0600 E/EFL     (11456): ecore<11456> lib/ecore/ecore_main.c:1552 _ecore_main_fd_handlers_bads_rem() Removing bad fds
08-01 02:30:10.934+0600 E/EFL     (11456): ecore<11456> lib/ecore/ecore_main.c:1561 _ecore_main_fd_handlers_bads_rem() Found bad fd at index 23
08-01 02:30:10.934+0600 E/EFL     (11456): ecore<11456> lib/ecore/ecore_main.c:1564 _ecore_main_fd_handlers_bads_rem() Fd set for error! calling user
08-01 02:30:10.974+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7dcc358), gem(22), surface(0xb7da9528)
08-01 02:30:11.144+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 11456 pgid = 11456
08-01 02:30:11.144+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(143) > dead_pid(11456)
08-01 02:30:11.234+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 02:30:11.234+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 02:30:11.234+0600 E/AUL_PAD ( 1321): launchpad.c: main(698) > error reading sigchld info
08-01 02:30:11.234+0600 I/Tizen::App( 1185): (243) > App[org.example.bluetooth] pid[11456] terminate event is forwarded
08-01 02:30:11.234+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 02:30:11.234+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [org.example.bluetooth, 11456, ]
08-01 02:30:11.234+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 02:30:11.234+0600 I/Tizen::App( 1185): (506) > TerminatedApp(org.example.bluetooth)
08-01 02:30:11.234+0600 I/Tizen::App( 1185): (512) > Not registered pid(11456)
08-01 02:30:11.234+0600 I/Tizen::System( 1185): (246) > Terminated app [org.example.bluetooth]
08-01 02:30:11.234+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 02:30:11.234+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 11456
08-01 02:30:11.234+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 11456
08-01 02:30:11.244+0600 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1122
08-01 02:30:11.244+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 02:30:11.244+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 02:30:11.244+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for org.example.bluetooth, 11456.
08-01 02:30:11.284+0600 W/CRASH_MANAGER(29080): worker.c: worker_job(1199) > 0611456626c75146999701
