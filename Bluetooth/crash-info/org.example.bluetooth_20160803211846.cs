S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: bluetooth
PID: 15642
Date: 2016-08-03 21:18:46+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/bluetooth
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15642, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb7a319e0
r2   = 0x84e88d00, r3   = 0x00000000
r4   = 0xb773bc38, r5   = 0xb6a3d0f4
r6   = 0xb6a3c310, r7   = 0xbe816430
r8   = 0xb6a3d0f4, r9   = 0xb6a3d0f4
r10  = 0xb6a4b20c, fp   = 0x00000000
ip   = 0xb67206f1, sp   = 0xbe816400
lr   = 0xb2a27237, pc   = 0xb67206f0
cpsr = 0x60060030

Memory Information
MemTotal:   730440 KB
MemFree:    115196 KB
Buffers:     22452 KB
Cached:     133948 KB
VmPeak:      96720 KB
VmSize:      94272 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24888 KB
VmRSS:       24888 KB
VmData:      25872 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36092 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15642 TID = 15642
15642 15693 16292 

Maps Information
b1d7f000 b257e000 rw-p [stack:16292]
b257e000 b258f000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b259f000 b25a4000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2630000 b2638000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2649000 b264a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b265a000 b266e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2682000 b2683000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2693000 b2696000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26a7000 b26a8000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26b8000 b26ba000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26ca000 b26cc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26dc000 b26ec000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26fc000 b2708000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2958000 b2996000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29a7000 b29ae000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29bf000 b29f4000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a07000 b2a0d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a1d000 b2a2a000 r-xp /opt/usr/apps/org.example.bluetooth/bin/bluetooth
b2b4b000 b2c2e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c65000 b2c8d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c9f000 b349e000 rw-p [stack:15693]
b349e000 b34a0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34b0000 b34ba000 r-xp /lib/libnss_files-2.20-2014.11.so
b34cb000 b34d4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34e5000 b34f6000 r-xp /lib/libnsl-2.20-2014.11.so
b3509000 b350f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3520000 b3521000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3549000 b3550000 r-xp /usr/lib/libminizip.so.1.0.0
b3560000 b3565000 r-xp /usr/lib/libstorage.so.0.1
b3575000 b35ca000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35e0000 b35f4000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3604000 b3648000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3658000 b3660000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3670000 b36a0000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36b3000 b376c000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3780000 b37d4000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37e5000 b3800000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3810000 b38d1000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38e4000 b38f6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3906000 b390a000 r-xp /usr/lib/libogg.so.0.7.1
b391a000 b393c000 r-xp /usr/lib/libvorbis.so.0.4.3
b394c000 b3a30000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a4c000 b3a59000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a6a000 b3aad000 r-xp /usr/lib/libsndfile.so.1.0.25
b3ac2000 b3b09000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b1a000 b3b20000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b31000 b3b38000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b48000 b3b88000 r-xp /usr/lib/libmdm.so.1.2.10
b3b98000 b3ba0000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3baf000 b3bbf000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3be0000 b3c40000 r-xp /usr/lib/libasound.so.2.0.0
b3c52000 b3c88000 r-xp /usr/lib/libpulse.so.0.16.2
b3c99000 b3c9c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cac000 b3caf000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3cbf000 b3cc4000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cd4000 b3cd5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3ce5000 b3cf0000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d04000 b3d0b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d1b000 b3d21000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d31000 b3d36000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d46000 b3d61000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d71000 b3d78000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d88000 b3d8b000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d9c000 b3dca000 r-xp /usr/lib/libidn.so.11.5.44
b3dda000 b3df0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e01000 b3e0b000 r-xp /usr/lib/libcares.so.2.1.0
b3e1b000 b3e25000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e35000 b3e37000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e47000 b3e48000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e58000 b3e5c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e6d000 b3e95000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ea6000 b3ecf000 r-xp /usr/lib/libturbojpeg.so
b3eef000 b3ef5000 r-xp /usr/lib/libgif.so.4.1.6
b3f05000 b3f4b000 r-xp /usr/lib/libcurl.so.4.3.0
b3f5c000 b3f7d000 r-xp /usr/lib/libexif.so.12.3.3
b3f98000 b3fad000 r-xp /usr/lib/libtts.so
b3fbe000 b3fc6000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fd6000 b4096000 r-xp /usr/lib/libdali-core.so.0.0.0
b40a1000 b4194000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41b4000 b428e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42a5000 b42a7000 r-xp /usr/lib/libboost_system.so.1.51.0
b42b7000 b42bd000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42cd000 b42f0000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4301000 b4303000 r-xp /usr/lib/libappsvc.so.0.1.0
b4313000 b4315000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4326000 b432b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4342000 b4344000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4354000 b435b000 r-xp /usr/lib/libsensord-share.so
b436b000 b4383000 r-xp /usr/lib/libsensor.so.1.1.0
b4394000 b4397000 r-xp /usr/lib/libXv.so.1.0.0
b43a7000 b43ac000 r-xp /usr/lib/libutilX.so.1.1.0
b43bc000 b43c1000 r-xp /usr/lib/libappcore-common.so.1.1
b43d1000 b43d8000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43eb000 b43ef000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4400000 b44ca000 r-xp /usr/lib/libCOREGL.so.4.0
b44e1000 b44e4000 r-xp /usr/lib/libuuid.so.1.3.0
b44f5000 b450c000 r-xp /usr/lib/libblkid.so.1.1.0
b451d000 b451f000 r-xp /usr/lib/libXau.so.6.0.0
b452f000 b4532000 r-xp /usr/lib/libEGL.so.1.4
b453a000 b4540000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4550000 b4552000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4563000 b4571000 r-xp /usr/lib/libGLESv2.so.2.0
b457a000 b45dc000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45f1000 b4609000 r-xp /usr/lib/libmount.so.1.1.0
b461a000 b462e000 r-xp /usr/lib/libxcb.so.1.1.0
b463f000 b4646000 r-xp /lib/libcrypt-2.20-2014.11.so
b467e000 b468f000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46a0000 b46a2000 r-xp /usr/lib/libiri.so
b46b2000 b46bd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46ce000 b46e3000 r-xp /lib/libexpat.so.1.5.2
b46f5000 b47b3000 r-xp /usr/lib/libcairo.so.2.11200.14
b47c6000 b47ce000 r-xp /usr/lib/libdrm.so.2.4.0
b47de000 b47e1000 r-xp /usr/lib/libdri2.so.0.0.0
b47f2000 b4840000 r-xp /usr/lib/libssl.so.1.0.0
b4855000 b4861000 r-xp /usr/lib/libeeze.so.1.13.0
b4871000 b487a000 r-xp /usr/lib/libethumb.so.1.13.0
b488a000 b488d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b489d000 b4a54000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ab000 b56b4000 r-xp /usr/lib/libXi.so.6.1.0
b56c4000 b56c6000 r-xp /usr/lib/libXgesture.so.7.0.0
b56d6000 b56da000 r-xp /usr/lib/libXtst.so.6.1.0
b56ea000 b56f0000 r-xp /usr/lib/libXrender.so.1.3.0
b5700000 b5706000 r-xp /usr/lib/libXrandr.so.2.2.0
b5717000 b5719000 r-xp /usr/lib/libXinerama.so.1.0.0
b5729000 b572c000 r-xp /usr/lib/libXfixes.so.3.1.0
b573c000 b5747000 r-xp /usr/lib/libXext.so.6.4.0
b5757000 b5759000 r-xp /usr/lib/libXdamage.so.1.1.0
b5769000 b576b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b577c000 b585e000 r-xp /usr/lib/libX11.so.6.3.0
b5871000 b5878000 r-xp /usr/lib/libXcursor.so.1.0.2
b5888000 b58a0000 r-xp /usr/lib/libudev.so.1.6.0
b58a2000 b58a5000 r-xp /lib/libattr.so.1.1.0
b58b5000 b58d5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d7000 b58dc000 r-xp /usr/lib/libffi.so.6.0.2
b58ec000 b5904000 r-xp /lib/libz.so.1.2.8
b5914000 b5916000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5926000 b59fb000 r-xp /usr/lib/libxml2.so.2.9.2
b5a10000 b5aab000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac7000 b5aca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ada000 b5af3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b04000 b5b15000 r-xp /lib/libresolv-2.20-2014.11.so
b5b29000 b5ba3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb8000 b5bba000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bca000 b5bd1000 r-xp /usr/lib/libembryo.so.1.13.0
b5be1000 b5bf9000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0a000 b5c2d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c4e000 b5c62000 r-xp /usr/lib/libector.so.1.13.0
b5c73000 b5c8b000 r-xp /usr/lib/liblua-5.1.so
b5c9c000 b5cf3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d07000 b5d2f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d40000 b5d53000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d64000 b5d9b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dac000 b5dba000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dca000 b5dd2000 r-xp /usr/lib/libtbm.so.1.0.0
b5de2000 b5def000 r-xp /usr/lib/libeio.so.1.13.0
b5dff000 b5e01000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e11000 b5e16000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e26000 b5e3d000 r-xp /usr/lib/libefreet.so.1.13.0
b5e4f000 b5e6f000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e7f000 b5e9f000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea1000 b5ea7000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eb7000 b5ec8000 r-xp /usr/lib/libemotion.so.1.13.0
b5ed9000 b5ee0000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef0000 b5eff000 r-xp /usr/lib/libeo.so.1.13.0
b5f10000 b5f22000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f33000 b5f38000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f48000 b5f61000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f71000 b5f8e000 r-xp /usr/lib/libeet.so.1.13.0
b5fa7000 b5fef000 r-xp /usr/lib/libeina.so.1.13.0
b6000000 b6010000 r-xp /usr/lib/libefl.so.1.13.0
b6021000 b6106000 r-xp /usr/lib/libicuuc.so.51.1
b6123000 b6263000 r-xp /usr/lib/libicui18n.so.51.1
b627a000 b62b2000 r-xp /usr/lib/libecore_x.so.1.13.0
b62c4000 b62c7000 r-xp /lib/libcap.so.2.21
b62d7000 b6300000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6311000 b6318000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b632a000 b6361000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6372000 b645d000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6470000 b64e9000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64fb000 b6500000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6510000 b651a000 r-xp /usr/lib/libvconf.so.0.2.45
b652a000 b652c000 r-xp /usr/lib/libvasum.so.0.3.1
b653c000 b653e000 r-xp /usr/lib/libttrace.so.1.1
b654e000 b6551000 r-xp /usr/lib/libiniparser.so.0
b6561000 b6587000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6597000 b659c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ad000 b65c4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65d5000 b6640000 r-xp /lib/libm-2.20-2014.11.so
b6651000 b6657000 r-xp /lib/librt-2.20-2014.11.so
b6668000 b6675000 r-xp /usr/lib/libunwind.so.8.0.1
b66ab000 b67cf000 r-xp /lib/libc-2.20-2014.11.so
b67e4000 b67fd000 r-xp /lib/libgcc_s-4.9.so.1
b680d000 b68ef000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6900000 b692a000 r-xp /usr/lib/libdbus-1.so.3.8.12
b693b000 b6977000 r-xp /usr/lib/libsystemd.so.0.4.0
b6979000 b69fb000 r-xp /usr/lib/libedje.so.1.13.0
b6a0e000 b6a2c000 r-xp /usr/lib/libecore.so.1.13.0
b6a4c000 b6bd3000 r-xp /usr/lib/libevas.so.1.13.0
b6c08000 b6c1c000 r-xp /lib/libpthread-2.20-2014.11.so
b6c30000 b6e65000 r-xp /usr/lib/libelementary.so.1.13.0
b6e93000 b6e97000 r-xp /usr/lib/libsmack.so.1.0.0
b6ea7000 b6eae000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ebe000 b6ec0000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed0000 b6ed3000 r-xp /usr/lib/libbundle.so.0.1.22
b6ee3000 b6ee5000 r-xp /lib/libdl-2.20-2014.11.so
b6ef6000 b6f0e000 r-xp /usr/lib/libaul.so.0.1.0
b6f22000 b6f27000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f38000 b6f45000 r-xp /usr/lib/liblptcp.so
b6f57000 b6f5b000 r-xp /usr/lib/libsys-assert.so
b6f6c000 b6f8c000 r-xp /lib/ld-2.20-2014.11.so
b6f9d000 b6fa2000 r-xp /usr/bin/launchpad-loader
b76fa000 b7a86000 rw-p [heap]
be7f6000 be817000 rw-p [stack]
be7f6000 be817000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15642)
Call Stack Count: 1
 0: (0xb67206f0) [/lib/libc.so.6] + 0x756f0
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
 updating signal
