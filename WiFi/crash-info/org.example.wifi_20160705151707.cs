S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: wifi
PID: 2746
Date: 2016-07-05 15:17:07+0600
Executable File Path: /opt/usr/apps/org.example.wifi/bin/wifi
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2746, uid 5000)

Register Information
r0   = 0xb8807440, r1   = 0x00000000
r2   = 0x0000004e, r3   = 0x9fc31f00
r4   = 0xbedefeb0, r5   = 0x00000002
r6   = 0x00000008, r7   = 0xbedf3390
r8   = 0xb2a51f24, r9   = 0x00000000
r10  = 0xb2a6c311, fp   = 0xb8806cf0
ip   = 0xb6765fb4, sp   = 0xbedefe48
lr   = 0xb2a6c4a5, pc   = 0xb6765fc8
cpsr = 0x200b0010

Memory Information
MemTotal:   730440 KB
MemFree:     70624 KB
Buffers:     30156 KB
Cached:     261368 KB
VmPeak:     107320 KB
VmSize:     107316 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24380 KB
VmRSS:       24380 KB
VmData:      34516 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2746 TID = 2746
2746 2750 2985 2986 

Maps Information
b1501000 b1d00000 rw-p [stack:2986]
b1e1a000 b2619000 rw-p [stack:2985]
b2619000 b262a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b263a000 b263f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b26cb000 b26d3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b26e4000 b26e5000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b26f5000 b2709000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b271d000 b271e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b272e000 b2731000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2742000 b2743000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2753000 b2755000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2765000 b2767000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2777000 b2787000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2797000 b27a3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b29f3000 b2a0a000 r-xp /usr/lib/libnetwork.so.0.0.0
b2a1b000 b2a22000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2a33000 b2a42000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a54000 b2a5a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a6a000 b2a6e000 r-xp /opt/usr/apps/org.example.wifi/bin/wifi
b2b8f000 b2c72000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ca9000 b2cd1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce3000 b34e2000 rw-p [stack:2750]
b34e2000 b34e4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34f4000 b34fe000 r-xp /lib/libnss_files-2.20-2014.11.so
b350f000 b3518000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3529000 b353a000 r-xp /lib/libnsl-2.20-2014.11.so
b354d000 b3553000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3564000 b3565000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b358d000 b3594000 r-xp /usr/lib/libminizip.so.1.0.0
b35a4000 b35a9000 r-xp /usr/lib/libstorage.so.0.1
b35b9000 b360e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3624000 b3638000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3648000 b368c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b369c000 b36a4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36b4000 b36e4000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36f7000 b37b0000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37c4000 b3818000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3829000 b3844000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3854000 b3915000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3928000 b393a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b394a000 b394e000 r-xp /usr/lib/libogg.so.0.7.1
b395e000 b3980000 r-xp /usr/lib/libvorbis.so.0.4.3
b3990000 b3a74000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a90000 b3a9d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3aae000 b3af1000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b06000 b3b4d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b5e000 b3b64000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b75000 b3b7c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b8c000 b3bcc000 r-xp /usr/lib/libmdm.so.1.2.10
b3bdc000 b3be4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf3000 b3c03000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c24000 b3c84000 r-xp /usr/lib/libasound.so.2.0.0
b3c96000 b3ccc000 r-xp /usr/lib/libpulse.so.0.16.2
b3cdd000 b3ce0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cf0000 b3cf3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d03000 b3d08000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d18000 b3d19000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d29000 b3d34000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d48000 b3d4f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d5f000 b3d65000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d75000 b3d7a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d8a000 b3da5000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3db5000 b3dbc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dcc000 b3dcf000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3de0000 b3e0e000 r-xp /usr/lib/libidn.so.11.5.44
b3e1e000 b3e34000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e45000 b3e4f000 r-xp /usr/lib/libcares.so.2.1.0
b3e5f000 b3e69000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e79000 b3e7b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e8b000 b3e8c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e9c000 b3ea0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eb1000 b3ed9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3eea000 b3f13000 r-xp /usr/lib/libturbojpeg.so
b3f33000 b3f39000 r-xp /usr/lib/libgif.so.4.1.6
b3f49000 b3f8f000 r-xp /usr/lib/libcurl.so.4.3.0
b3fa0000 b3fc1000 r-xp /usr/lib/libexif.so.12.3.3
b3fdc000 b3ff1000 r-xp /usr/lib/libtts.so
b4002000 b400a000 r-xp /usr/lib/libfeedback.so.0.1.4
b401a000 b40da000 r-xp /usr/lib/libdali-core.so.0.0.0
b40e5000 b41d8000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41f8000 b42d2000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42e9000 b42eb000 r-xp /usr/lib/libboost_system.so.1.51.0
b42fb000 b4301000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4311000 b4334000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4345000 b4347000 r-xp /usr/lib/libappsvc.so.0.1.0
b4357000 b4359000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b436a000 b436f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4386000 b4388000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4398000 b439f000 r-xp /usr/lib/libsensord-share.so
b43af000 b43c7000 r-xp /usr/lib/libsensor.so.1.1.0
b43d8000 b43db000 r-xp /usr/lib/libXv.so.1.0.0
b43eb000 b43f0000 r-xp /usr/lib/libutilX.so.1.1.0
b4400000 b4405000 r-xp /usr/lib/libappcore-common.so.1.1
b4415000 b441c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b442f000 b4433000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4444000 b450e000 r-xp /usr/lib/libCOREGL.so.4.0
b4525000 b4528000 r-xp /usr/lib/libuuid.so.1.3.0
b4539000 b4550000 r-xp /usr/lib/libblkid.so.1.1.0
b4561000 b4563000 r-xp /usr/lib/libXau.so.6.0.0
b4573000 b4576000 r-xp /usr/lib/libEGL.so.1.4
b457e000 b4584000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4594000 b4596000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a7000 b45b5000 r-xp /usr/lib/libGLESv2.so.2.0
b45be000 b4620000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4635000 b464d000 r-xp /usr/lib/libmount.so.1.1.0
b465e000 b4672000 r-xp /usr/lib/libxcb.so.1.1.0
b4683000 b468a000 r-xp /lib/libcrypt-2.20-2014.11.so
b46c2000 b46d3000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46e4000 b46e6000 r-xp /usr/lib/libiri.so
b46f6000 b4701000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4712000 b4727000 r-xp /lib/libexpat.so.1.5.2
b4739000 b47f7000 r-xp /usr/lib/libcairo.so.2.11200.14
b480a000 b4812000 r-xp /usr/lib/libdrm.so.2.4.0
b4822000 b4825000 r-xp /usr/lib/libdri2.so.0.0.0
b4836000 b4884000 r-xp /usr/lib/libssl.so.1.0.0
b4899000 b48a5000 r-xp /usr/lib/libeeze.so.1.13.0
b48b5000 b48be000 r-xp /usr/lib/libethumb.so.1.13.0
b48ce000 b48d1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48e1000 b4a98000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ef000 b56f8000 r-xp /usr/lib/libXi.so.6.1.0
b5708000 b570a000 r-xp /usr/lib/libXgesture.so.7.0.0
b571a000 b571e000 r-xp /usr/lib/libXtst.so.6.1.0
b572e000 b5734000 r-xp /usr/lib/libXrender.so.1.3.0
b5744000 b574a000 r-xp /usr/lib/libXrandr.so.2.2.0
b575b000 b575d000 r-xp /usr/lib/libXinerama.so.1.0.0
b576d000 b5770000 r-xp /usr/lib/libXfixes.so.3.1.0
b5780000 b578b000 r-xp /usr/lib/libXext.so.6.4.0
b579b000 b579d000 r-xp /usr/lib/libXdamage.so.1.1.0
b57ad000 b57af000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57c0000 b58a2000 r-xp /usr/lib/libX11.so.6.3.0
b58b5000 b58bc000 r-xp /usr/lib/libXcursor.so.1.0.2
b58cc000 b58e4000 r-xp /usr/lib/libudev.so.1.6.0
b58e6000 b58e9000 r-xp /lib/libattr.so.1.1.0
b58f9000 b5919000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b591b000 b5920000 r-xp /usr/lib/libffi.so.6.0.2
b5930000 b5948000 r-xp /lib/libz.so.1.2.8
b5958000 b595a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b596a000 b5a3f000 r-xp /usr/lib/libxml2.so.2.9.2
b5a54000 b5aef000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b0b000 b5b0e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b1e000 b5b37000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b48000 b5b59000 r-xp /lib/libresolv-2.20-2014.11.so
b5b6d000 b5be7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bfc000 b5bfe000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c0e000 b5c15000 r-xp /usr/lib/libembryo.so.1.13.0
b5c25000 b5c3d000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4e000 b5c71000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c92000 b5ca6000 r-xp /usr/lib/libector.so.1.13.0
b5cb7000 b5ccf000 r-xp /usr/lib/liblua-5.1.so
b5ce0000 b5d37000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4b000 b5d73000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d84000 b5d97000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da8000 b5ddf000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df0000 b5dfe000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e0e000 b5e16000 r-xp /usr/lib/libtbm.so.1.0.0
b5e26000 b5e33000 r-xp /usr/lib/libeio.so.1.13.0
b5e43000 b5e45000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e55000 b5e5a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6a000 b5e81000 r-xp /usr/lib/libefreet.so.1.13.0
b5e93000 b5eb3000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec3000 b5ee3000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee5000 b5eeb000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efb000 b5f0c000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1d000 b5f24000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f34000 b5f43000 r-xp /usr/lib/libeo.so.1.13.0
b5f54000 b5f66000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f77000 b5f7c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8c000 b5fa5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb5000 b5fd2000 r-xp /usr/lib/libeet.so.1.13.0
b5feb000 b6033000 r-xp /usr/lib/libeina.so.1.13.0
b6044000 b6054000 r-xp /usr/lib/libefl.so.1.13.0
b6065000 b614a000 r-xp /usr/lib/libicuuc.so.51.1
b6167000 b62a7000 r-xp /usr/lib/libicui18n.so.51.1
b62be000 b62f6000 r-xp /usr/lib/libecore_x.so.1.13.0
b6308000 b630b000 r-xp /lib/libcap.so.2.21
b631b000 b6344000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6355000 b635c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b636e000 b63a5000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b6000 b64a1000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b4000 b652d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b653f000 b6544000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6554000 b655e000 r-xp /usr/lib/libvconf.so.0.2.45
b656e000 b6570000 r-xp /usr/lib/libvasum.so.0.3.1
b6580000 b6582000 r-xp /usr/lib/libttrace.so.1.1
b6592000 b6595000 r-xp /usr/lib/libiniparser.so.0
b65a5000 b65cb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65db000 b65e0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f1000 b6608000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6619000 b6684000 r-xp /lib/libm-2.20-2014.11.so
b6695000 b669b000 r-xp /lib/librt-2.20-2014.11.so
b66ac000 b66b9000 r-xp /usr/lib/libunwind.so.8.0.1
b66ef000 b6813000 r-xp /lib/libc-2.20-2014.11.so
b6828000 b6841000 r-xp /lib/libgcc_s-4.9.so.1
b6851000 b6933000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6944000 b696e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697f000 b69bb000 r-xp /usr/lib/libsystemd.so.0.4.0
b69bd000 b6a3f000 r-xp /usr/lib/libedje.so.1.13.0
b6a52000 b6a70000 r-xp /usr/lib/libecore.so.1.13.0
b6a90000 b6c17000 r-xp /usr/lib/libevas.so.1.13.0
b6c4c000 b6c60000 r-xp /lib/libpthread-2.20-2014.11.so
b6c74000 b6ea9000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed7000 b6edb000 r-xp /usr/lib/libsmack.so.1.0.0
b6eeb000 b6ef2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f02000 b6f04000 r-xp /usr/lib/libdlog.so.0.0.0
b6f14000 b6f17000 r-xp /usr/lib/libbundle.so.0.1.22
b6f27000 b6f29000 r-xp /lib/libdl-2.20-2014.11.so
b6f3a000 b6f52000 r-xp /usr/lib/libaul.so.0.1.0
b6f66000 b6f6b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7c000 b6f89000 r-xp /usr/lib/liblptcp.so
b6f9b000 b6f9f000 r-xp /usr/lib/libsys-assert.so
b6fb0000 b6fd0000 r-xp /lib/ld-2.20-2014.11.so
b6fe1000 b6fe6000 r-xp /usr/bin/launchpad-loader
b8552000 b884f000 rw-p [heap]
bedd4000 bedf5000 rw-p [stack]
b8552000 b884f000 rw-p [heap]
bedd4000 bedf5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2746)
Call Stack Count: 1
 0: strstr + 0x14 (0xb6765fc8) [/lib/libc.so.6] + 0x76fc8
