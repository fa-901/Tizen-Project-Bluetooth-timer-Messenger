S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: bluetooth
PID: 28419
Date: 2016-08-01 01:29:01+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/bluetooth
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 28419, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00006f03
r2   = 0x00000006, r3   = 0xb45264c0
r4   = 0x00000002, r5   = 0xb4526000
r6   = 0xb682b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb6a73300
ip   = 0x00000000, sp   = 0xbec2ff34
lr   = 0xb6721f18, pc   = 0xb6720b84
cpsr = 0x200d0010

Memory Information
MemTotal:   730440 KB
MemFree:    152004 KB
Buffers:     21612 KB
Cached:     169656 KB
VmPeak:     108820 KB
VmSize:     108816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25952 KB
VmRSS:       25952 KB
VmData:      35772 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36092 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 28419 TID = 28419
28419 28423 29210 

Maps Information
b1dc9000 b25c8000 rw-p [stack:29210]
b25c8000 b25d9000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e9000 b25ee000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b267a000 b2682000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2693000 b2694000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b26a4000 b26b8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26cc000 b26cd000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26dd000 b26e0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26f1000 b26f2000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2702000 b2704000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2714000 b2716000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2726000 b2736000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2746000 b2752000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b29a2000 b29e0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b29f1000 b29f8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2a09000 b2a3e000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b2a51000 b2a57000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a67000 b2a74000 r-xp /opt/usr/apps/org.example.bluetooth/bin/bluetooth
b2b95000 b2c78000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2caf000 b2cd7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ce9000 b34e8000 rw-p [stack:28423]
b34e8000 b34ea000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b34fa000 b3504000 r-xp /lib/libnss_files-2.20-2014.11.so
b3515000 b351e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b352f000 b3540000 r-xp /lib/libnsl-2.20-2014.11.so
b3553000 b3559000 r-xp /lib/libnss_compat-2.20-2014.11.so
b356a000 b356b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3593000 b359a000 r-xp /usr/lib/libminizip.so.1.0.0
b35aa000 b35af000 r-xp /usr/lib/libstorage.so.0.1
b35bf000 b3614000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b362a000 b363e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b364e000 b3692000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b36a2000 b36aa000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36ba000 b36ea000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b36fd000 b37b6000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37ca000 b381e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b382f000 b384a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b385a000 b391b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b392e000 b3940000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3950000 b3954000 r-xp /usr/lib/libogg.so.0.7.1
b3964000 b3986000 r-xp /usr/lib/libvorbis.so.0.4.3
b3996000 b3a7a000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a96000 b3aa3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3ab4000 b3af7000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b0c000 b3b53000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b64000 b3b6a000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b7b000 b3b82000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b92000 b3bd2000 r-xp /usr/lib/libmdm.so.1.2.10
b3be2000 b3bea000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3bf9000 b3c09000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c2a000 b3c8a000 r-xp /usr/lib/libasound.so.2.0.0
b3c9c000 b3cd2000 r-xp /usr/lib/libpulse.so.0.16.2
b3ce3000 b3ce6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cf6000 b3cf9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d09000 b3d0e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d1e000 b3d1f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d2f000 b3d3a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d4e000 b3d55000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d65000 b3d6b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d7b000 b3d80000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d90000 b3dab000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dbb000 b3dc2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3dd2000 b3dd5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3de6000 b3e14000 r-xp /usr/lib/libidn.so.11.5.44
b3e24000 b3e3a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e4b000 b3e55000 r-xp /usr/lib/libcares.so.2.1.0
b3e65000 b3e6f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e7f000 b3e81000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e91000 b3e92000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3ea2000 b3ea6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3eb7000 b3edf000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ef0000 b3f19000 r-xp /usr/lib/libturbojpeg.so
b3f39000 b3f3f000 r-xp /usr/lib/libgif.so.4.1.6
b3f4f000 b3f95000 r-xp /usr/lib/libcurl.so.4.3.0
b3fa6000 b3fc7000 r-xp /usr/lib/libexif.so.12.3.3
b3fe2000 b3ff7000 r-xp /usr/lib/libtts.so
b4008000 b4010000 r-xp /usr/lib/libfeedback.so.0.1.4
b4020000 b40e0000 r-xp /usr/lib/libdali-core.so.0.0.0
b40eb000 b41de000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b41fe000 b42d8000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42ef000 b42f1000 r-xp /usr/lib/libboost_system.so.1.51.0
b4301000 b4307000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4317000 b433a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b434b000 b434d000 r-xp /usr/lib/libappsvc.so.0.1.0
b435d000 b435f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4370000 b4375000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b438c000 b438e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b439e000 b43a5000 r-xp /usr/lib/libsensord-share.so
b43b5000 b43cd000 r-xp /usr/lib/libsensor.so.1.1.0
b43de000 b43e1000 r-xp /usr/lib/libXv.so.1.0.0
b43f1000 b43f6000 r-xp /usr/lib/libutilX.so.1.1.0
b4406000 b440b000 r-xp /usr/lib/libappcore-common.so.1.1
b441b000 b4422000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b4435000 b4439000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b444a000 b4514000 r-xp /usr/lib/libCOREGL.so.4.0
b452b000 b452e000 r-xp /usr/lib/libuuid.so.1.3.0
b453f000 b4556000 r-xp /usr/lib/libblkid.so.1.1.0
b4567000 b4569000 r-xp /usr/lib/libXau.so.6.0.0
b4579000 b457c000 r-xp /usr/lib/libEGL.so.1.4
b4584000 b458a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b459a000 b459c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45ad000 b45bb000 r-xp /usr/lib/libGLESv2.so.2.0
b45c4000 b4626000 r-xp /usr/lib/libpixman-1.so.0.28.2
b463b000 b4653000 r-xp /usr/lib/libmount.so.1.1.0
b4664000 b4678000 r-xp /usr/lib/libxcb.so.1.1.0
b4689000 b4690000 r-xp /lib/libcrypt-2.20-2014.11.so
b46c8000 b46d9000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46ea000 b46ec000 r-xp /usr/lib/libiri.so
b46fc000 b4707000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4718000 b472d000 r-xp /lib/libexpat.so.1.5.2
b473f000 b47fd000 r-xp /usr/lib/libcairo.so.2.11200.14
b4810000 b4818000 r-xp /usr/lib/libdrm.so.2.4.0
b4828000 b482b000 r-xp /usr/lib/libdri2.so.0.0.0
b483c000 b488a000 r-xp /usr/lib/libssl.so.1.0.0
b489f000 b48ab000 r-xp /usr/lib/libeeze.so.1.13.0
b48bb000 b48c4000 r-xp /usr/lib/libethumb.so.1.13.0
b48d4000 b48d7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48e7000 b4a9e000 r-xp /usr/lib/libcrypto.so.1.0.0
b56f5000 b56fe000 r-xp /usr/lib/libXi.so.6.1.0
b570e000 b5710000 r-xp /usr/lib/libXgesture.so.7.0.0
b5720000 b5724000 r-xp /usr/lib/libXtst.so.6.1.0
b5734000 b573a000 r-xp /usr/lib/libXrender.so.1.3.0
b574a000 b5750000 r-xp /usr/lib/libXrandr.so.2.2.0
b5761000 b5763000 r-xp /usr/lib/libXinerama.so.1.0.0
b5773000 b5776000 r-xp /usr/lib/libXfixes.so.3.1.0
b5786000 b5791000 r-xp /usr/lib/libXext.so.6.4.0
b57a1000 b57a3000 r-xp /usr/lib/libXdamage.so.1.1.0
b57b3000 b57b5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57c6000 b58a8000 r-xp /usr/lib/libX11.so.6.3.0
b58bb000 b58c2000 r-xp /usr/lib/libXcursor.so.1.0.2
b58d2000 b58ea000 r-xp /usr/lib/libudev.so.1.6.0
b58ec000 b58ef000 r-xp /lib/libattr.so.1.1.0
b58ff000 b591f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5921000 b5926000 r-xp /usr/lib/libffi.so.6.0.2
b5936000 b594e000 r-xp /lib/libz.so.1.2.8
b595e000 b5960000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5970000 b5a45000 r-xp /usr/lib/libxml2.so.2.9.2
b5a5a000 b5af5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b11000 b5b14000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b24000 b5b3d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b4e000 b5b5f000 r-xp /lib/libresolv-2.20-2014.11.so
b5b73000 b5bed000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5c02000 b5c04000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c14000 b5c1b000 r-xp /usr/lib/libembryo.so.1.13.0
b5c2b000 b5c43000 r-xp /usr/lib/libpng12.so.0.50.0
b5c54000 b5c77000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c98000 b5cac000 r-xp /usr/lib/libector.so.1.13.0
b5cbd000 b5cd5000 r-xp /usr/lib/liblua-5.1.so
b5ce6000 b5d3d000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d51000 b5d79000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d8a000 b5d9d000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dae000 b5de5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df6000 b5e04000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e14000 b5e1c000 r-xp /usr/lib/libtbm.so.1.0.0
b5e2c000 b5e39000 r-xp /usr/lib/libeio.so.1.13.0
b5e49000 b5e4b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e5b000 b5e60000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e70000 b5e87000 r-xp /usr/lib/libefreet.so.1.13.0
b5e99000 b5eb9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec9000 b5ee9000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eeb000 b5ef1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f01000 b5f12000 r-xp /usr/lib/libemotion.so.1.13.0
b5f23000 b5f2a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f3a000 b5f49000 r-xp /usr/lib/libeo.so.1.13.0
b5f5a000 b5f6c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7d000 b5f82000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f92000 b5fab000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fbb000 b5fd8000 r-xp /usr/lib/libeet.so.1.13.0
b5ff1000 b6039000 r-xp /usr/lib/libeina.so.1.13.0
b604a000 b605a000 r-xp /usr/lib/libefl.so.1.13.0
b606b000 b6150000 r-xp /usr/lib/libicuuc.so.51.1
b616d000 b62ad000 r-xp /usr/lib/libicui18n.so.51.1
b62c4000 b62fc000 r-xp /usr/lib/libecore_x.so.1.13.0
b630e000 b6311000 r-xp /lib/libcap.so.2.21
b6321000 b634a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b635b000 b6362000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6374000 b63ab000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63bc000 b64a7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64ba000 b6533000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6545000 b654a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b655a000 b6564000 r-xp /usr/lib/libvconf.so.0.2.45
b6574000 b6576000 r-xp /usr/lib/libvasum.so.0.3.1
b6586000 b6588000 r-xp /usr/lib/libttrace.so.1.1
b6598000 b659b000 r-xp /usr/lib/libiniparser.so.0
b65ab000 b65d1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e1000 b65e6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f7000 b660e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661f000 b668a000 r-xp /lib/libm-2.20-2014.11.so
b669b000 b66a1000 r-xp /lib/librt-2.20-2014.11.so
b66b2000 b66bf000 r-xp /usr/lib/libunwind.so.8.0.1
b66f5000 b6819000 r-xp /lib/libc-2.20-2014.11.so
b682e000 b6847000 r-xp /lib/libgcc_s-4.9.so.1
b6857000 b6939000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b694a000 b6974000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6985000 b69c1000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c3000 b6a45000 r-xp /usr/lib/libedje.so.1.13.0
b6a58000 b6a76000 r-xp /usr/lib/libecore.so.1.13.0
b6a96000 b6c1d000 r-xp /usr/lib/libevas.so.1.13.0
b6c52000 b6c66000 r-xp /lib/libpthread-2.20-2014.11.so
b6c7a000 b6eaf000 r-xp /usr/lib/libelementary.so.1.13.0
b6edd000 b6ee1000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef1000 b6ef8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f08000 b6f0a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1a000 b6f1d000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2d000 b6f2f000 r-xp /lib/libdl-2.20-2014.11.so
b6f40000 b6f58000 r-xp /usr/lib/libaul.so.0.1.0
b6f6c000 b6f71000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f82000 b6f8f000 r-xp /usr/lib/liblptcp.so
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fb6000 b6fd6000 r-xp /lib/ld-2.20-2014.11.so
b6fe7000 b6fec000 r-xp /usr/bin/launchpad-loader
b7e15000 b817d000 rw-p [heap]
bec10000 bec31000 rw-p [stack]
bec10000 bec31000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28419)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6720b84) [/lib/libc.so.6] + 0x2bb84
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
398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 E/IME_LITE(  673): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:26:13.281+0600 W/IME_LITE(  673): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:26:13.281+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:26:13.341+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:13.341+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:13.401+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:13.401+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:13.582+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:13.582+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:13.992+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6047928
08-01 01:26:14.002+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6047947
08-01 01:26:14.012+0600 I/IME_LITE(  673): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
08-01 01:26:14.012+0600 I/ISE_MULTI(  789): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
08-01 01:26:14.012+0600 I/IME_LITE(  673): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
08-01 01:26:14.012+0600 I/IME_LITE(  673): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
08-01 01:26:14.082+0600 W/ISF_PANEL_EFL(  709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6800002 FAILED!
08-01 01:26:14.142+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8f0ec40), gem(17), surface(0xb8f00178)
08-01 01:26:14.152+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8db5518), gem(22), surface(0xb8f1d648)
08-01 01:26:14.182+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8eeac60), gem(16), surface(0xb8eeb1d0)
08-01 01:26:14.422+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.422+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.483+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.483+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.543+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.543+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.663+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.663+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.903+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.903+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.963+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:14.963+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.203+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.203+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.263+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.263+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.323+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.323+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.443+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.443+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.564+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:15.564+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:18.396+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6052333
08-01 01:26:18.767+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6052708
08-01 01:26:19.097+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6053044
08-01 01:26:19.357+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6053303
08-01 01:26:22.681+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6056621
08-01 01:26:22.871+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6056802
08-01 01:26:23.361+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6057299
08-01 01:26:23.621+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6057559
08-01 01:26:24.272+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6058208
08-01 01:26:24.422+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6058359
08-01 01:26:25.253+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6059190
08-01 01:26:25.683+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6059623
08-01 01:26:27.796+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:27.796+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:28.646+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6062596
08-01 01:26:28.746+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6062689
08-01 01:26:29.958+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:29.958+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:30.468+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6064408
08-01 01:26:30.828+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6064774
08-01 01:26:31.259+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6065197
08-01 01:26:31.559+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6065498
08-01 01:26:31.900+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6065844
08-01 01:26:32.150+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6066092
08-01 01:26:32.820+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6066762
08-01 01:26:33.231+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6067173
08-01 01:26:33.691+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6067637
08-01 01:26:33.962+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6067907
08-01 01:26:41.279+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6075219
08-01 01:26:41.469+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6075411
08-01 01:26:42.150+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6076093
08-01 01:26:42.280+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6076219
08-01 01:26:43.511+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6077447
08-01 01:26:43.571+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6077509
08-01 01:26:45.443+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:45.443+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:45.793+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6079728
08-01 01:26:45.863+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6079800
08-01 01:26:45.923+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:45.923+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:45.983+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:45.983+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.043+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.043+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.103+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.103+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.163+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.163+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.404+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.404+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.554+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6080495
08-01 01:26:46.584+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.584+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.644+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.644+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.664+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6080599
08-01 01:26:46.824+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.824+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.884+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:46.884+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:47.004+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:47.004+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:47.064+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:47.064+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.075+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.075+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.135+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.145+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.316+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.316+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.736+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.736+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.796+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:48.796+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:51.859+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:51.859+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:51.919+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:51.919+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:52.400+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:52.400+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:53.000+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:53.000+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:53.180+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:53.180+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:53.300+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:53.300+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:54.201+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:54.201+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:55.703+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:55.703+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:56.063+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6090005
08-01 01:26:56.123+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6090066
08-01 01:26:56.484+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:56.484+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:26:58.105+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6092057
08-01 01:26:58.185+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6092128
08-01 01:27:00.307+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(195) > ""
08-01 01:27:00.307+0600 E/UXT     (  644): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 1:27 a.m.
08-01 01:27:00.307+0600 I/INDICATOR(  644): clock.c: getTimeFormatted(176) > "time format : 1:27 a.m."
08-01 01:27:00.307+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(244) > "time format : 1:27 a.m."
08-01 01:27:00.307+0600 W/INDICATOR(  644): clock.c: indicator_clock_changed_cb(272) > 
08-01 01:27:00.307+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146543097 Time: <font_size=31> </font_size> <font_size=31> 1:27 a.m.</font_size></font>"
08-01 01:27:03.500+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.500+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.681+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.681+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.741+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.741+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.741+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6097686
08-01 01:27:03.771+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6097716
08-01 01:27:03.981+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:03.981+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:05.823+0600 D/bluetooth(28419): Socket fd: 48
08-01 01:27:05.823+0600 D/bluetooth(28419): Data: Sending test message
08-01 01:27:05.823+0600 D/bluetooth(28419): Size: 21
08-01 01:27:07.754+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6101693
08-01 01:27:08.085+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6102025
08-01 01:27:08.085+0600 E/EFL     (28419): edje<28419> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
08-01 01:27:08.085+0600 E/EFL     (28419): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:27:08.615+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6102555
08-01 01:27:08.896+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6102836
08-01 01:27:09.376+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6103324
08-01 01:27:10.637+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6104587
08-01 01:27:11.308+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6105248
08-01 01:27:11.568+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6105516
08-01 01:27:12.219+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6106155
08-01 01:27:12.469+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6106413
08-01 01:27:13.140+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6107083
08-01 01:27:13.480+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6107418
08-01 01:27:14.151+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6108088
08-01 01:27:14.351+0600 E/EFL     (28419): ecore_x<28419> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6108292
08-01 01:27:14.962+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:14.962+0600 I/CAPI_APPFW_APPLICATION(11696): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
08-01 01:27:25.832+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:27:25.832+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:27:25.832+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:27:25.832+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): rssi.c: show_sim_ds_image_icon(226) > Skip duplicative showing !
08-01 01:27:25.842+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:27:25.842+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:00.336+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(195) > ""
08-01 01:28:00.336+0600 E/UXT     (  644): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 1:28 a.m.
08-01 01:28:00.336+0600 I/INDICATOR(  644): clock.c: getTimeFormatted(176) > "time format : 1:28 a.m."
08-01 01:28:00.336+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(244) > "time format : 1:28 a.m."
08-01 01:28:00.336+0600 W/INDICATOR(  644): clock.c: indicator_clock_changed_cb(272) > 
08-01 01:28:00.336+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146521551 Time: <font_size=31> </font_size> <font_size=31> 1:28 a.m.</font_size></font>"
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): rssi.c: show_sim_ds_image_icon(226) > Skip duplicative showing !
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:03.669+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:39.924+0600 W/LOCKSCREEN(  832): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 23
08-01 01:28:39.924+0600 W/LOCKSCREEN(  832): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:40000:CONF_CHANGED
08-01 01:28:39.924+0600 W/LOCKSCREEN(  832): daemon.c: _event_route(839) > [_event_route:839:W] event:40000 event_info:200
08-01 01:28:39.924+0600 W/LOCKSCREEN(  832): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
08-01 01:28:39.934+0600 E/INDICATOR(  644): battery.c: show_digits(405) > show_digits[405]	 "Show digits: 23"
08-01 01:28:39.934+0600 I/INDICATOR(  644): battery.c: show_battery_icon(376) > "Percentage:(1) / Level:(2) / batt_Full:(0) / battery_charging(1)"
08-01 01:28:39.934+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:28:39.934+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:39.934+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:39.934+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:39.934+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:39.934+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:39.934+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): rssi.c: show_sim_ds_image_icon(226) > Skip duplicative showing !
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:28:41.506+0600 E/INDICATOR(  644): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:29:00.364+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(195) > ""
08-01 01:29:00.364+0600 E/UXT     (  644): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 1:29 a.m.
08-01 01:29:00.364+0600 I/INDICATOR(  644): clock.c: getTimeFormatted(176) > "time format : 1:29 a.m."
08-01 01:29:00.364+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(244) > "time format : 1:29 a.m."
08-01 01:29:00.364+0600 W/INDICATOR(  644): clock.c: indicator_clock_changed_cb(272) > 
08-01 01:29:00.364+0600 I/INDICATOR(  644): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146452332 Time: <font_size=31> </font_size> <font_size=31> 1:29 a.m.</font_size></font>"
08-01 01:29:01.025+0600 E/PKGMGR_SERVER(30297): pkgmgr-server.c: main(2414) > package manager server start
08-01 01:29:01.095+0600 E/PKGMGR_SERVER(30297): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth] is null
08-01 01:29:01.095+0600 E/PKGMGR  (30294): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.bluetooth, -1]
08-01 01:29:01.145+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 14
08-01 01:29:01.145+0600 W/AUL_AMD (  597): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 28419
08-01 01:29:01.145+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 12
08-01 01:29:01.145+0600 W/AUL     (30301): launch.c: app_request_to_launchpad(396) > request cmd(5) to(28419)
08-01 01:29:01.145+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 5
08-01 01:29:01.145+0600 W/AUL_AMD (  597): amd_launch.c: __reply_handler(1102) > listen fd(26) , send fd(25), pid(28419), cmd(4)
08-01 01:29:01.145+0600 W/AUL     (30301): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 14
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 28419
08-01 01:29:01.155+0600 I/APP_CORE(28419): appcore-efl.c: __do_app(520) > [APP 28419] Event: TERMINATE State: RUNNING
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(1207) > app status : 5
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(1207) > app status : 5
08-01 01:29:01.155+0600 I/TIZEN_N_EFL_UTIL_WINDOW(28419): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 1
08-01 01:29:01.155+0600 E/APP_CORE(28419): appcore-efl.c: _capture_and_make_file(1631) > win[6800002] widget[480] height[800]
08-01 01:29:01.155+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 33
08-01 01:29:01.155+0600 E/APP_CORE(28419): appcore-efl.c: _capture_and_make_file(1634) > cannot a capture file for the package of [org.example.bluetooth]
08-01 01:29:01.155+0600 I/CAPI_APPFW_APPLICATION(28419): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-01 01:29:01.155+0600 I/CAPI_APPFW_APPLICATION(28419): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
08-01 01:29:01.155+0600 E/CAPI_NETWORK_BLUETOOTH(28419): bluetooth-opp-client.c: bt_opp_client_deinitialize(117) > [bt_opp_client_deinitialize] NOT_INITIALIZED(0xfe400101)
08-01 01:29:01.245+0600 E/CAPI_NETWORK_BLUETOOTH(28419): bluetooth-gatt.c: bt_gatt_client_destroy(2254) > [bt_gatt_client_destroy] INVALID_PARAMETER(0xffffffea)
08-01 01:29:01.245+0600 E/CAPI_NETWORK_BLUETOOTH(28419): bluetooth-adapter.c: bt_adapter_le_destroy_advertiser(1210) > [bt_adapter_le_destroy_advertiser] INVALID_PARAMETER(0xffffffea)
08-01 01:29:01.245+0600 E/bluetooth(28419): [bt_adapter_le_destroy_advertiser] Failed.
08-01 01:29:01.245+0600 E/EFL     (  321): eo<321> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:29:01.255+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 14
08-01 01:29:01.255+0600 W/AUL_AMD (  597): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
08-01 01:29:01.285+0600 E/PKGMGR_SERVER(30297): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.bluetooth] fail
08-01 01:29:01.285+0600 E/PKGMGR_SERVER(30297): pkgmgr-server.c: sighandler(417) > child NORMAL exit [30301]
08-01 01:29:01.285+0600 W/AUL_AMD (  597): amd_launch.c: __e17_status_handler(3367) > pid(841) status(3)
08-01 01:29:01.285+0600 W/AUL_AMD (  597): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:29:01.285+0600 W/AUL_AMD (  597): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 01:29:01.285+0600 W/AUL     (  597): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(841)
08-01 01:29:01.285+0600 W/AUL     (  597): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 841, appid: com.samsung.homescreen, status: fg
08-01 01:29:01.305+0600 E/AUL     (  597): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 01:29:01.315+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8e1eb30), gem(16), surface(0xb8ee7710)
08-01 01:29:01.325+0600 I/MALI    (  841): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:29:01.335+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8f03f50), gem(18), surface(0xb8f00178)
08-01 01:29:01.345+0600 E/EFL     (28419): ecore<28419> lib/ecore/ecore_main.c:1552 _ecore_main_fd_handlers_bads_rem() Removing bad fds
08-01 01:29:01.345+0600 E/EFL     (28419): ecore<28419> lib/ecore/ecore_main.c:1561 _ecore_main_fd_handlers_bads_rem() Found bad fd at index 23
08-01 01:29:01.345+0600 E/EFL     (28419): ecore<28419> lib/ecore/ecore_main.c:1564 _ecore_main_fd_handlers_bads_rem() Fd set for error! calling user
08-01 01:29:01.375+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8eeac60), gem(17), surface(0xb8eeb1d0)
08-01 01:29:01.375+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb8eeac60), gem(17), surface(0xb8e3f648)
08-01 01:29:01.395+0600 I/APP_CORE(  841): appcore-efl.c: __do_app(520) > [APP 841] Event: RESUME State: PAUSED
08-01 01:29:01.395+0600 I/CAPI_APPFW_APPLICATION(  841): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-01 01:29:01.395+0600 E/cluster-home(  841): homescreen.cpp: OnResume(233) >  app resume
08-01 01:29:01.405+0600 E/EFL     (  321): eo<321> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:29:01.435+0600 E/weather-widget( 1024): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
08-01 01:29:01.475+0600 E/weather-widget( 1024): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
08-01 01:29:01.485+0600 I/Tizen::System( 1353): (259) > Active app [com.samsun], current [org.exampl] 
08-01 01:29:01.485+0600 I/Tizen::Io( 1353): (729) > Entry not found
08-01 01:29:01.485+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8e1eb30), gem(16), surface(0xb8eeb1d0)
08-01 01:29:01.495+0600 I/Tizen::System( 1353): (157) > change brightness system value.
08-01 01:29:01.525+0600 I/TIZEN_N_SOUND_MANAGER(27859): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=4, ret=0x0
08-01 01:29:01.525+0600 E/TIZEN_N_SOUND_MANAGER(27859): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:29:01.536+0600 I/TIZEN_N_SOUND_MANAGER(27859): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=8, ret=0x0
08-01 01:29:01.536+0600 E/TIZEN_N_SOUND_MANAGER(27859): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:29:01.536+0600 W/AUL_AMD (  597): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 01:29:01.536+0600 E/weather-common( 1024): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
08-01 01:29:01.656+0600 I/MALI    (  321): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb8eb6108), gem(18), surface(0xb8f00178)
08-01 01:29:01.666+0600 I/CAPI_NETWORK_CONNECTION( 1024): connection.c: connection_create(409) > New handle created[0xb80d9df0]
08-01 01:29:01.676+0600 I/CAPI_NETWORK_CONNECTION( 1024): connection.c: connection_get_type(463) > Connected Network = 0
08-01 01:29:01.676+0600 E/weather-common( 1024): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
08-01 01:29:01.676+0600 E/weather-common( 1024): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
08-01 01:29:01.676+0600 I/CAPI_NETWORK_CONNECTION( 1024): connection.c: connection_destroy(427) > Destroy handle: 0xb80d9df0
08-01 01:29:01.676+0600 E/weather-common( 1024): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
08-01 01:29:01.676+0600 E/weather-widget( 1024): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
08-01 01:29:01.676+0600 E/weather-widget( 1024): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
08-01 01:29:01.676+0600 I/CAPI_WIDGET_APPLICATION( 1024): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
08-01 01:29:01.676+0600 I/CAPI_WIDGET_APPLICATION( 1024): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
08-01 01:29:01.676+0600 W/AUL     ( 1024): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1024, appid: com.samsung.weather-m-widget, status: fg
08-01 01:29:01.756+0600 I/AUL_PAD ( 1427): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 28419 pgid = 28419
08-01 01:29:01.756+0600 I/AUL_PAD ( 1427): sigchild.h: __sigchild_action(143) > dead_pid(28419)
08-01 01:29:01.786+0600 I/MALI    (  841): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:29:01.796+0600 I/MALI    (  841): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:29:01.806+0600 I/MALI    (  841): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:29:01.866+0600 I/AUL_PAD ( 1427): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 01:29:01.866+0600 I/AUL_PAD ( 1427): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 01:29:01.866+0600 E/AUL_PAD ( 1427): launchpad.c: main(698) > error reading sigchld info
08-01 01:29:01.866+0600 I/Tizen::App( 1353): (243) > App[org.example.bluetooth] pid[28419] terminate event is forwarded
08-01 01:29:01.866+0600 I/Tizen::System( 1353): (256) > osp.accessorymanager.service provider is found.
08-01 01:29:01.866+0600 I/Tizen::System( 1353): (196) > Accessory Owner is removed [org.example.bluetooth, 28419, ]
08-01 01:29:01.866+0600 I/Tizen::System( 1353): (256) > osp.system.service provider is found.
08-01 01:29:01.866+0600 I/Tizen::App( 1353): (506) > TerminatedApp(org.example.bluetooth)
08-01 01:29:01.866+0600 I/Tizen::App( 1353): (512) > Not registered pid(28419)
08-01 01:29:01.866+0600 I/Tizen::System( 1353): (246) > Terminated app [org.example.bluetooth]
08-01 01:29:01.866+0600 I/Tizen::Io( 1353): (729) > Entry not found
08-01 01:29:01.866+0600 I/ESD     (  907): esd_main.c: __esd_app_dead_handler(1773) > pid: 28419
08-01 01:29:01.866+0600 W/AUL_AMD (  597): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 28419
08-01 01:29:01.876+0600 E/RESOURCED(  650): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.797
08-01 01:29:01.886+0600 E/RESOURCED(  650): datausage-common.c: app_terminated_cb(678) > No classid to terminate!
08-01 01:29:01.886+0600 I/Tizen::System( 1353): (157) > change brightness system value.
08-01 01:29:01.886+0600 I/Tizen::App( 1353): (782) > Finished invoking application event listener for org.example.bluetooth, 28419.
08-01 01:29:01.916+0600 W/CRASH_MANAGER(30308): worker.c: worker_job(1199) > 0628419626c75146999334