08-03 21:17:55.295+0600 E/EFL     (17625): edje<17625> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
08-03 21:17:55.355+0600 E/EFL     (17625): evas_main<17625> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80014f04 is not stable during recalc loop
08-03 21:17:55.375+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 22
08-03 21:17:55.375+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(1207) > app status : 5
08-03 21:17:55.375+0600 I/AUL_PAD ( 1427): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14980 pgid = 14980
08-03 21:17:55.375+0600 I/AUL_PAD ( 1427): sigchild.h: __sigchild_action(143) > dead_pid(14980)
08-03 21:17:55.375+0600 E/weather-agent(15623): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
08-03 21:17:55.406+0600 I/AUL_PAD ( 1427): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-03 21:17:55.406+0600 I/AUL_PAD ( 1427): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-03 21:17:55.406+0600 E/AUL_PAD ( 1427): launchpad.c: main(698) > error reading sigchld info
08-03 21:17:55.406+0600 I/Tizen::App( 1353): (243) > App[org.tizen.system-syspopup] pid[14980] terminate event is forwarded
08-03 21:17:55.406+0600 I/Tizen::System( 1353): (256) > osp.accessorymanager.service provider is found.
08-03 21:17:55.406+0600 I/Tizen::System( 1353): (196) > Accessory Owner is removed [org.tizen.system-syspopup, 14980, ]
08-03 21:17:55.406+0600 I/Tizen::System( 1353): (256) > osp.system.service provider is found.
08-03 21:17:55.406+0600 I/Tizen::App( 1353): (506) > TerminatedApp(org.tizen.system-syspopup)
08-03 21:17:55.406+0600 I/Tizen::App( 1353): (512) > Not registered pid(14980)
08-03 21:17:55.406+0600 I/Tizen::System( 1353): (246) > Terminated app [org.tizen.system-syspopup]
08-03 21:17:55.406+0600 I/Tizen::Io( 1353): (729) > Entry not found
08-03 21:17:55.406+0600 I/ESD     (  907): esd_main.c: __esd_app_dead_handler(1773) > pid: 14980
08-03 21:17:55.406+0600 W/AUL_AMD (  597): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14980
08-03 21:17:55.406+0600 W/AUL_AMD (  597): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14980
08-03 21:17:55.416+0600 E/RESOURCED(  650): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.5701
08-03 21:17:55.416+0600 I/Tizen::System( 1353): (157) > change brightness system value.
08-03 21:17:55.416+0600 I/Tizen::App( 1353): (782) > Finished invoking application event listener for org.tizen.system-syspopup, 14980.
08-03 21:17:55.506+0600 E/EFL     (17625): evas_main<17625> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80014f04 is not stable during recalc loop
08-03 21:17:55.516+0600 E/EFL     (17625): edje<17625> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/LDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
08-03 21:17:55.526+0600 E/cluster-home(17627): cluster-data-list.cpp: GetDBoxID(1000) >  found id[3]
08-03 21:17:55.546+0600 I/Tizen::Net::Wifi( 1353): (1085) > _WifiService is not registered.
08-03 21:17:55.566+0600 E/INDICATOR(  644): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
08-03 21:17:55.596+0600 W/AUL_AMD (  597): amd_request.c: __send_app_termination_signal(613) > send dead signal done
08-03 21:17:55.606+0600 I/Tizen::App( 1353): (243) > App[com.samsung.weather-m-agent] pid[15623] terminate event is forwarded
08-03 21:17:55.606+0600 I/Tizen::System( 1353): (256) > osp.accessorymanager.service provider is found.
08-03 21:17:55.606+0600 I/Tizen::System( 1353): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 15623, ]
08-03 21:17:55.606+0600 I/Tizen::System( 1353): (256) > osp.system.service provider is found.
08-03 21:17:55.606+0600 I/Tizen::App( 1353): (506) > TerminatedApp(com.samsung.weather-m-agent)
08-03 21:17:55.606+0600 I/Tizen::App( 1353): (512) > Not registered pid(15623)
08-03 21:17:55.606+0600 I/Tizen::System( 1353): (246) > Terminated app [com.samsung.weather-m-agent]
08-03 21:17:55.606+0600 I/Tizen::Io( 1353): (729) > Entry not found
08-03 21:17:55.606+0600 I/ESD     (  907): esd_main.c: __esd_app_dead_handler(1773) > pid: 15623
08-03 21:17:55.606+0600 W/AUL_AMD (  597): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15623
08-03 21:17:55.616+0600 E/RESOURCED(  650): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
08-03 21:17:55.626+0600 I/Tizen::System( 1353): (157) > change brightness system value.
08-03 21:17:55.626+0600 I/Tizen::App( 1353): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 15623.
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.066+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:17:56.276+0600 I/UXT     (15642): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
08-03 21:17:56.817+0600 I/APP_CORE(17627): appcore-efl.c: __do_app(520) > [APP 17627] Event: MEM_FLUSH State: PAUSED
08-03 21:17:58.138+0600 E/VCONF   (15662): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
08-03 21:17:59.379+0600 E/VOLUME  (  960): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-03 21:17:59.379+0600 E/VOLUME  (  960): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
08-03 21:17:59.399+0600 E/cluster-home(17627): homescreen.cpp: OnPause(260) >  app pause
08-03 21:17:59.409+0600 W/LOCKSCREEN(13459): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
08-03 21:17:59.409+0600 W/LOCKSCREEN(13459): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
08-03 21:17:59.409+0600 W/LOCKSCREEN(13459): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30000:LCD_WILL_OFF
08-03 21:17:59.409+0600 W/LOCKSCREEN(13459): daemon.c: _event_route(839) > [_event_route:839:W] event:30000 event_info:2b432f0
08-03 21:17:59.409+0600 W/LOCKSCREEN(13459): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:5
08-03 21:17:59.409+0600 W/LOCKSCREEN(13459): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => WILL PAUSE
08-03 21:17:59.419+0600 W/APP_CORE(13459): appcore-efl.c: __cmsg_cb(1050) > LCD Off. Pause the topmost app
08-03 21:17:59.419+0600 I/APP_CORE(13459): appcore-efl.c: __do_app(520) > [APP 13459] Event: PAUSE State: RUNNING
08-03 21:17:59.419+0600 I/CAPI_APPFW_APPLICATION(13459): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-03 21:17:59.419+0600 E/LOCKSCREEN(13459): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
08-03 21:17:59.419+0600 E/LOCKSCREEN(13459): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
08-03 21:17:59.419+0600 W/LOCKSCREEN(13459): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:20002:APP_PAUSE
08-03 21:17:59.419+0600 W/LOCKSCREEN(13459): daemon.c: _event_route(839) > [_event_route:839:W] event:20002 event_info:0
08-03 21:17:59.419+0600 W/LOCKSCREEN(13459): daemon.c: _lcd_timeout_timer_unset(734) > [_lcd_timeout_timer_unset:734:W] lcd off timer unset
08-03 21:17:59.419+0600 E/LOCKSCREEN(13459): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
08-03 21:17:59.840+0600 W/AUL_AMD (  597): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-03 21:17:59.970+0600 E/VOLUME  (  960): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-03 21:17:59.970+0600 E/VOLUME  (  960): volume_control.c: volume_control_close(837) > [volume_control_close:837] Failed to unregister x input event handler
08-03 21:17:59.980+0600 E/cluster-home(17627): homescreen.cpp: OnPause(260) >  app pause
08-03 21:17:59.990+0600 E/LOCKSCREEN(13459): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
08-03 21:17:59.990+0600 E/LOCKSCREEN(13459): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
08-03 21:17:59.990+0600 E/LOCKSCREEN(13459): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
08-03 21:17:59.990+0600 W/LOCKSCREEN(13459): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
08-03 21:17:59.990+0600 W/LOCKSCREEN(13459): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
08-03 21:18:00.020+0600 W/LOCKSCREEN(13459): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
08-03 21:18:00.020+0600 W/LOCKSCREEN(13459): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
08-03 21:18:00.020+0600 W/LOCKSCREEN(13459): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:30002:LCD_OFF
08-03 21:18:00.020+0600 W/LOCKSCREEN(13459): daemon.c: _event_route(839) > [_event_route:839:W] event:30002 event_info:0
08-03 21:18:00.020+0600 W/LOCKSCREEN(13459): daemon.c: _state_transit(447) > [_state_transit:447:W] state transit:6
08-03 21:18:00.020+0600 W/LOCKSCREEN(13459): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
08-03 21:18:00.040+0600 I/APP_CORE(  644): appcore-efl.c: __do_app(520) > [APP 644] Event: MEM_FLUSH State: PAUSED
08-03 21:18:00.380+0600 W/AUL_AMD (  597): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-03 21:18:04.414+0600 I/APP_CORE(13459): appcore-efl.c: __do_app(520) > [APP 13459] Event: MEM_FLUSH State: PAUSED
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:16.096+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:20.510+0600 E/PKGMGR_SERVER(15911): pkgmgr-server.c: main(2414) > package manager server start
08-03 21:18:20.570+0600 E/PKGMGR_SERVER(15911): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth] is null
08-03 21:18:20.580+0600 E/PKGMGR  (15909): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
08-03 21:18:20.620+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 14
08-03 21:18:20.620+0600 W/AUL_AMD (  597): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
08-03 21:18:20.650+0600 E/PKGMGR_SERVER(15911): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth] fail
08-03 21:18:20.650+0600 E/PKGMGR_SERVER(15911): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15914]
08-03 21:18:22.972+0600 E/PKGMGR_SERVER(15911): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-03 21:18:22.972+0600 E/PKGMGR_SERVER(15911): pkgmgr-server.c: main(2471) > package manager server terminated.
08-03 21:18:28.688+0600 E/PKGMGR  (16057): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
08-03 21:18:28.788+0600 E/PKGMGR_SERVER(16060): pkgmgr-server.c: main(2414) > package manager server start
08-03 21:18:28.848+0600 E/PKGMGR_SERVER(16060): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.bluetooth]
08-03 21:18:28.858+0600 E/PKGMGR_SERVER(16060): pm-mdm.c: _get_package_info_from_file(115) > [0;31m[_get_package_info_from_file(): 115](ret < 0) access() failed. path: org.example.bluetooth errno: 2 (No such file or directory)[0;m
08-03 21:18:28.858+0600 E/PKGMGR_SERVER(16060): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth] is null
08-03 21:18:28.858+0600 E/PKGMGR  (16057): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[160570002]
08-03 21:18:28.968+0600 E/rpm-installer(16064): rpm-appcore-intf.c: main(104) > ------------------------------------------------
08-03 21:18:28.968+0600 E/rpm-installer(16064): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
08-03 21:18:28.968+0600 E/rpm-installer(16064): rpm-appcore-intf.c: main(106) > ------------------------------------------------
08-03 21:18:29.108+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.108+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.108+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.108+0600 W/AUL_AMD (  597): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
08-03 21:18:29.118+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.118+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.118+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.339+0600 W/CERT_SVC_VCORE(16064): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
08-03 21:18:29.389+0600 E/rpm-installer(16064): coretpk-parser.c: _coretpk_parser_get_manifest_info(1377) > (doc == NULL) xmlParseFile() failed.
08-03 21:18:29.389+0600 E/rpm-installer(16064): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
08-03 21:18:29.489+0600 E/PKGMGR_PARSER(16064): pkgmgr_parser.c: __check_theme(158) > theme for uninstallation.
08-03 21:18:29.509+0600 I/PRIVACY-MANAGER-CLIENT(16064): SocketClient.cpp: SocketClient(37) > Client created
08-03 21:18:29.509+0600 I/PRIVACY-MANAGER-CLIENT(16064): SocketClient.cpp: connect(62) > Client connected
08-03 21:18:29.519+0600 I/PRIVACY-MANAGER-SERVER(  925): SocketService.cpp: mainloop(257) > Got incoming connection
08-03 21:18:29.529+0600 I/PRIVACY-MANAGER-CLIENT(16064): SocketClient.cpp: disconnect(72) > Client disconnected
08-03 21:18:29.539+0600 E/PKGMGR_CERT(16064): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
08-03 21:18:29.549+0600 E/PKGMGR_CERT(16064): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
08-03 21:18:29.569+0600 E/PKGMGR_CERT(16064): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
08-03 21:18:29.579+0600 E/ALARM_MANAGER(  637): alarm-manager.c: __get_zone_name(506) > zone name [/]
08-03 21:18:29.579+0600 W/ALARM_MANAGER(  637): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/16070/status successfully
08-03 21:18:29.579+0600 W/ALARM_MANAGER(  637): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
08-03 21:18:29.579+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 15
08-03 21:18:29.579+0600 E/PKGMGR_INFO(  597): pkgmgrinfo_private.c: __db_busy_handler(250) > __db_busy_handler(count=0) is called. pid=[597]
08-03 21:18:29.609+0600 E/PKGMGR_INFO(  597): pkgmgrinfo_private.c: __db_busy_handler(250) > __db_busy_handler(count=1) is called. pid=[597]
08-03 21:18:29.619+0600 E/rpm-installer(16064): coretpk-installer.c: _coretpk_installer_package_reinstall(6348) > _coretpk_installer_package_reinstall(org.example.bluetooth) failed.
08-03 21:18:29.629+0600 E/ESD     (  907): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
08-03 21:18:29.639+0600 W/ISF_PANEL_EFL(  709): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.bluetooth",~) returned -1
08-03 21:18:29.649+0600 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
08-03 21:18:29.649+0600 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 3-8-2016, 15:28:01 (UTC).
08-03 21:18:29.649+0600 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
08-03 21:18:29.649+0600 W/AUL_AMD (  597): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
08-03 21:18:29.659+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.659+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.659+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:29.669+0600 W/ISF_PANEL_EFL(  709): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
08-03 21:18:29.749+0600 I/CAPI_NETWORK_WIFI(16070): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
08-03 21:18:29.749+0600 I/CAPI_NETWORK_WIFI(16070): libnetwork.c: _wifi_set_power_on_off_cb(1666) > Wi-Fi registered device state changed callback
08-03 21:18:29.779+0600 I/CAPI_NETWORK_WIFI(16070): libnetwork.c: __libnet_update_profile_iterator(230) > Wi-Fi profile count: 3
08-03 21:18:29.779+0600 I/CAPI_NETWORK_WIFI(16070): net_wifi.c: wifi_get_connected_ap(273) > Connected AP 0xb77c44e8, rv 0
08-03 21:18:29.819+0600 I/CAPI_CONTENT_MEDIA_CONTENT(16070): media_content.c: media_content_connect(856) > [32m[16070]ref count : 0
08-03 21:18:29.829+0600 I/CAPI_CONTENT_MEDIA_CONTENT(16070): media_content.c: media_content_connect(888) > [32m[16070]ref count changed to: 1
08-03 21:18:30.450+0600 E/rpm-installer(16064): rpm-appcore-intf.c: main(260) > ------------------------------------------------
08-03 21:18:30.450+0600 E/rpm-installer(16064): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
08-03 21:18:30.450+0600 E/rpm-installer(16064): rpm-appcore-intf.c: main(262) > ------------------------------------------------
08-03 21:18:30.460+0600 E/PKGMGR_SERVER(16060): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth] fail
08-03 21:18:30.460+0600 E/PKGMGR_SERVER(16060): pkgmgr-server.c: sighandler(417) > child NORMAL exit [16064]
08-03 21:18:30.980+0600 E/PKGMGR_SERVER(16060): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-03 21:18:30.980+0600 E/PKGMGR_SERVER(16060): pkgmgr-server.c: main(2471) > package manager server terminated.
08-03 21:18:34.424+0600 W/LOCKSCREEN(13459): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 10
08-03 21:18:34.424+0600 W/LOCKSCREEN(13459): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-03 21:18:34.424+0600 W/LOCKSCREEN(13459): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-03 21:18:34.424+0600 W/LOCKSCREEN(13459): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-03 21:18:34.434+0600 E/INDICATOR(  644): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
08-03 21:18:36.045+0600 E/PKGMGR  (16171): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.065+0600 E/RESOURCED(  650): datausage-common.c: finalize_counter(1411) > There is no iptables_rule handler
08-03 21:18:36.145+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: main(2414) > package manager server start
08-03 21:18:36.195+0600 E/PKGMGR_SERVER(16173): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk]
08-03 21:18:36.205+0600 E/PKGMGR_INFO(16173): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] not found in DB
08-03 21:18:36.215+0600 E/BACKEND_LIB(16173): librpm.c: __installer_util_delete_dir(179) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
08-03 21:18:36.225+0600 E/PKGMGR_SERVER(16173): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
08-03 21:18:36.225+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth-1.0.0-arm.tpk] is null
08-03 21:18:36.225+0600 E/PKGMGR  (16171): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[161710002]
08-03 21:18:36.305+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(104) > ------------------------------------------------
08-03 21:18:36.305+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(105) >  [START] rpm-installer: version=[20151006.1]
08-03 21:18:36.305+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(106) > ------------------------------------------------
08-03 21:18:36.365+0600 E/PKGMGR_INSTALLER(16177): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
08-03 21:18:36.365+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(191) > [/opt/usr/apps/tmp/org.example.bluetooth-1.0.0-arm.tpk] is tpk package.
08-03 21:18:36.385+0600 E/rpm-installer(16177): coretpk-parser.c: _coretpk_parser_is_svc_app(1225) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
08-03 21:18:36.385+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [install-location] is empty.
08-03 21:18:36.385+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
08-03 21:18:36.385+0600 E/rpm-installer(16177): coretpk-parser.c: _coretpk_parser_is_widget(1191) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
08-03 21:18:36.395+0600 E/rpm-installer(16177): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
08-03 21:18:36.456+0600 W/CERT_SVC_VCORE(16177): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
08-03 21:18:36.516+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:36.516+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:36.516+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:36.536+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:36.546+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:36.546+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:36.686+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_check_vip_tag(474) > (ret == 1) metadata(watchface) is empty.
08-03 21:18:36.686+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_get_value(1341) > (result_value == NULL) [ui-gadget] is empty.
08-03 21:18:36.686+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_get_dpi_type(778) > key for dpi is found, get the dpi.
08-03 21:18:36.686+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_get_dpi_type(787) > device dpi is [233]
08-03 21:18:36.696+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_append_path(343) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
08-03 21:18:36.696+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_is_theme(39) > (ret == 1) metadata(watchface) is empty.
08-03 21:18:36.696+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_allow_onboot(582) > (ret == 1) metadata is empty.
08-03 21:18:36.696+0600 E/rpm-installer(16177): coretpk-parser.c: __coretpk_parser_allow_autorestart(644) > (ret == 1) metadata is empty.
08-03 21:18:36.706+0600 E/PKGMGR_PARSER(16177): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2682) > Manifest is Valid
08-03 21:18:36.706+0600 E/PKGMGR_PARSER(16177): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
08-03 21:18:36.756+0600 I/PRIVACY-MANAGER-CLIENT(16177): SocketClient.cpp: SocketClient(37) > Client created
08-03 21:18:37.036+0600 E/PKGMGR_PARSER(16177): pkgmgr_parser.c: __check_theme(146) > theme for installation.
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 104
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 104
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 55 1
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 6
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 6
08-03 21:18:37.056+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 56 1
08-03 21:18:37.076+0600 E/PKGMGR_CERT(16177): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
08-03 21:18:37.086+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.086+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.086+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.086+0600 I/SHAREDRULE_CLIENT(  550): SharedruleClient.cpp: addSharedrule(154) > Enter
08-03 21:18:37.096+0600 I/SHAREDRULE_CLIENT(  550): SocketConnection.h: SocketConnection(47) > Created
08-03 21:18:37.096+0600 I/SHAREDRULE_SERVER(  542): SocketService.cpp: mainloop(234) > Got incoming connection
08-03 21:18:37.096+0600 I/SHAREDRULE_SERVER(  542): SocketConnection.h: SocketConnection(47) > Created
08-03 21:18:37.126+0600 I/SHAREDRULE_CLIENT(  550): SharedruleClient.cpp: addSharedrule(190) > return result : 0
08-03 21:18:37.126+0600 E/rpm-installer(16177): installer-util.c: _installer_util_get_configuration_value(566) > [signature]=[on]
08-03 21:18:37.156+0600 E/rpm-installer(16177): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
08-03 21:18:37.166+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.166+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.166+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.927+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
08-03 21:18:37.927+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
08-03 21:18:37.927+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
08-03 21:18:37.937+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.937+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.937+0600 E/PKGMGR  ( 9307): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
08-03 21:18:37.967+0600 W/ISF_PANEL_EFL(  709): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
08-03 21:18:37.977+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
08-03 21:18:38.027+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(260) > ------------------------------------------------
08-03 21:18:38.027+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(261) >  [END] installer: result=[0]
08-03 21:18:38.027+0600 E/rpm-installer(16177): rpm-appcore-intf.c: main(262) > ------------------------------------------------
08-03 21:18:38.027+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.bluetooth]
08-03 21:18:38.027+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.bluetooth]
08-03 21:18:38.027+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
08-03 21:18:38.027+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
08-03 21:18:38.027+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.bluetooth]
08-03 21:18:38.037+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth-1.0.0-arm.tpk] fail
08-03 21:18:38.037+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: sighandler(417) > child NORMAL exit [16177]
08-03 21:18:38.047+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[bluetooth] enable[1] system[0]
08-03 21:18:38.057+0600 E/HOME_APPS(17627): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.bluetooth] mdm is not enabled
08-03 21:18:38.057+0600 E/cluster-home(17627): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[bluetooth] enable[1] system[0]
08-03 21:18:38.057+0600 W/HOME_APPS(17627): mainmenu-box-impl.cpp: UpdateBoxData(1330) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.bluetooth/shared/res/bluetooth.png], New icon path[/opt/usr/apps/org.example.bluetooth/shared/res/bluetooth.png]!!!!!
08-03 21:18:38.077+0600 E/util-view(17627): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=22 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
08-03 21:18:39.979+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-03 21:18:39.979+0600 E/PKGMGR_SERVER(16173): pkgmgr-server.c: main(2471) > package manager server terminated.
08-03 21:18:43.643+0600 W/AUL     (16282): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.bluetooth)
08-03 21:18:43.643+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 0
08-03 21:18:43.653+0600 I/AUL     (  597): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
08-03 21:18:43.663+0600 I/AUL     (  597): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
08-03 21:18:43.663+0600 E/AUL_AMD (  597): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
08-03 21:18:43.663+0600 W/AUL_AMD (  597): amd_launch.c: _start_app(2527) > caller pid : 16282
08-03 21:18:43.663+0600 E/AUL_AMD (  597): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
08-03 21:18:43.673+0600 E/RESOURCED(  650): block.c: block_prelaunch_state(138) > insert data org.example.bluetooth, table num : 11
08-03 21:18:43.673+0600 E/RESOURCED(  650): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
08-03 21:18:43.673+0600 W/AUL_AMD (  597): amd_launch.c: _start_app(3074) > loading shared rule
08-03 21:18:43.673+0600 I/SHAREDRULE_CLIENT(  597): SharedruleClient.cpp: loadSharedrule(285) > Enter
08-03 21:18:43.673+0600 I/SHAREDRULE_CLIENT(  597): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for org.example.bluetooth has already loaded
08-03 21:18:43.673+0600 I/SHAREDRULE_CLIENT(  597): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
08-03 21:18:43.673+0600 W/AUL_AMD (  597): amd_launch.c: _start_app(3081) > pad pid(-5)
08-03 21:18:43.673+0600 W/AUL_PAD ( 1427): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
08-03 21:18:43.673+0600 W/AUL_PAD ( 1427): launchpad.c: __send_result_to_caller(267) > Check app launching
08-03 21:18:43.693+0600 I/CAPI_APPFW_APPLICATION(15642): app_main.c: ui_app_main(789) > app_efl_main
08-03 21:18:43.693+0600 I/CAPI_APPFW_APPLICATION(15642): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
08-03 21:18:43.723+0600 E/TBM     (15642): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
08-03 21:18:43.773+0600 W/AUL     (  597): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 15642, appid: org.example.bluetooth
08-03 21:18:43.773+0600 E/AUL     (  597): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
08-03 21:18:43.793+0600 W/AUL     (16282): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15642)
08-03 21:18:43.853+0600 E/RESOURCED(  650): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.bluetooth
08-03 21:18:44.143+0600 W/AUL     (15642): launch.c: app_request_to_launchpad(396) > request cmd(0) to(ug-bluetooth-efl)
08-03 21:18:44.143+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 0
08-03 21:18:44.143+0600 W/AUL_AMD (  597): amd_launch.c: _start_app(2527) > caller pid : 15642
08-03 21:18:44.143+0600 E/RESOURCED(  650): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
08-03 21:18:44.153+0600 W/AUL_AMD (  597): amd_launch.c: _start_app(3074) > loading shared rule
08-03 21:18:44.153+0600 I/SHAREDRULE_CLIENT(  597): SharedruleClient.cpp: loadSharedrule(285) > Enter
08-03 21:18:44.153+0600 I/SHAREDRULE_CLIENT(  597): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for ug-bluetooth-efl has already loaded
08-03 21:18:44.153+0600 I/SHAREDRULE_CLIENT(  597): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
08-03 21:18:44.153+0600 W/AUL_AMD (  597): amd_launch.c: _start_app(3081) > pad pid(-5)
08-03 21:18:44.804+0600 W/AUL_PAD ( 1427): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
08-03 21:18:44.804+0600 W/AUL_PAD ( 1427): launchpad.c: __send_result_to_caller(267) > Check app launching
08-03 21:18:44.824+0600 I/Tizen::App( 1353): (499) > LaunchedApp(org.example.bluetooth)
08-03 21:18:44.824+0600 I/Tizen::App( 1353): (733) > Finished invoking application event listener for org.example.bluetooth, 15642.
08-03 21:18:44.824+0600 E/RESOURCED(  650): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.5718
08-03 21:18:44.874+0600 W/UI_GADGET(11078): manager.c: ugman_send_event(1149) > [34mugman_send_event failed: no root[0m
08-03 21:18:44.874+0600 E/UI_GADGET_CLIENT(11078): ug-client.c: app_create(1114) > rotate : 0
08-03 21:18:44.874+0600 W/UI_GADGET(11078): manager.c: ugman_send_event(1149) > [34mugman_send_event failed: no root[0m
08-03 21:18:44.874+0600 I/APP_CORE(11078): appcore-efl.c: __do_app(520) > [APP 11078] Event: RESET State: CREATED
08-03 21:18:44.894+0600 E/UI_GADGET_CLIENT(11078): ug-client.c: _ug_client_set_split_window_prop(435) > error in get metadata from appinfo
08-03 21:18:44.904+0600 W/AUL     (  597): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 11078, appid: ug-bluetooth-efl
08-03 21:18:44.904+0600 E/AUL     (  597): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
08-03 21:18:44.904+0600 W/AUL     (15642): launch.c: app_request_to_launchpad(425) > request cmd(0) result(11078)
08-03 21:18:44.904+0600 D/bluetooth(15642): Succeeded to Bluetooth On/Off app!
08-03 21:18:44.914+0600 W/AUL_AMD (  597): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-03 21:18:44.914+0600 W/AUL_AMD (  597): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
08-03 21:18:44.914+0600 E/AUL     (  597): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-03 21:18:44.974+0600 E/RESOURCED(  650): proc-main.c: proc_add_program_list(237) > not found ppi : ug-bluetooth-efl
08-03 21:18:44.994+0600 W/UI_GADGET(11078): manager.c: ugman_ug_create(664) > [34mbefore ug(ug-bluetooth-efl) create cb[0m
08-03 21:18:45.014+0600 E/CAPI_NETWORK_BLUETOOTH(11078): bluetooth-common.c: bt_deinitialize(84) > [bt_deinitialize] NOT_INITIALIZED(0xfe400101)
08-03 21:18:45.184+0600 I/APP_CORE(15642): appcore-efl.c: __do_app(520) > [APP 15642] Event: RESET State: CREATED
08-03 21:18:45.184+0600 I/CAPI_APPFW_APPLICATION(15642): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
08-03 21:18:45.184+0600 E/EFL     (15642): edje<15642> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.184+0600 E/EFL     (15642): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.194+0600 E/EFL     (15642): edje<15642> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.194+0600 E/EFL     (15642): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.214+0600 E/EFL     (15642): edje<15642> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.214+0600 E/EFL     (15642): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.234+0600 W/APP_CORE(15642): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6600002
08-03 21:18:45.234+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 35
08-03 21:18:45.314+0600 I/GXT_SIB (11078): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
08-03 21:18:45.334+0600 W/UI_GADGET(11078): manager.c: ugman_ug_create(666) > [34mafter ug(ug-bluetooth-efl) create cb[0m
08-03 21:18:45.344+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8e69560), gem(29), surface(0xb8efde18)
08-03 21:18:45.354+0600 E/EFL     (11078): elementary<11078> elm_layout.c:638 _elm_layout_part_aliasing_eval() no default content part set for object 0x8000f47b -- part must not be NULL
08-03 21:18:45.354+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8f81140), gem(18), surface(0xb8e2c820)
08-03 21:18:45.354+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8e69560), gem(29), surface(0xb8f80ed8)
08-03 21:18:45.364+0600 W/UI_GADGET(11078): manager.c: ugman_tree_dump(185) > [34m============== TREE_DUMP =============[0m
08-03 21:18:45.364+0600 W/UI_GADGET(11078): manager.c: ugman_tree_dump(186) > [34mROOT: Manager(0xb7d922b8)[0m
08-03 21:18:45.364+0600 W/UI_GADGET(11078): manager.c: ugman_tree_dump(203) > [34m[1] ug-bluetooth-efl [F] (mem : b1cab000-b1cd9000) (ug : 0xb7d8e4a0) (PARENT:  Manager)[0m
08-03 21:18:45.364+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8f8b870), gem(20), surface(0xb8da9470)
08-03 21:18:45.384+0600 W/AUL_AMD (  597): amd_launch.c: __e17_status_handler(3367) > pid(15642) status(4)
08-03 21:18:45.384+0600 E/EFL     (11078): edje<11078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.384+0600 E/EFL     (11078): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.424+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8f54eb8), gem(24), surface(0xb8fad310)
08-03 21:18:45.444+0600 I/APP_CORE(15642): appcore-efl.c: __do_app(520) > [APP 15642] Event: PAUSE State: CREATED
08-03 21:18:45.444+0600 E/EFL     (11078): edje<11078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.444+0600 E/EFL     (11078): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.444+0600 E/EFL     (11078): edje<11078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.444+0600 E/EFL     (11078): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.444+0600 E/EFL     (11078): edje<11078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-03 21:18:45.444+0600 E/EFL     (11078): By the power of Grayskull, your previous Embryo stack is now broken!
08-03 21:18:45.444+0600 I/TIZEN_N_EFL_UTIL_WINDOW(15642): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 6
08-03 21:18:45.444+0600 E/APP_CORE(15642): appcore-efl.c: _capture_and_make_file(1631) > win[6600002] widget[480] height[800]
08-03 21:18:45.454+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 33
08-03 21:18:45.614+0600 I/MALI    (11078): tizen_buffer.c: tizen_dri2_get_buffers(701) > Allocated private data for surface(0xb7c43980)
08-03 21:18:45.625+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8f32f80), gem(35), surface(0xb8f4ff88)
08-03 21:18:45.635+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8f31d18), gem(36), surface(0xb8f8c280)
08-03 21:18:45.645+0600 I/MALI    (11078): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-03 21:18:45.645+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8f31d18), gem(36), surface(0xb8f80ed8)
08-03 21:18:45.655+0600 W/APP_CORE(11078): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7000003
08-03 21:18:45.655+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 35
08-03 21:18:45.655+0600 W/AUL_AMD (  597): amd_launch.c: __e17_status_handler(3367) > pid(11078) status(4)
08-03 21:18:45.665+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8f76cf0), gem(34), surface(0xb8efde18)
08-03 21:18:45.665+0600 I/APP_CORE(11078): appcore-efl.c: __do_app(520) > [APP 11078] Event: PAUSE State: CREATED
08-03 21:18:45.665+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 33
08-03 21:18:45.785+0600 I/CAPI_NETWORK_CONNECTION(11078): connection.c: connection_create(409) > New handle created[0xb7e31c40]
08-03 21:18:45.795+0600 E/CAPI_NETWORK_BLUETOOTH(11078): bluetooth-hid.c: bt_hid_host_initialize(74) > [bt_hid_host_initialize] NOT_SUPPORTED(0xc0000002)
08-03 21:18:45.795+0600 W/CAPI_APPFW_APP_CONTROL(11078): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
08-03 21:18:45.855+0600 W/AUL_AMD (  597): amd_launch.c: __e17_status_handler(3367) > pid(15642) status(0)
08-03 21:18:45.855+0600 E/AUL     (  597): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-03 21:18:45.905+0600 W/AUL_AMD (  597): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-03 21:18:45.905+0600 W/AUL_AMD (  597): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
08-03 21:18:45.975+0600 E/RESOURCED(  650): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.5721
08-03 21:18:45.985+0600 I/Tizen::App( 1353): (499) > LaunchedApp(ug-bluetooth-efl)
08-03 21:18:45.985+0600 I/Tizen::App( 1353): (733) > Finished invoking application event listener for ug-bluetooth-efl, 11078.
08-03 21:18:45.985+0600 E/EFL     (15642): <15642> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
08-03 21:18:45.985+0600 E/EFL     (15642): <15642> elm_main.c:1244 elm_object_part_text_set() safety check failed: obj == NULL
08-03 21:18:46.235+0600 I/AUL_PAD ( 1427): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15642 pgid = 15642
08-03 21:18:46.235+0600 I/AUL_PAD ( 1427): sigchild.h: __sigchild_action(143) > dead_pid(15642)
08-03 21:18:46.305+0600 I/AUL_PAD ( 1427): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-03 21:18:46.305+0600 I/AUL_PAD ( 1427): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-03 21:18:46.305+0600 E/AUL_PAD ( 1427): launchpad.c: main(698) > error reading sigchld info
08-03 21:18:46.305+0600 I/Tizen::App( 1353): (243) > App[org.example.bluetooth] pid[15642] terminate event is forwarded
08-03 21:18:46.305+0600 I/Tizen::System( 1353): (256) > osp.accessorymanager.service provider is found.
08-03 21:18:46.305+0600 I/Tizen::System( 1353): (196) > Accessory Owner is removed [org.example.bluetooth, 15642, ]
08-03 21:18:46.305+0600 I/Tizen::System( 1353): (256) > osp.system.service provider is found.
08-03 21:18:46.305+0600 I/Tizen::App( 1353): (506) > TerminatedApp(org.example.bluetooth)
08-03 21:18:46.305+0600 I/Tizen::App( 1353): (512) > Not registered pid(15642)
08-03 21:18:46.305+0600 I/Tizen::System( 1353): (246) > Terminated app [org.example.bluetooth]
08-03 21:18:46.305+0600 I/Tizen::Io( 1353): (729) > Entry not found
08-03 21:18:46.315+0600 I/ESD     (  907): esd_main.c: __esd_app_dead_handler(1773) > pid: 15642
08-03 21:18:46.315+0600 W/AUL_AMD (  597): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15642
08-03 21:18:46.315+0600 W/AUL_AMD (  597): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15642
08-03 21:18:46.325+0600 E/RESOURCED(  650): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.5723
08-03 21:18:46.335+0600 I/Tizen::System( 1353): (157) > change brightness system value.
08-03 21:18:46.335+0600 I/Tizen::App( 1353): (782) > Finished invoking application event listener for org.example.bluetooth, 15642.
08-03 21:18:46.385+0600 W/CRASH_MANAGER(16331): worker.c: worker_job(1199) > 1115642626c75147023752