End of Call Stack

Package Information
Package Name: org.example.wifi
Package ID : org.example.wifi
Version: 1.0.0
Package Type: tpk
App Name: wifi
App ID: org.example.wifi
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
sdst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(381) > duetime is less than or equal to current time. current_dst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(407) > before_dst = 0, 12:42:0. duetime = 1467700920
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(441) > after_dst = 0, 12:42:0. duetime = 1467787320
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(450) > Final due_time = 1467787320
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 568480028, next duetime: 1467787320
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(378) > 13:42:0. duetime = 1467704520, isdst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(381) > duetime is less than or equal to current time. current_dst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(407) > before_dst = 0, 13:42:0. duetime = 1467704520
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(441) > after_dst = 0, 13:42:0. duetime = 1467790920
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(450) > Final due_time = 1467790920
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1042205812, next duetime: 1467790920
07-05 15:16:44.130+0600 F/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_repeat(247) > Error! Despite repeated alarm, interval <= 0.
07-05 15:16:44.130+0600 F/ALARM_MANAGER(  681): alarm_id=1105422870, pid=1497, app_unique_name=/usr/bin/oma-dm-agent, app_service_name=ALARM.oma-dm-agent, start time=1468540469
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1105422870, next duetime: 1468540469
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1467713455, Tue Jul  5 16:10:55 2016
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 850764900, next duetime: 1467713455
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(378) > 0:0:0. duetime = 1467655200, isdst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(381) > duetime is less than or equal to current time. current_dst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(407) > before_dst = 0, 0:0:0. duetime = 1467655200
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(441) > after_dst = 0, 0:0:0. duetime = 1467741600
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(450) > Final due_time = 1467741600
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 557946664, next duetime: 1467741600
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(207) > Final due_time = 1467741601, Wed Jul  6 00:00:01 2016
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1495721721, next duetime: 1467741601
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(207) > Final due_time = 1483207200, Sun Jan  1 00:00:00 2017
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1194944745, next duetime: 1483207200
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(207) > Final due_time = 1467718124, Tue Jul  5 17:28:44 2016
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1958843574, next duetime: 1467718124
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1467710592, Tue Jul  5 15:23:12 2016
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1043553087, next duetime: 1467710592
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(378) > 15:11:13. duetime = 1467709873, isdst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(381) > duetime is less than or equal to current time. current_dst = 0
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(407) > before_dst = 0, 15:11:13. duetime = 1467709873
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(441) > after_dst = 0, 15:11:13. duetime = 1467796273
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_weekly(450) > Final due_time = 1467796273
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 902545845, next duetime: 1467796273
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 2021176807, next duetime: 1467774697
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1266165856, next duetime: 1467797805
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-7-2016, 09:23:12 (UTC).
07-05 15:16:44.130+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-05 15:16:44.140+0600 W/AUL     (  748): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.wallpaper-ui-service)
07-05 15:16:44.140+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 0
07-05 15:16:44.140+0600 W/cluster-home(  880): mainmenu-presenter.cpp: AppTimeChanged(348) >  time change: [5->5]
07-05 15:16:44.140+0600 W/cluster-home(  880): mainmenu-presenter.cpp: AppTimeChanged(351) >  same date
07-05 15:16:44.140+0600 W/LOCKSCREEN(  869): util-time.c: _util_system_time_vconf_changed_cb(1210) > [_util_system_time_vconf_changed_cb:1210:W] tick by 1
07-05 15:16:44.140+0600 W/LOCKSCREEN(  869): util-time.c: _util_system_time_vconf_changed_cb(1220) > [_util_system_time_vconf_changed_cb:1220:W] system time change 3
07-05 15:16:44.140+0600 W/LOCKSCREEN(  869): util-time.c: _util_time_vconf_changed_cb(1196) > [_util_time_vconf_changed_cb:1196:W] tick by 1
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (340) > Setting event[http://tizen.org/setting/locale.date_time] is occured.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (351) > The key is http://tizen.org/setting/locale.date_time.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (355) > Try to awake client processes.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (362) > Event is delivered to b8961488.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (340) > Setting event[http://tizen.org/setting/locale.date] is occured.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (351) > The key is http://tizen.org/setting/locale.date.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (355) > Try to awake client processes.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (362) > Event is delivered to b8961488.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (340) > Setting event[http://tizen.org/setting/locale.time] is occured.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (351) > The key is http://tizen.org/setting/locale.time.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (355) > Try to awake client processes.
07-05 15:16:44.150+0600 I/Tizen::System( 1472): (362) > Event is delivered to b8961488.
07-05 15:16:44.180+0600 I/AUL     (  648): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
07-05 15:16:44.180+0600 E/AUL_AMD (  648): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
07-05 15:16:44.180+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 748
07-05 15:16:44.180+0600 E/AUL_AMD (  648): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
07-05 15:16:44.190+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3262) > loading shared rule
07-05 15:16:44.190+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
07-05 15:16:44.190+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.wallpaper-ui-service has already loaded
07-05 15:16:44.190+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
07-05 15:16:44.190+0600 W/AUL_AMD (  648): amd_launch.c: start_process(648) > child process: 2896
07-05 15:16:44.190+0600 E/RESOURCED(  689): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
07-05 15:16:44.210+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __timeFormatChangedCb(973) > [0;32mBEGIN >>>>[0;m
07-05 15:16:44.210+0600 I/PHONE   ( 1211): PhLogIcu.cpp: setLocale(172) > [0;32mBEGIN >>>>[0;m
07-05 15:16:44.210+0600 I/PHONE   ( 1211): PhLogIcu.cpp: setDefaultTimezoneId(241) > [0;32mBEGIN >>>>[0;m
07-05 15:16:44.210+0600 I/PHONE   ( 1211): PhLogDbMgr.cpp: loadLogList(480) > [0;32mBEGIN >>>>[0;m
07-05 15:16:44.210+0600 I/PHONE   ( 1211): PhLogDbMgr.cpp: __getLogListDataFromDb(150) > [0;32mBEGIN >>>>[0;m
07-05 15:16:44.210+0600 I/PHONE   ( 1211): PhLogDbMgr.cpp: __getLogListDataFromDb(297) > [0;34m>>>HIT<<<[0;m
07-05 15:16:44.240+0600 E/AUL_AMD (  648): amd_launch.c: __check_cmdline(593) > error founded when being launched with 2896
07-05 15:16:44.290+0600 W/AUL_AMD (  648): amd_launch.c: __send_app_launch_signal(417) > send launch signal done: 2896
07-05 15:16:44.290+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 2896, appid: com.samsung.wallpaper-ui-service
07-05 15:16:44.290+0600 W/AUL     (  748): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2896)
07-05 15:16:44.300+0600 E/RESOURCED(  689): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.wallpaper-ui-service
07-05 15:16:44.380+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
07-05 15:16:44.420+0600 I/Tizen::App( 1472): (499) > LaunchedApp(com.samsung.wallpaper-ui-service)
07-05 15:16:44.420+0600 I/Tizen::App( 1472): (733) > Finished invoking application event listener for com.samsung.wallpaper-ui-service, 2896.
07-05 15:16:44.450+0600 E/RESOURCED(  689): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
07-05 15:16:44.450+0600 E/RESOURCED(  689): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
07-05 15:16:44.450+0600 E/RESOURCED(  689): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
07-05 15:16:44.450+0600 E/weather-widget( 1343): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
07-05 15:16:44.450+0600 E/weather-widget( 1343): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
07-05 15:16:44.510+0600 E/TIZEN_N_SYSTEM_SETTINGS(  685): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
07-05 15:16:44.510+0600 E/TIZEN_N_SYSTEM_SETTINGS(  685): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
07-05 15:16:44.510+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
07-05 15:16:44.520+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 3:16 p.m.
07-05 15:16:44.520+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 3:16 p.m."
07-05 15:16:44.520+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 3:16 p.m."
07-05 15:16:44.530+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
07-05 15:16:44.530+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147396556 Time: <font_size=31> </font_size> <font_size=31> 3:16 p.m.</font_size></font>"
07-05 15:16:44.620+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: main(2432) > ENTER FUNCTION: main.
07-05 15:16:44.620+0600 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
07-05 15:16:44.620+0600 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
07-05 15:16:44.620+0600 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
07-05 15:16:44.620+0600 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
07-05 15:16:44.650+0600 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: ui_app_main(789) > app_efl_main
07-05 15:16:44.810+0600 I/CAPI_NETWORK_CONNECTION( 1343): connection.c: connection_create(409) > New handle created[0xb89f6298]
07-05 15:16:44.810+0600 I/CAPI_NETWORK_CONNECTION( 1343): connection.c: connection_get_type(463) > Connected Network = 2
07-05 15:16:44.810+0600 I/CAPI_NETWORK_CONNECTION( 1343): connection.c: connection_destroy(427) > Destroy handle: 0xb89f6298
07-05 15:16:44.810+0600 E/weather-common( 1343): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
07-05 15:16:44.820+0600 W/LOCATION( 1343): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
07-05 15:16:44.820+0600 E/weather-common( 1343): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
07-05 15:16:44.850+0600 E/weather-widget( 1343): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
07-05 15:16:44.850+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __provider_update_cb(287) > received updating signal
07-05 15:16:44.860+0600 E/EFL     ( 1343): edje<1343> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-05 15:16:44.900+0600 E/EFL     ( 1343): evas_main<1343> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80148e4d is not stable during recalc loop
07-05 15:16:44.970+0600 E/EFL     ( 1343): evas_main<1343> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80148e4d is not stable during recalc loop
07-05 15:16:44.970+0600 E/EFL     ( 1343): edje<1343> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-05 15:16:44.980+0600 E/cluster-home(  880): cluster-data-list.cpp: GetDBoxID(1000) >  found id[3]
07-05 15:16:45.111+0600 I/UXT     ( 2896): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
07-05 15:16:45.121+0600 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
07-05 15:16:45.121+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _app_create(2215) > ENTER FUNCTION: _app_create.
07-05 15:16:45.121+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 2896): media_content.c: media_content_connect(856) > [32m[2896]ref count : 0
07-05 15:16:45.131+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 2896): media_content.c: media_content_connect(888) > [32m[2896]ref count changed to: 1
07-05 15:16:45.131+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _app_create(2223) > EXIT FUNCTION: _app_create.
07-05 15:16:45.131+0600 I/APP_CORE( 2896): appcore-efl.c: __do_app(520) > [APP 2896] Event: RESET State: CREATED
07-05 15:16:45.131+0600 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
07-05 15:16:45.131+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _app_reset(2319) > ENTER FUNCTION: _app_reset.
07-05 15:16:45.181+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _register_view(2026) > ENTER FUNCTION: _register_view.
07-05 15:16:45.181+0600 W/CAPI_APPFW_APP_CONTROL( 2896): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-05 15:16:45.181+0600 E/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _register_view(2036) > [WALLPAPER-UI-SERVICE_register_view:2036:E] from (null)
07-05 15:16:45.181+0600 W/CAPI_APPFW_APP_CONTROL( 2896): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-05 15:16:45.181+0600 E/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _register_view(2088) > [WALLPAPER-UI-SERVICE_register_view:2088:E] app_control_get_extra_data(setas-type) failed
07-05 15:16:45.211+0600 E/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: __festival_idler_cb(672) > [WALLPAPER-UI-SERVICE__festival_idler_cb:672:E] EXTRA_KEY_FESTIVAL_TYPE(festival_create)
07-05 15:16:45.211+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: festival_wallpaper_handle(1964) > [WALLPAPER-UI-SERVICEfestival_wallpaper_handle:1964:E] 130TZ
07-05 15:16:45.211+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: festival_wallpaper_handle(1971) > [WALLPAPER-UI-SERVICEfestival_wallpaper_handle:1971:E] ISO BD
07-05 15:16:45.241+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
07-05 15:16:45.241+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/2896/status successfully
07-05 15:16:45.241+0600 W/ALARM_MANAGER(  681): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 5000
07-05 15:16:45.241+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
07-05 15:16:45.261+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete_all(3052) > alarm_id[1495721721] is removed.
07-05 15:16:45.261+0600 E/ALARM_MANAGER(  681): alarm-manager.c: alarm_manager_alarm_delete_all(3052) > alarm_id[1194944745] is removed.
07-05 15:16:45.261+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-05 15:16:45.261+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-7-2016, 09:23:12 (UTC).
07-05 15:16:45.261+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-05 15:16:45.271+0600 I/CALENDAR_SVC( 1208): cal_access_control.c: _cal_access_control_set_permission_info(115) > [SECURE_LOG] Thread(0xafeff1f0), info(0xb49267d0), smack :com.samsung.wallpaper-ui-service, permission:3
07-05 15:16:45.371+0600 E/PHONE   ( 1211): PhLogDbMgr.cpp: loadLogList(500) > [0;31m* Critical * contacts_list_get_current_record_p() Failed(-61)[0;m
07-05 15:16:45.381+0600 I/PHONE   ( 1211): PhLogDbMgr.cpp: loadLogList(550) > [0;32msort by logTIme[0;m
07-05 15:16:45.381+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __setList(270) > [0;34m>>>HIT<<<[0;m
07-05 15:16:45.381+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __setGenlistItcs(592) > [0;34m>>>HIT<<<[0;m
07-05 15:16:45.381+0600 E/PHONE   ( 1211): PhLogUtil.cpp: isGrouped(567) > [0;31m* Critical * Invalid parameter: prevRecordInfo is NULL[0;m
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD001,Happy New Year,General,/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD001/bg.jpg,1,1451584800,1451671201
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD003,Mother Language Day,General,/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD003/bg.jpg,1,1455991200,1456077601
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD004,Independence Day,National,/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD004/bg.jpg,1,1458928800,1459015201
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD005,Shubho Noboborsho,National,/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD005/bg.jpg,1,1460570400,1460656801
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD006,May Day,General,/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD006/bg.jpg,1,1462039200,1462125601
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD007,Buddha Purnima,Religious (Buddhist),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD007/bg.jpg,1,1463767200,1463853601
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD015,Shab e Barat,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD015/bg.jpg,1,1463940000,1464026401
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD016,Jummatul Bida,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD016/bg.jpg,1,1467309600,1467396001
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD017,Shab e Qadar,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD017/bg.jpg,1,1467482400,1467568801
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD008,Eid-ul Fitr,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD008/bg.jpg,1,1467655200,1467741601
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD018,Janmastami,Religious (Hindu),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD018/bg.jpg,1,1472061600,1472148001
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD009,Eid-ul Ad'ha,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD009/bg.jpg,1,1473530400,1473616801
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD010,Durga Puja,Religious (Hindu),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD010/bg.jpg,1,1476122400,1476208801
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD011,Ashura Muharram,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD011/bg.jpg,1,1476208800,1476295201
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD013,Eid-e Miladunnabi,Religious (Muslim),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD013/bg.jpg,1,1481479200,1481565601
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD012,Victory Day,National,/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD012/bg.jpg,1,1481824800,1481911201
07-05 15:16:45.401+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: list_control(1925) > [WALLPAPER-UI-SERVICElist_control:1925:E] BD014,Merry Christmas,Religious (Christian),/opt/usr/apps/com.samsung.wallpaper-ui-service/data/wallpaper/festival_tz_bng/BD014/bg.jpg,1,1482602400,1482688801
07-05 15:16:45.411+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: launch_special_day_app(1320) > [WALLPAPER-UI-SERVICElaunch_special_day_app:1320:E] do not support
07-05 15:16:45.451+0600 E/ALARM_MANAGER( 2896): alarm-lib.c: alarmmgr_add_alarm_appsvc_with_localtime(842) > start(6-7-2016, 00:00:01), end(0-0-0), repeat(0), interval(0), type(16)
07-05 15:16:45.451+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
07-05 15:16:45.461+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
07-05 15:16:45.471+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
07-05 15:16:45.491+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(207) > Final due_time = 1467741601, Wed Jul  6 00:00:01 2016
07-05 15:16:45.491+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1950572772, next duetime: 1467741601
07-05 15:16:45.501+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1950572772)
07-05 15:16:45.501+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create_appsvc(1048) > [alarm-server]:alarm_context.c_due_time(1467710592), due_time(1467741601)
07-05 15:16:45.501+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-05 15:16:45.501+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-7-2016, 09:23:12 (UTC).
07-05 15:16:45.501+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-05 15:16:45.501+0600 E/ALARM_MANAGER( 2896): alarm-lib.c: __alarmmgr_init_appsvc(690) > alarm was already initialized.
07-05 15:16:45.531+0600 E/ALARM_MANAGER( 2896): alarm-lib.c: alarmmgr_add_alarm_appsvc_with_localtime(842) > start(1-1-2017, 00:00:00), end(0-0-0), repeat(0), interval(0), type(16)
07-05 15:16:45.531+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __get_zone_name(506) > zone name [/]
07-05 15:16:45.541+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
07-05 15:16:45.551+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 15
07-05 15:16:45.581+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: __alarm_next_duetime_once(207) > Final due_time = 1483207200, Sun Jan  1 00:00:00 2017
07-05 15:16:45.581+0600 E/ALARM_MANAGER(  681): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1950572773, next duetime: 1483207200
07-05 15:16:45.581+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1950572773)
07-05 15:16:45.581+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __alarm_create_appsvc(1048) > [alarm-server]:alarm_context.c_due_time(1467710592), due_time(1483207200)
07-05 15:16:45.581+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-05 15:16:45.581+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-7-2016, 09:23:12 (UTC).
07-05 15:16:45.611+0600 I/PHONE   ( 1211): PhLogGenlistHelper.cpp: appendFinish(217) > [0;34m>>>HIT<<<[0;m
07-05 15:16:45.651+0600 E/ALARM_MANAGER(  681): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-05 15:16:45.661+0600 E/WALLPAPER-UI-SERVICE( 2896): festival-wallpaper.c: wallpaper_list_free_any(892) > [WALLPAPER-UI-SERVICEwallpaper_list_free_any:892:E] (list == NULL) -> wallpaper_list_free_any() return
07-05 15:16:55.671+0600 E/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: __festival_dead_timer_cb(651) > [WALLPAPER-UI-SERVICE__festival_dead_timer_cb:651:E] festival end : exit
07-05 15:16:55.671+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
07-05 15:16:55.671+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
07-05 15:16:55.671+0600 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
07-05 15:16:55.671+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _app_terminate(2173) > ENTER FUNCTION: _app_terminate.
07-05 15:16:55.671+0600 I/CAPI_CONTENT_MEDIA_CONTENT( 2896): media_content.c: media_content_disconnect(940) > [32m[2896]ref count changed to: 0
07-05 15:16:55.671+0600 W/WALLPAPER-UI-SERVICE( 2896): wallpaper-ui-service.c: _app_terminate(2207) > EXIT FUNCTION: _app_terminate.
07-05 15:16:55.901+0600 W/AUL_AMD (  648): amd_request.c: __send_app_termination_signal(613) > send dead signal done
07-05 15:16:55.901+0600 I/Tizen::App( 1472): (243) > App[com.samsung.wallpaper-ui-service] pid[2896] terminate event is forwarded
07-05 15:16:55.901+0600 I/Tizen::System( 1472): (256) > osp.accessorymanager.service provider is found.
07-05 15:16:55.901+0600 I/Tizen::System( 1472): (196) > Accessory Owner is removed [com.samsung.wallpaper-ui-service, 2896, ]
07-05 15:16:55.901+0600 I/Tizen::System( 1472): (256) > osp.system.service provider is found.
07-05 15:16:55.901+0600 I/Tizen::App( 1472): (506) > TerminatedApp(com.samsung.wallpaper-ui-service)
07-05 15:16:55.901+0600 I/Tizen::App( 1472): (512) > Not registered pid(2896)
07-05 15:16:55.901+0600 I/Tizen::System( 1472): (246) > Terminated app [com.samsung.wallpaper-ui-service]
07-05 15:16:55.911+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:16:55.911+0600 I/ESD     (  934): esd_main.c: __esd_app_dead_handler(1773) > pid: 2896
07-05 15:16:55.911+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2896
07-05 15:16:55.921+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:16:55.921+0600 I/Tizen::App( 1472): (782) > Finished invoking application event listener for com.samsung.wallpaper-ui-service, 2896.
07-05 15:17:00.526+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
07-05 15:17:00.526+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 3:17 p.m.
07-05 15:17:00.526+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 3:17 p.m."
07-05 15:17:00.526+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 3:17 p.m."
07-05 15:17:00.526+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
07-05 15:17:00.526+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147346317 Time: <font_size=31> </font_size> <font_size=31> 3:17 p.m.</font_size></font>"
07-05 15:17:00.686+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
07-05 15:17:03.088+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:17:03.168+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=263032
07-05 15:17:03.218+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=263082
07-05 15:17:03.218+0600 W/AUL     (  880): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.wifi)
07-05 15:17:03.218+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 1
07-05 15:17:03.218+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 880
07-05 15:17:03.238+0600 E/RESOURCED(  689): block.c: block_prelaunch_state(138) > insert data org.example.wifi, table num : 2
07-05 15:17:03.238+0600 E/RESOURCED(  689): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
07-05 15:17:03.238+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
07-05 15:17:03.238+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
07-05 15:17:03.238+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.wifi has already loaded
07-05 15:17:03.238+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
07-05 15:17:03.238+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
07-05 15:17:03.238+0600 W/AUL_PAD ( 1455): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
07-05 15:17:03.238+0600 W/AUL_PAD ( 1455): launchpad.c: __send_result_to_caller(267) > Check app launching
07-05 15:17:03.258+0600 I/CAPI_APPFW_APPLICATION( 2746): app_main.c: ui_app_main(789) > app_efl_main
07-05 15:17:03.258+0600 I/CAPI_APPFW_APPLICATION( 2746): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
07-05 15:17:03.278+0600 E/TBM     ( 2746): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
07-05 15:17:03.338+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 2746, appid: org.example.wifi
07-05 15:17:03.338+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
07-05 15:17:03.348+0600 E/CAPI_NETWORK_WIFI( 2746): net_wifi.c: wifi_deactivate(148) > Not initialized
07-05 15:17:03.348+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:17:03.348+0600 W/AUL     (  880): launch.c: app_request_to_launchpad(425) > request cmd(1) result(2746)
07-05 15:17:03.388+0600 E/RESOURCED(  689): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.wifi
07-05 15:17:03.569+0600 I/CAPI_NETWORK_WIFI( 2746): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
07-05 15:17:03.569+0600 D/wifi    ( 2746): [wifi_initialize] Success.
07-05 15:17:03.609+0600 I/APP_CORE( 2746): appcore-efl.c: __do_app(520) > [APP 2746] Event: RESET State: CREATED
07-05 15:17:03.609+0600 I/CAPI_APPFW_APPLICATION( 2746): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
07-05 15:17:03.609+0600 E/EFL     ( 2746): edje<2746> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
07-05 15:17:03.609+0600 E/EFL     ( 2746): By the power of Grayskull, your previous Embryo stack is now broken!
07-05 15:17:03.619+0600 E/EFL     ( 2746): edje<2746> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
07-05 15:17:03.619+0600 E/EFL     ( 2746): By the power of Grayskull, your previous Embryo stack is now broken!
07-05 15:17:03.619+0600 E/EFL     ( 2746): edje<2746> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
07-05 15:17:03.619+0600 E/EFL     ( 2746): By the power of Grayskull, your previous Embryo stack is now broken!
07-05 15:17:03.659+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:17:03.659+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:17:03.709+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76b9b00), gem(21), surface(0xb76e38d0)
07-05 15:17:03.719+0600 I/Tizen::System( 1472): (259) > Active app [org.exampl], current [com.samsun] 
07-05 15:17:03.719+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:17:03.729+0600 W/APP_CORE( 2746): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00002
07-05 15:17:03.729+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:17:03.729+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
07-05 15:17:03.799+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76db010), gem(14), surface(0xb76d10f0)
07-05 15:17:03.799+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76b9b00), gem(21), surface(0xb76fd7f0)
07-05 15:17:03.799+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76db010), gem(14), surface(0xb76e9230)
07-05 15:17:03.809+0600 I/APP_CORE(  880): appcore-efl.c: __do_app(520) > [APP 880] Event: PAUSE State: RUNNING
07-05 15:17:03.809+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
07-05 15:17:03.809+0600 E/cluster-home(  880): homescreen.cpp: OnPause(260) >  app pause
07-05 15:17:03.809+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(880) status(4)
07-05 15:17:03.809+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(880)
07-05 15:17:03.809+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 880, appid: com.samsung.homescreen, status: bg
07-05 15:17:03.819+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(2746) status(3)
07-05 15:17:03.819+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.wifi(2746)
07-05 15:17:03.819+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 2746, appid: org.example.wifi, status: fg
07-05 15:17:03.839+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:17:03.839+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __provider_pause_cb(304) > widget obj was paused
07-05 15:17:03.839+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __check_status_for_cgroup(152) > enter background group
07-05 15:17:03.839+0600 W/AUL     ( 1343): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1343, appid: com.samsung.weather-m-widget, status: bg
07-05 15:17:03.879+0600 I/APP_CORE( 2746): appcore-efl.c: __do_app(520) > [APP 2746] Event: RESUME State: CREATED
07-05 15:17:03.889+0600 I/APP_CORE( 2746): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
07-05 15:17:03.889+0600 I/APP_CORE( 2746): appcore-efl.c: __do_app(637) > [APP 2746] Initial Launching, call the resume_cb
07-05 15:17:03.889+0600 I/CAPI_APPFW_APPLICATION( 2746): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
07-05 15:17:03.889+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76d45b0), gem(12), surface(0xb76e38d0)
07-05 15:17:04.159+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(2746) status(0)
07-05 15:17:04.159+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:17:04.169+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76d6828), gem(12), surface(0xb76dd808)
07-05 15:17:04.369+0600 E/RESOURCED(  689): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.271
07-05 15:17:04.379+0600 I/Tizen::App( 1472): (499) > LaunchedApp(org.example.wifi)
07-05 15:17:04.379+0600 I/Tizen::App( 1472): (733) > Finished invoking application event listener for org.example.wifi, 2746.
07-05 15:17:05.140+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:17:05.150+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:17:05.150+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:17:05.150+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:17:05.150+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:17:05.150+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:17:05.150+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:17:05.240+0600 I/UXT     ( 2988): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
07-05 15:17:06.031+0600 E/EFL     ( 2746): ecore_x<2746> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=265898
07-05 15:17:06.111+0600 E/EFL     ( 2746): ecore_x<2746> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=265959
07-05 15:17:06.111+0600 E/VCONF   ( 2746): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
07-05 15:17:06.111+0600 E/VCONF   ( 2746): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
07-05 15:17:06.111+0600 E/VCONF   ( 2746): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
07-05 15:17:06.111+0600 E/VCONF   ( 2746): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2746) : db/ise/keysound error
07-05 15:17:06.121+0600 E/VCONF   ( 2746): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
07-05 15:17:06.121+0600 E/VCONF   ( 2746): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
07-05 15:17:06.171+0600 D/wifi    ( 2746): Succeeded to get Wi-Fi device state.
07-05 15:17:06.181+0600 E/EFL     ( 2746): <2746> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
07-05 15:17:07.032+0600 E/EFL     ( 2746): <2746> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
07-05 15:17:07.032+0600 I/Tizen::Net::Wifi( 1472): (941) > The background scan result updated.
07-05 15:17:07.082+0600 I/CAPI_NETWORK_WIFI( 2746): libnetwork.c: __libnet_update_profile_iterator(230) > Wi-Fi profile count: 7
07-05 15:17:07.082+0600 D/wifi    ( 2746): AP name : BaBu, state : Connected
07-05 15:17:07.092+0600 D/wifi    ( 2746): AP name : NextGen, state : Disconnected
07-05 15:17:07.232+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:17:07.262+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(880) status(3)
07-05 15:17:07.262+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
07-05 15:17:07.262+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
07-05 15:17:07.262+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(880)
07-05 15:17:07.262+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 880, appid: com.samsung.homescreen, status: fg
07-05 15:17:07.262+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:17:07.282+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76e9a48), gem(12), surface(0xb76c9480)
07-05 15:17:07.282+0600 I/AUL_PAD ( 1455): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2746 pgid = 2746
07-05 15:17:07.282+0600 I/AUL_PAD ( 1455): sigchild.h: __sigchild_action(143) > dead_pid(2746)
07-05 15:17:07.292+0600 I/MALI    (  880): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
07-05 15:17:07.302+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7683748), gem(21), surface(0xb76e7f40)
07-05 15:17:07.342+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76edfd0), gem(14), surface(0xb76fe270)
07-05 15:17:07.342+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76edfd0), gem(14), surface(0xb76f6ba0)
07-05 15:17:07.352+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:17:07.352+0600 I/APP_CORE(  880): appcore-efl.c: __do_app(520) > [APP 880] Event: RESUME State: PAUSED
07-05 15:17:07.352+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
07-05 15:17:07.352+0600 E/cluster-home(  880): homescreen.cpp: OnResume(233) >  app resume
07-05 15:17:07.382+0600 E/weather-widget( 1343): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
07-05 15:17:07.382+0600 I/AUL_PAD ( 1455): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
07-05 15:17:07.382+0600 I/AUL_PAD ( 1455): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
07-05 15:17:07.382+0600 E/AUL_PAD ( 1455): launchpad.c: main(698) > error reading sigchld info
07-05 15:17:07.382+0600 I/ESD     (  934): esd_main.c: __esd_app_dead_handler(1773) > pid: 2746
07-05 15:17:07.392+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2746
07-05 15:17:07.392+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2746
07-05 15:17:07.402+0600 E/RESOURCED(  689): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.274
07-05 15:17:07.432+0600 I/Tizen::System( 1472): (259) > Active app [com.samsun], current [org.exampl] 
07-05 15:17:07.432+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:17:07.432+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76e9a48), gem(12), surface(0xb76764e0)
07-05 15:17:07.442+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:17:07.442+0600 I/Tizen::App( 1472): (243) > App[org.example.wifi] pid[2746] terminate event is forwarded
07-05 15:17:07.442+0600 I/Tizen::System( 1472): (256) > osp.accessorymanager.service provider is found.
07-05 15:17:07.452+0600 I/Tizen::System( 1472): (196) > Accessory Owner is removed [org.example.wifi, 2746, ]
07-05 15:17:07.452+0600 I/Tizen::System( 1472): (256) > osp.system.service provider is found.
07-05 15:17:07.452+0600 I/Tizen::App( 1472): (506) > TerminatedApp(org.example.wifi)
07-05 15:17:07.452+0600 I/Tizen::App( 1472): (512) > Not registered pid(2746)
07-05 15:17:07.452+0600 I/Tizen::System( 1472): (246) > Terminated app [org.example.wifi]
07-05 15:17:07.452+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:17:07.462+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:17:07.462+0600 I/Tizen::App( 1472): (782) > Finished invoking application event listener for org.example.wifi, 2746.
07-05 15:17:07.462+0600 E/weather-widget( 1343): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
07-05 15:17:07.502+0600 E/weather-common( 1343): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
07-05 15:17:07.552+0600 W/CRASH_MANAGER( 3003): worker.c: worker_job(1199) > 1102746776966146771022
