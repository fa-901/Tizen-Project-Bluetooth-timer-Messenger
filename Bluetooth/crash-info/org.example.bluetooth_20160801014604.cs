S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: bluetooth
PID: 8477
Date: 2016-08-01 01:46:04+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/bluetooth
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8477, uid 5000)

Register Information
r0   = 0x00000088, r1   = 0x00000025
r2   = 0x0000feff, r3   = 0x0000000b
r4   = 0xbedf67a0, r5   = 0x25252525
r6   = 0x00000000, r7   = 0x00000088
r8   = 0xb44c74c0, r9   = 0xbedf6848
r10  = 0xb67cb000, fp   = 0xbedf678c
ip   = 0x00000088, sp   = 0xbedf624c
lr   = 0xb66d31b4, pc   = 0xb670fe9c
cpsr = 0x60000010

Memory Information
MemTotal:   730440 KB
MemFree:     35544 KB
Buffers:     28732 KB
Cached:     265768 KB
VmPeak:     108656 KB
VmSize:     108652 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25912 KB
VmRSS:       25912 KB
VmData:      35504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36092 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8477 TID = 8477
8477 8483 9713 

Maps Information
b1d6a000 b2569000 rw-p [stack:9713]
b2569000 b257a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b258a000 b258f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b261b000 b2623000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2634000 b2635000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2645000 b2659000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b266d000 b266e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b267e000 b2681000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2692000 b2693000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26a3000 b26a5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26b5000 b26b7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26c7000 b26d7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26e7000 b26f3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2943000 b2981000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b2992000 b2999000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29aa000 b29df000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29f2000 b29f8000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a08000 b2a15000 r-xp /opt/usr/apps/org.example.bluetooth/bin/bluetooth
b2b36000 b2c19000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c50000 b2c78000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c8a000 b3489000 rw-p [stack:8483]
b3489000 b348b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b349b000 b34a5000 r-xp /lib/libnss_files-2.20-2014.11.so
b34b6000 b34bf000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34d0000 b34e1000 r-xp /lib/libnsl-2.20-2014.11.so
b34f4000 b34fa000 r-xp /lib/libnss_compat-2.20-2014.11.so
b350b000 b350c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3534000 b353b000 r-xp /usr/lib/libminizip.so.1.0.0
b354b000 b3550000 r-xp /usr/lib/libstorage.so.0.1
b3560000 b35b5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35cb000 b35df000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35ef000 b3633000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3643000 b364b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b365b000 b368b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b369e000 b3757000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b376b000 b37bf000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37d0000 b37eb000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37fb000 b38bc000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38cf000 b38e1000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38f1000 b38f5000 r-xp /usr/lib/libogg.so.0.7.1
b3905000 b3927000 r-xp /usr/lib/libvorbis.so.0.4.3
b3937000 b3a1b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a37000 b3a44000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a55000 b3a98000 r-xp /usr/lib/libsndfile.so.1.0.25
b3aad000 b3af4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b05000 b3b0b000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b1c000 b3b23000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b33000 b3b73000 r-xp /usr/lib/libmdm.so.1.2.10
b3b83000 b3b8b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b9a000 b3baa000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bcb000 b3c2b000 r-xp /usr/lib/libasound.so.2.0.0
b3c3d000 b3c73000 r-xp /usr/lib/libpulse.so.0.16.2
b3c84000 b3c87000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c97000 b3c9a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3caa000 b3caf000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cbf000 b3cc0000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cd0000 b3cdb000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3cef000 b3cf6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d06000 b3d0c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d1c000 b3d21000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d31000 b3d4c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d5c000 b3d63000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d73000 b3d76000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d87000 b3db5000 r-xp /usr/lib/libidn.so.11.5.44
b3dc5000 b3ddb000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3dec000 b3df6000 r-xp /usr/lib/libcares.so.2.1.0
b3e06000 b3e10000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e20000 b3e22000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e32000 b3e33000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e43000 b3e47000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e58000 b3e80000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e91000 b3eba000 r-xp /usr/lib/libturbojpeg.so
b3eda000 b3ee0000 r-xp /usr/lib/libgif.so.4.1.6
b3ef0000 b3f36000 r-xp /usr/lib/libcurl.so.4.3.0
b3f47000 b3f68000 r-xp /usr/lib/libexif.so.12.3.3
b3f83000 b3f98000 r-xp /usr/lib/libtts.so
b3fa9000 b3fb1000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fc1000 b4081000 r-xp /usr/lib/libdali-core.so.0.0.0
b408c000 b417f000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b419f000 b4279000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4290000 b4292000 r-xp /usr/lib/libboost_system.so.1.51.0
b42a2000 b42a8000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42b8000 b42db000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42ec000 b42ee000 r-xp /usr/lib/libappsvc.so.0.1.0
b42fe000 b4300000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4311000 b4316000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b432d000 b432f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b433f000 b4346000 r-xp /usr/lib/libsensord-share.so
b4356000 b436e000 r-xp /usr/lib/libsensor.so.1.1.0
b437f000 b4382000 r-xp /usr/lib/libXv.so.1.0.0
b4392000 b4397000 r-xp /usr/lib/libutilX.so.1.1.0
b43a7000 b43ac000 r-xp /usr/lib/libappcore-common.so.1.1
b43bc000 b43c3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43d6000 b43da000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43eb000 b44b5000 r-xp /usr/lib/libCOREGL.so.4.0
b44cc000 b44cf000 r-xp /usr/lib/libuuid.so.1.3.0
b44e0000 b44f7000 r-xp /usr/lib/libblkid.so.1.1.0
b4508000 b450a000 r-xp /usr/lib/libXau.so.6.0.0
b451a000 b451d000 r-xp /usr/lib/libEGL.so.1.4
b4525000 b452b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b453b000 b453d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b454e000 b455c000 r-xp /usr/lib/libGLESv2.so.2.0
b4565000 b45c7000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45dc000 b45f4000 r-xp /usr/lib/libmount.so.1.1.0
b4605000 b4619000 r-xp /usr/lib/libxcb.so.1.1.0
b462a000 b4631000 r-xp /lib/libcrypt-2.20-2014.11.so
b4669000 b467a000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b468b000 b468d000 r-xp /usr/lib/libiri.so
b469d000 b46a8000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46b9000 b46ce000 r-xp /lib/libexpat.so.1.5.2
b46e0000 b479e000 r-xp /usr/lib/libcairo.so.2.11200.14
b47b1000 b47b9000 r-xp /usr/lib/libdrm.so.2.4.0
b47c9000 b47cc000 r-xp /usr/lib/libdri2.so.0.0.0
b47dd000 b482b000 r-xp /usr/lib/libssl.so.1.0.0
b4840000 b484c000 r-xp /usr/lib/libeeze.so.1.13.0
b485c000 b4865000 r-xp /usr/lib/libethumb.so.1.13.0
b4875000 b4878000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4888000 b4a3f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5696000 b569f000 r-xp /usr/lib/libXi.so.6.1.0
b56af000 b56b1000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c1000 b56c5000 r-xp /usr/lib/libXtst.so.6.1.0
b56d5000 b56db000 r-xp /usr/lib/libXrender.so.1.3.0
b56eb000 b56f1000 r-xp /usr/lib/libXrandr.so.2.2.0
b5702000 b5704000 r-xp /usr/lib/libXinerama.so.1.0.0
b5714000 b5717000 r-xp /usr/lib/libXfixes.so.3.1.0
b5727000 b5732000 r-xp /usr/lib/libXext.so.6.4.0
b5742000 b5744000 r-xp /usr/lib/libXdamage.so.1.1.0
b5754000 b5756000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5767000 b5849000 r-xp /usr/lib/libX11.so.6.3.0
b585c000 b5863000 r-xp /usr/lib/libXcursor.so.1.0.2
b5873000 b588b000 r-xp /usr/lib/libudev.so.1.6.0
b588d000 b5890000 r-xp /lib/libattr.so.1.1.0
b58a0000 b58c0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c2000 b58c7000 r-xp /usr/lib/libffi.so.6.0.2
b58d7000 b58ef000 r-xp /lib/libz.so.1.2.8
b58ff000 b5901000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5911000 b59e6000 r-xp /usr/lib/libxml2.so.2.9.2
b59fb000 b5a96000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab2000 b5ab5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac5000 b5ade000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aef000 b5b00000 r-xp /lib/libresolv-2.20-2014.11.so
b5b14000 b5b8e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba3000 b5ba5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb5000 b5bbc000 r-xp /usr/lib/libembryo.so.1.13.0
b5bcc000 b5be4000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf5000 b5c18000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c39000 b5c4d000 r-xp /usr/lib/libector.so.1.13.0
b5c5e000 b5c76000 r-xp /usr/lib/liblua-5.1.so
b5c87000 b5cde000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf2000 b5d1a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d2b000 b5d3e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4f000 b5d86000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d97000 b5da5000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db5000 b5dbd000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcd000 b5dda000 r-xp /usr/lib/libeio.so.1.13.0
b5dea000 b5dec000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfc000 b5e01000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e11000 b5e28000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3a000 b5e5a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6a000 b5e8a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8c000 b5e92000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea2000 b5eb3000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec4000 b5ecb000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5edb000 b5eea000 r-xp /usr/lib/libeo.so.1.13.0
b5efb000 b5f0d000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1e000 b5f23000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f33000 b5f4c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5c000 b5f79000 r-xp /usr/lib/libeet.so.1.13.0
b5f92000 b5fda000 r-xp /usr/lib/libeina.so.1.13.0
b5feb000 b5ffb000 r-xp /usr/lib/libefl.so.1.13.0
b600c000 b60f1000 r-xp /usr/lib/libicuuc.so.51.1
b610e000 b624e000 r-xp /usr/lib/libicui18n.so.51.1
b6265000 b629d000 r-xp /usr/lib/libecore_x.so.1.13.0
b62af000 b62b2000 r-xp /lib/libcap.so.2.21
b62c2000 b62eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fc000 b6303000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6315000 b634c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635d000 b6448000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645b000 b64d4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e6000 b64eb000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fb000 b6505000 r-xp /usr/lib/libvconf.so.0.2.45
b6515000 b6517000 r-xp /usr/lib/libvasum.so.0.3.1
b6527000 b6529000 r-xp /usr/lib/libttrace.so.1.1
b6539000 b653c000 r-xp /usr/lib/libiniparser.so.0
b654c000 b6572000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6582000 b6587000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6598000 b65af000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c0000 b662b000 r-xp /lib/libm-2.20-2014.11.so
b663c000 b6642000 r-xp /lib/librt-2.20-2014.11.so
b6653000 b6660000 r-xp /usr/lib/libunwind.so.8.0.1
b6696000 b67ba000 r-xp /lib/libc-2.20-2014.11.so
b67cf000 b67e8000 r-xp /lib/libgcc_s-4.9.so.1
b67f8000 b68da000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68eb000 b6915000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6926000 b6962000 r-xp /usr/lib/libsystemd.so.0.4.0
b6964000 b69e6000 r-xp /usr/lib/libedje.so.1.13.0
b69f9000 b6a17000 r-xp /usr/lib/libecore.so.1.13.0
b6a37000 b6bbe000 r-xp /usr/lib/libevas.so.1.13.0
b6bf3000 b6c07000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1b000 b6e50000 r-xp /usr/lib/libelementary.so.1.13.0
b6e7e000 b6e82000 r-xp /usr/lib/libsmack.so.1.0.0
b6e92000 b6e99000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea9000 b6eab000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebb000 b6ebe000 r-xp /usr/lib/libbundle.so.0.1.22
b6ece000 b6ed0000 r-xp /lib/libdl-2.20-2014.11.so
b6ee1000 b6ef9000 r-xp /usr/lib/libaul.so.0.1.0
b6f0d000 b6f12000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f23000 b6f30000 r-xp /usr/lib/liblptcp.so
b6f42000 b6f46000 r-xp /usr/lib/libsys-assert.so
b6f57000 b6f77000 r-xp /lib/ld-2.20-2014.11.so
b6f88000 b6f8d000 r-xp /usr/bin/launchpad-loader
b8196000 b84c5000 rw-p [heap]
bedda000 bedfb000 rw-p [stack]
b8196000 b84c5000 rw-p [heap]
bedda000 bedfb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8477)
Call Stack Count: 1
 0: strchrnul + 0x7c (0xb670fe9c) [/lib/libc.so.6] + 0x79e9c
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
face(0xb7e04e68)
08-01 01:45:53.561+0600 W/ISF_PANEL_EFL(  756): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
08-01 01:45:53.561+0600 W/ISF_PANEL_EFL(  756): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
08-01 01:45:53.571+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7cb7508), gem(26), surface(0xb7d7db08)
08-01 01:45:53.601+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7da35c0), gem(23), surface(0xb7cd8000)
08-01 01:45:55.293+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6109166
08-01 01:45:55.293+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6109166
08-01 01:45:55.333+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6109215
08-01 01:45:55.343+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:55.343+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:55.343+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 1[0m
08-01 01:45:55.343+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:55.343+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:55.343+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:55.343+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:55.373+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:55.373+0600 I/IME_LITE(  681): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
08-01 01:45:55.383+0600 I/ISE_MULTI(  806): isemain.cpp: slot_set_caps_mode(792) > [0;36m[hidden state:false] mode=0[0m
08-01 01:45:55.393+0600 I/MALI    (  806): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:45:55.403+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7e05cd8), gem(28), surface(0xb7e04e68)
08-01 01:45:55.413+0600 I/IME_LITE(  681): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x30 value =0x0[0m
08-01 01:45:55.714+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6109593
08-01 01:45:55.714+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6109593
08-01 01:45:55.824+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6109699
08-01 01:45:55.824+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:55.824+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:55.824+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:55.824+0600 I/IME_LITE(  681): selectpage.cpp: ResetSelection(28) > [0;36m[0m
08-01 01:45:55.824+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:55.824+0600 I/ISE_MULTI(  806): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=2[0m
08-01 01:45:56.014+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6109895
08-01 01:45:56.014+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6109895
08-01 01:45:56.134+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6110011
08-01 01:45:56.134+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:56.134+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:56.164+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:56.164+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:58.016+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6111890
08-01 01:45:58.016+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6111890
08-01 01:45:58.156+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6112037
08-01 01:45:58.166+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:58.166+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.206+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:58.206+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:58.536+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6112414
08-01 01:45:58.536+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6112414
08-01 01:45:58.666+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6112541
08-01 01:45:58.666+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:58.666+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:58.666+0600 I/IME_LITE(  681): selectpage.cpp: ResetSelection(28) > [0;36m[0m
08-01 01:45:58.666+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:58.676+0600 I/ISE_MULTI(  806): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=5[0m
08-01 01:45:58.676+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:58.817+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6112694
08-01 01:45:58.817+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6112694
08-01 01:45:58.967+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6112842
08-01 01:45:58.967+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:58.967+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:58.987+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6112866
08-01 01:45:58.997+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6112866
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:58.997+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:59.007+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:59.127+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6113004
08-01 01:45:59.127+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:59.127+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:59.137+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.177+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:59.237+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113114
08-01 01:45:59.237+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113114
08-01 01:45:59.367+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6113241
08-01 01:45:59.367+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:59.367+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.387+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:59.397+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:59.457+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113329
08-01 01:45:59.457+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113329
08-01 01:45:59.557+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6113436
08-01 01:45:59.567+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:59.567+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.577+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:59.587+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:59.697+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113576
08-01 01:45:59.697+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113576
08-01 01:45:59.808+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6113682
08-01 01:45:59.808+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:45:59.808+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:45:59.808+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:45:59.828+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:45:59.918+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113793
08-01 01:45:59.918+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6113793
08-01 01:46:00.058+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6113929
08-01 01:46:00.058+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:46:00.058+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:46:00.058+0600 I/IME_LITE(  681): selectpage.cpp: ResetSelection(28) > [0;36m[0m
08-01 01:46:00.058+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:46:00.068+0600 I/ISE_MULTI(  806): isemain.cpp: slot_update_cursor_position(854) > [0;36m[hidden state:false] pos=11[0m
08-01 01:46:00.078+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:46:00.218+0600 E/EFL     (  295): ecore_x<295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6114092
08-01 01:46:00.218+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6114092
08-01 01:46:00.348+0600 E/EFL     (  806): ecore_x<806> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6114220
08-01 01:46:00.348+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
08-01 01:46:00.348+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(608) > [0;33mret : 41[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 E/IME_LITE(  681): selectpage.cpp: FillAWPage(398) > [0;31mstatus = 0[0m
08-01 01:46:00.378+0600 W/IME_LITE(  681): isf_xt9_imengine.cpp: process_specific_key_event(643) > [0;33mret = 0[0m
08-01 01:46:00.378+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
08-01 01:46:00.708+0600 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
08-01 01:46:00.708+0600 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 1:46 a.m.
08-01 01:46:00.708+0600 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 1:46 a.m."
08-01 01:46:00.708+0600 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 1:46 a.m."
08-01 01:46:00.708+0600 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
08-01 01:46:00.708+0600 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145593208 Time: <font_size=31> </font_size> <font_size=31> 1:46 a.m.</font_size></font>"
08-01 01:46:01.109+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6114995
08-01 01:46:01.199+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6115080
08-01 01:46:01.199+0600 I/IME_LITE(  681): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
08-01 01:46:01.199+0600 I/ISE_MULTI(  806): isemain.cpp: slot_reset_ise_input_context(1020) > [0;36m[hidden state:false][0m
08-01 01:46:01.209+0600 I/IME_LITE(  681): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
08-01 01:46:01.209+0600 I/IME_LITE(  681): westerneuropeandusxt9.cpp: _HelperCommandEvent(445) > [0;36mcmd = 0x90 value =0x0[0m
08-01 01:46:01.289+0600 D/bluetooth( 8477): [bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
08-01 01:46:01.319+0600 W/ISF_PANEL_EFL(  756): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6000002 FAILED!
08-01 01:46:01.399+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7da35c0), gem(23), surface(0xb7e198f8)
08-01 01:46:01.399+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d94888), gem(27), surface(0xb7e6b0c0)
08-01 01:46:01.449+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7dea1c0), gem(21), surface(0xb7df2bd0)
08-01 01:46:03.081+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6116958
08-01 01:46:03.141+0600 E/EFL     ( 8477): ecore_x<8477> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6117018
08-01 01:46:03.221+0600 D/bluetooth( 8477): [bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
08-01 01:46:04.152+0600 E/bluetooth( 8477): [socket_connection_state_changed_cb] Failed. result = -16.
08-01 01:46:04.312+0600 D/bluetooth( 8477): Callback: Socket of connection - 48.
08-01 01:46:04.312+0600 D/bluetooth( 8477): Callback: Role of connection - 2.
08-01 01:46:04.312+0600 D/bluetooth( 8477): Callback: Address of connection - 90:00:DB:03:34:6A.
08-01 01:46:04.482+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:46:04.492+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(947) status(3)
08-01 01:46:04.492+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:46:04.492+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 01:46:04.492+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(947)
08-01 01:46:04.492+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 947, appid: com.samsung.homescreen, status: fg
08-01 01:46:04.492+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 01:46:04.512+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8477 pgid = 8477
08-01 01:46:04.512+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(143) > dead_pid(8477)
08-01 01:46:04.532+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7cb5b70), gem(10), surface(0xb7e198f8)
08-01 01:46:04.572+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7cb5b70), gem(10), surface(0xb7df2bd0)
08-01 01:46:04.602+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d0bd30), gem(21), surface(0xb7da9528)
08-01 01:46:04.602+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d0bd30), gem(21), surface(0xb7e6b0c0)
08-01 01:46:04.622+0600 I/APP_CORE(  947): appcore-efl.c: __do_app(520) > [APP 947] Event: RESUME State: PAUSED
08-01 01:46:04.622+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-01 01:46:04.622+0600 E/cluster-home(  947): homescreen.cpp: OnResume(233) >  app resume
08-01 01:46:04.622+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:46:04.662+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7d90ae0), gem(15), surface(0xb7da9528)
08-01 01:46:04.702+0600 I/Tizen::System( 1185): (259) > Active app [com.samsun], current [org.exampl] 
08-01 01:46:04.702+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:46:04.712+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 01:46:04.712+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 01:46:04.712+0600 E/AUL_PAD ( 1321): launchpad.c: main(698) > error reading sigchld info
08-01 01:46:04.732+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 8477
08-01 01:46:04.732+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8477
08-01 01:46:04.732+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8477
08-01 01:46:04.742+0600 I/TIZEN_N_SOUND_MANAGER( 7669): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=1, ret=0x0
08-01 01:46:04.742+0600 E/TIZEN_N_SOUND_MANAGER( 7669): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:46:04.742+0600 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1031
08-01 01:46:04.752+0600 I/TIZEN_N_SOUND_MANAGER( 7669): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=1, ret=0x0
08-01 01:46:04.752+0600 E/TIZEN_N_SOUND_MANAGER( 7669): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:46:04.752+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 01:46:04.762+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:46:04.762+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:46:04.762+0600 I/Tizen::App( 1185): (243) > App[org.example.bluetooth] pid[8477] terminate event is forwarded
08-01 01:46:04.762+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 01:46:04.762+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [org.example.bluetooth, 8477, ]
08-01 01:46:04.762+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 01:46:04.762+0600 I/Tizen::App( 1185): (506) > TerminatedApp(org.example.bluetooth)
08-01 01:46:04.762+0600 I/Tizen::App( 1185): (512) > Not registered pid(8477)
08-01 01:46:04.762+0600 I/Tizen::System( 1185): (246) > Terminated app [org.example.bluetooth]
08-01 01:46:04.762+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:46:04.772+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:46:04.772+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for org.example.bluetooth, 8477.
08-01 01:46:04.822+0600 W/CRASH_MANAGER(10107): worker.c: worker_job(1199) > 1108477626c75146999436
