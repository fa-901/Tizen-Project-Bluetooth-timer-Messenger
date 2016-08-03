S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: bluetooth
PID: 9720
Date: 2016-08-01 01:49:25+0600
Executable File Path: /opt/usr/apps/org.example.bluetooth/bin/bluetooth
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9720, uid 5000)

Register Information
r0   = 0x00000020, r1   = 0x00000025
r2   = 0x0000feff, r3   = 0x0000000b
r4   = 0xbecfa7a0, r5   = 0x25252525
r6   = 0x00000000, r7   = 0x00000020
r8   = 0xb44bf4c0, r9   = 0xbecfa848
r10  = 0xb67c3000, fp   = 0xbecfa78c
ip   = 0x00000020, sp   = 0xbecfa24c
lr   = 0xb66cb1b4, pc   = 0xb6707e9c
cpsr = 0x60000010

Memory Information
MemTotal:   730440 KB
MemFree:     41140 KB
Buffers:     28892 KB
Cached:     262892 KB
VmPeak:     117088 KB
VmSize:     117084 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25448 KB
VmRSS:       22628 KB
VmData:      43940 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       36092 KB
VmPTE:          84 KB
VmSwap:       2596 KB

Threads Information
Threads: 4
PID = 9720 TID = 9720
9720 9724 10179 10186 

Maps Information
b0a01000 b1200000 rw-p [stack:10186]
b1d62000 b2561000 rw-p [stack:10179]
b2561000 b2572000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2582000 b2587000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2613000 b261b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b262c000 b262d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b263d000 b2651000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2665000 b2666000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2676000 b2679000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b268a000 b268b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b269b000 b269d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b26ad000 b26af000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b26bf000 b26cf000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b26df000 b26eb000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b293b000 b2979000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b298a000 b2991000 r-xp /usr/lib/libefl-extension.so.0.1.0
b29a2000 b29d7000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.55
b29ea000 b29f0000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a00000 b2a0d000 r-xp /opt/usr/apps/org.example.bluetooth/bin/bluetooth
b2b2e000 b2c11000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2c48000 b2c70000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2c82000 b3481000 rw-p [stack:9724]
b3481000 b3483000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3493000 b349d000 r-xp /lib/libnss_files-2.20-2014.11.so
b34ae000 b34b7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b34c8000 b34d9000 r-xp /lib/libnsl-2.20-2014.11.so
b34ec000 b34f2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3503000 b3504000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b352c000 b3533000 r-xp /usr/lib/libminizip.so.1.0.0
b3543000 b3548000 r-xp /usr/lib/libstorage.so.0.1
b3558000 b35ad000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b35c3000 b35d7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b35e7000 b362b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b363b000 b3643000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3653000 b3683000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3696000 b374f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3763000 b37b7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b37c8000 b37e3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b37f3000 b38b4000 r-xp /usr/lib/libprotobuf.so.9.0.1
b38c7000 b38d9000 r-xp /usr/lib/libefl-assist.so.0.1.0
b38e9000 b38ed000 r-xp /usr/lib/libogg.so.0.7.1
b38fd000 b391f000 r-xp /usr/lib/libvorbis.so.0.4.3
b392f000 b3a13000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a2f000 b3a3c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3a4d000 b3a90000 r-xp /usr/lib/libsndfile.so.1.0.25
b3aa5000 b3aec000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3afd000 b3b03000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b14000 b3b1b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b2b000 b3b6b000 r-xp /usr/lib/libmdm.so.1.2.10
b3b7b000 b3b83000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3b92000 b3ba2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3bc3000 b3c23000 r-xp /usr/lib/libasound.so.2.0.0
b3c35000 b3c6b000 r-xp /usr/lib/libpulse.so.0.16.2
b3c7c000 b3c7f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3c8f000 b3c92000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ca2000 b3ca7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3cb7000 b3cb8000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3cc8000 b3cd3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3ce7000 b3cee000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3cfe000 b3d04000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d14000 b3d19000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d29000 b3d44000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3d54000 b3d5b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3d6b000 b3d6e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3d7f000 b3dad000 r-xp /usr/lib/libidn.so.11.5.44
b3dbd000 b3dd3000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3de4000 b3dee000 r-xp /usr/lib/libcares.so.2.1.0
b3dfe000 b3e08000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e18000 b3e1a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e2a000 b3e2b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3e3b000 b3e3f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3e50000 b3e78000 r-xp /usr/lib/libui-extension.so.0.1.0
b3e89000 b3eb2000 r-xp /usr/lib/libturbojpeg.so
b3ed2000 b3ed8000 r-xp /usr/lib/libgif.so.4.1.6
b3ee8000 b3f2e000 r-xp /usr/lib/libcurl.so.4.3.0
b3f3f000 b3f60000 r-xp /usr/lib/libexif.so.12.3.3
b3f7b000 b3f90000 r-xp /usr/lib/libtts.so
b3fa1000 b3fa9000 r-xp /usr/lib/libfeedback.so.0.1.4
b3fb9000 b4079000 r-xp /usr/lib/libdali-core.so.0.0.0
b4084000 b4177000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4197000 b4271000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b4288000 b428a000 r-xp /usr/lib/libboost_system.so.1.51.0
b429a000 b42a0000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b42b0000 b42d3000 r-xp /usr/lib/libboost_thread.so.1.51.0
b42e4000 b42e6000 r-xp /usr/lib/libappsvc.so.0.1.0
b42f6000 b42f8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4309000 b430e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4325000 b4327000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4337000 b433e000 r-xp /usr/lib/libsensord-share.so
b434e000 b4366000 r-xp /usr/lib/libsensor.so.1.1.0
b4377000 b437a000 r-xp /usr/lib/libXv.so.1.0.0
b438a000 b438f000 r-xp /usr/lib/libutilX.so.1.1.0
b439f000 b43a4000 r-xp /usr/lib/libappcore-common.so.1.1
b43b4000 b43bb000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b43ce000 b43d2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b43e3000 b44ad000 r-xp /usr/lib/libCOREGL.so.4.0
b44c4000 b44c7000 r-xp /usr/lib/libuuid.so.1.3.0
b44d8000 b44ef000 r-xp /usr/lib/libblkid.so.1.1.0
b4500000 b4502000 r-xp /usr/lib/libXau.so.6.0.0
b4512000 b4515000 r-xp /usr/lib/libEGL.so.1.4
b451d000 b4523000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4533000 b4535000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4546000 b4554000 r-xp /usr/lib/libGLESv2.so.2.0
b455d000 b45bf000 r-xp /usr/lib/libpixman-1.so.0.28.2
b45d4000 b45ec000 r-xp /usr/lib/libmount.so.1.1.0
b45fd000 b4611000 r-xp /usr/lib/libxcb.so.1.1.0
b4622000 b4629000 r-xp /lib/libcrypt-2.20-2014.11.so
b4661000 b4672000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b4683000 b4685000 r-xp /usr/lib/libiri.so
b4695000 b46a0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b46b1000 b46c6000 r-xp /lib/libexpat.so.1.5.2
b46d8000 b4796000 r-xp /usr/lib/libcairo.so.2.11200.14
b47a9000 b47b1000 r-xp /usr/lib/libdrm.so.2.4.0
b47c1000 b47c4000 r-xp /usr/lib/libdri2.so.0.0.0
b47d5000 b4823000 r-xp /usr/lib/libssl.so.1.0.0
b4838000 b4844000 r-xp /usr/lib/libeeze.so.1.13.0
b4854000 b485d000 r-xp /usr/lib/libethumb.so.1.13.0
b486d000 b4870000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4880000 b4a37000 r-xp /usr/lib/libcrypto.so.1.0.0
b568e000 b5697000 r-xp /usr/lib/libXi.so.6.1.0
b56a7000 b56a9000 r-xp /usr/lib/libXgesture.so.7.0.0
b56b9000 b56bd000 r-xp /usr/lib/libXtst.so.6.1.0
b56cd000 b56d3000 r-xp /usr/lib/libXrender.so.1.3.0
b56e3000 b56e9000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fa000 b56fc000 r-xp /usr/lib/libXinerama.so.1.0.0
b570c000 b570f000 r-xp /usr/lib/libXfixes.so.3.1.0
b571f000 b572a000 r-xp /usr/lib/libXext.so.6.4.0
b573a000 b573c000 r-xp /usr/lib/libXdamage.so.1.1.0
b574c000 b574e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b575f000 b5841000 r-xp /usr/lib/libX11.so.6.3.0
b5854000 b585b000 r-xp /usr/lib/libXcursor.so.1.0.2
b586b000 b5883000 r-xp /usr/lib/libudev.so.1.6.0
b5885000 b5888000 r-xp /lib/libattr.so.1.1.0
b5898000 b58b8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ba000 b58bf000 r-xp /usr/lib/libffi.so.6.0.2
b58cf000 b58e7000 r-xp /lib/libz.so.1.2.8
b58f7000 b58f9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5909000 b59de000 r-xp /usr/lib/libxml2.so.2.9.2
b59f3000 b5a8e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aaa000 b5aad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5abd000 b5ad6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ae7000 b5af8000 r-xp /lib/libresolv-2.20-2014.11.so
b5b0c000 b5b86000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9b000 b5b9d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bad000 b5bb4000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc4000 b5bdc000 r-xp /usr/lib/libpng12.so.0.50.0
b5bed000 b5c10000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c31000 b5c45000 r-xp /usr/lib/libector.so.1.13.0
b5c56000 b5c6e000 r-xp /usr/lib/liblua-5.1.so
b5c7f000 b5cd6000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cea000 b5d12000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d23000 b5d36000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d47000 b5d7e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d8f000 b5d9d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dad000 b5db5000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc5000 b5dd2000 r-xp /usr/lib/libeio.so.1.13.0
b5de2000 b5de4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5df4000 b5df9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e09000 b5e20000 r-xp /usr/lib/libefreet.so.1.13.0
b5e32000 b5e52000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e62000 b5e82000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e84000 b5e8a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e9a000 b5eab000 r-xp /usr/lib/libemotion.so.1.13.0
b5ebc000 b5ec3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed3000 b5ee2000 r-xp /usr/lib/libeo.so.1.13.0
b5ef3000 b5f05000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f16000 b5f1b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f2b000 b5f44000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f54000 b5f71000 r-xp /usr/lib/libeet.so.1.13.0
b5f8a000 b5fd2000 r-xp /usr/lib/libeina.so.1.13.0
b5fe3000 b5ff3000 r-xp /usr/lib/libefl.so.1.13.0
b6004000 b60e9000 r-xp /usr/lib/libicuuc.so.51.1
b6106000 b6246000 r-xp /usr/lib/libicui18n.so.51.1
b625d000 b6295000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a7000 b62aa000 r-xp /lib/libcap.so.2.21
b62ba000 b62e3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62f4000 b62fb000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b630d000 b6344000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6355000 b6440000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6453000 b64cc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64de000 b64e3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f3000 b64fd000 r-xp /usr/lib/libvconf.so.0.2.45
b650d000 b650f000 r-xp /usr/lib/libvasum.so.0.3.1
b651f000 b6521000 r-xp /usr/lib/libttrace.so.1.1
b6531000 b6534000 r-xp /usr/lib/libiniparser.so.0
b6544000 b656a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b657a000 b657f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6590000 b65a7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b8000 b6623000 r-xp /lib/libm-2.20-2014.11.so
b6634000 b663a000 r-xp /lib/librt-2.20-2014.11.so
b664b000 b6658000 r-xp /usr/lib/libunwind.so.8.0.1
b668e000 b67b2000 r-xp /lib/libc-2.20-2014.11.so
b67c7000 b67e0000 r-xp /lib/libgcc_s-4.9.so.1
b67f0000 b68d2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e3000 b690d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b691e000 b695a000 r-xp /usr/lib/libsystemd.so.0.4.0
b695c000 b69de000 r-xp /usr/lib/libedje.so.1.13.0
b69f1000 b6a0f000 r-xp /usr/lib/libecore.so.1.13.0
b6a2f000 b6bb6000 r-xp /usr/lib/libevas.so.1.13.0
b6beb000 b6bff000 r-xp /lib/libpthread-2.20-2014.11.so
b6c13000 b6e48000 r-xp /usr/lib/libelementary.so.1.13.0
b6e76000 b6e7a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e8a000 b6e91000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea1000 b6ea3000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb3000 b6eb6000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec6000 b6ec8000 r-xp /lib/libdl-2.20-2014.11.so
b6ed9000 b6ef1000 r-xp /usr/lib/libaul.so.0.1.0
b6f05000 b6f0a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1b000 b6f28000 r-xp /usr/lib/liblptcp.so
b6f3a000 b6f3e000 r-xp /usr/lib/libsys-assert.so
b6f4f000 b6f6f000 r-xp /lib/ld-2.20-2014.11.so
b6f80000 b6f85000 r-xp /usr/bin/launchpad-loader
b72b6000 b75eb000 rw-p [heap]
becde000 becff000 rw-p [stack]
becde000 becff000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9720)
Call Stack Count: 1
 0: strchrnul + 0x7c (0xb6707e9c) [/lib/libc.so.6] + 0x79e9c
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
o.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:48:49.783+0600 E/EFL     (11273): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:48:49.783+0600 E/EFL     (11273): edje<11273> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:48:49.783+0600 E/EFL     (11273): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:48:51.265+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:48:51.265+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:48:51.265+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:48:51.265+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:48:52.106+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6285984
08-01 01:48:52.186+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6286066
08-01 01:48:52.216+0600 I/MALI    (10648): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:48:52.226+0600 I/MALI    (10648): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:48:52.236+0600 I/MALI    (10648): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:48:52.276+0600 E/UXT     (10648): uxt_theme_object.c: uxt_theme_object_set_color(490) > failed to get color for code(AO003)
08-01 01:48:52.306+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: _connection_libnet_get_profile_iterator(874) > Wi-Fi profile count: 9
08-01 01:48:52.316+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: _connection_libnet_get_profile_iterator(885) > Cellular profile count: 0
08-01 01:48:52.336+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: _connection_libnet_get_profile_iterator(898) > Ethernet profile count : 0
08-01 01:48:52.356+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: _connection_libnet_get_profile_iterator(913) > Bluetooth profile count : 1
08-01 01:48:52.356+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: _connection_libnet_get_profile_iterator(920) > Total profile count : 10
08-01 01:48:52.376+0600 I/CAPI_NETWORK_CONNECTION(10648): connection.c: connection_get_wifi_state(706) > Wi-Fi state: 1
08-01 01:48:52.486+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: __libnet_evt_cb(452) > Connection opened RSP[OPERATION_FAILED]
08-01 01:48:52.486+0600 E/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: __libnet_evt_cb(467) > Failed to open connection[OPERATION_FAILED]
08-01 01:48:52.936+0600 I/APP_CORE(  928): appcore-efl.c: __do_app(520) > [APP 928] Event: MEM_FLUSH State: PAUSED
08-01 01:48:53.287+0600 I/APP_CORE( 8277): appcore-efl.c: __do_app(520) > [APP 8277] Event: MEM_FLUSH State: PAUSED
08-01 01:48:53.657+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6287527
08-01 01:48:53.697+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6287568
08-01 01:48:54.448+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6288321
08-01 01:48:54.558+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6288437
08-01 01:48:55.429+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6289312
08-01 01:48:55.489+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6289375
08-01 01:48:55.559+0600 E/UXT     (10648): uxt_theme_object.c: uxt_theme_object_set_color(490) > failed to get color for code(AO003)
08-01 01:48:55.589+0600 I/CAPI_NETWORK_CONNECTION(10648): connection.c: connection_get_wifi_state(706) > Wi-Fi state: 1
08-01 01:48:55.679+0600 I/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: __libnet_evt_cb(452) > Connection opened RSP[OPERATION_FAILED]
08-01 01:48:55.679+0600 E/CAPI_NETWORK_CONNECTION(10648): libnetwork.c: __libnet_evt_cb(467) > Failed to open connection[OPERATION_FAILED]
08-01 01:49:00.684+0600 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
08-01 01:49:00.684+0600 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 1:49 a.m.
08-01 01:49:00.684+0600 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 1:49 a.m."
08-01 01:49:00.684+0600 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 1:49 a.m."
08-01 01:49:00.684+0600 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
08-01 01:49:00.684+0600 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147036435 Time: <font_size=31> </font_size> <font_size=31> 1:49 a.m.</font_size></font>"
08-01 01:49:10.323+0600 W/AUL     (11202): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.bt-syspopup)
08-01 01:49:10.323+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 0
08-01 01:49:10.333+0600 I/AUL     (  630): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bt-service, ret : 0
08-01 01:49:10.343+0600 I/AUL     (  630): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/bt-service, ret : 0
08-01 01:49:10.343+0600 E/AUL_AMD (  630): amd_launch.c: _start_app(2518) > no caller appid info, ret: -1
08-01 01:49:10.343+0600 W/AUL_AMD (  630): amd_launch.c: _start_app(2527) > caller pid : 11202
08-01 01:49:10.343+0600 E/AUL_AMD (  630): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
08-01 01:49:10.353+0600 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
08-01 01:49:10.363+0600 W/AUL_AMD (  630): amd_launch.c: _start_app(3074) > loading shared rule
08-01 01:49:10.363+0600 I/SHAREDRULE_CLIENT(  630): SharedruleClient.cpp: loadSharedrule(285) > Enter
08-01 01:49:10.363+0600 I/SHAREDRULE_CLIENT(  630): SharedruleClient.cpp: loadSharedrule(291) > sharedrule for com.samsung.bt-syspopup has already loaded
08-01 01:49:10.363+0600 I/SHAREDRULE_CLIENT(  630): SharedruleClient.cpp: loadSharedrule(292) > skip loading sharedrule
08-01 01:49:10.363+0600 W/AUL_AMD (  630): amd_launch.c: _start_app(3081) > pad pid(-5)
08-01 01:49:10.363+0600 W/AUL_PAD ( 1321): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
08-01 01:49:10.363+0600 W/AUL_PAD ( 1321): launchpad.c: __send_result_to_caller(267) > Check app launching
08-01 01:49:10.403+0600 I/CAPI_APPFW_APPLICATION(10914): app_main.c: ui_app_main(789) > app_efl_main
08-01 01:49:10.403+0600 I/CAPI_APPFW_APPLICATION(10914): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
08-01 01:49:10.444+0600 E/TBM     (10914): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
08-01 01:49:10.464+0600 W/AUL     (  630): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 10914, appid: com.samsung.bt-syspopup
08-01 01:49:10.464+0600 E/AUL     (  630): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
08-01 01:49:10.474+0600 W/AUL     (11202): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10914)
08-01 01:49:10.524+0600 E/RESOURCED(  665): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.bt-syspopup
08-01 01:49:10.674+0600 I/APP_CORE(10914): appcore-efl.c: __do_app(520) > [APP 10914] Event: RESET State: CREATED
08-01 01:49:10.674+0600 I/CAPI_APPFW_APPLICATION(10914): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
08-01 01:49:10.894+0600 W/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: sound_manager_get_session_type(234) > session hasn't been set, setting default session
08-01 01:49:10.894+0600 I/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: sound_manager_get_session_type(273) > returns : type=0, ret=0x0
08-01 01:49:10.894+0600 W/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=2
08-01 01:49:10.894+0600 W/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: sound_manager_set_session_type(219) > << leave : type=2, ret=0x0
08-01 01:49:10.894+0600 E/TIZEN_N_SOUND_MANAGER(10914): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_set_session_type] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:49:10.904+0600 E/TIZEN_N_SOUND_MANAGER(10914): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_max_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:49:10.914+0600 I/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: sound_manager_get_volume(84) > returns : type=1, volume=1, ret=0x0
08-01 01:49:10.914+0600 E/TIZEN_N_SOUND_MANAGER(10914): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-01 01:49:10.974+0600 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
08-01 01:49:10.974+0600 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
08-01 01:49:10.974+0600 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
08-01 01:49:10.984+0600 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
08-01 01:49:10.984+0600 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
08-01 01:49:10.984+0600 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
08-01 01:49:10.984+0600 W/TIZEN_N_PLAYER(10914): player.c: player_create(1198) > [player_create] new handle : 0xb7393d20
08-01 01:49:10.984+0600 W/TIZEN_N_PLAYER(10914): player.c: player_set_sound_type(1600) > [player_set_sound_type] sound type = 1
08-01 01:49:10.994+0600 W/TIZEN_N_PLAYER(10914): player.c: player_prepare(1382) > [player_prepare] Start
08-01 01:49:11.044+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x3
08-01 01:49:11.044+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(751) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-01 01:49:11.044+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(946) > [__msg_callback] End
08-01 01:49:11.194+0600 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
08-01 01:49:11.194+0600 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
08-01 01:49:11.194+0600 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(82) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x3
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(751) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(946) > [__msg_callback] End
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: player_prepare(1451) > [player_prepare] End
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: __set_callback(571) > [__set_callback] Event type : 1 
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: __set_callback(571) > [__set_callback] Event type : 2 
08-01 01:49:11.294+0600 W/TIZEN_N_PLAYER(10914): player.c: __set_callback(571) > [__set_callback] Event type : 3 
08-01 01:49:11.304+0600 E/EFL     (10914): edje<10914> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:11.304+0600 E/EFL     (10914): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:11.304+0600 E/EFL     (10914): edje<10914> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:11.304+0600 E/EFL     (10914): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:11.304+0600 E/EFL     (10914): edje<10914> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:11.304+0600 E/EFL     (10914): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:11.304+0600 E/EFL     (10914): edje<10914> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:11.304+0600 E/EFL     (10914): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:11.324+0600 W/TIZEN_N_PLAYER(10914): player.c: player_start(1638) > [player_start] Start
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x3
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(751) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(946) > [__msg_callback] End
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(725) > [__msg_callback] Got message type : 0x104
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(774) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: __msg_callback(946) > [__msg_callback] End
08-01 01:49:11.364+0600 W/TIZEN_N_PLAYER(10914): player.c: player_start(1696) > [player_start] End
08-01 01:49:11.384+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:11.384+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:11.424+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e065b8), gem(38), surface(0xb7cc2928)
08-01 01:49:11.465+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 01:49:11.475+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:49:11.475+0600 W/AUL_AMD (  630): amd_launch.c: __grab_timeout_handler(1642) > back key ungrab error
08-01 01:49:11.475+0600 I/Tizen::System( 1185): (259) > Active app [com.samsun], current [ug-bluetoo] 
08-01 01:49:11.475+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:11.505+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d8bd18), gem(40), surface(0xb7da9528)
08-01 01:49:11.525+0600 W/APP_CORE(10914): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7e00006
08-01 01:49:11.525+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 35
08-01 01:49:11.535+0600 I/APP_CORE(10914): appcore-efl.c: __do_app(520) > [APP 10914] Event: RESUME State: CREATED
08-01 01:49:11.535+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7d7b300), gem(36), surface(0xb7e4eb80)
08-01 01:49:11.555+0600 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1061
08-01 01:49:11.555+0600 I/APP_CORE(10914): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
08-01 01:49:11.555+0600 I/APP_CORE(10914): appcore-efl.c: __do_app(637) > [APP 10914] Initial Launching, call the resume_cb
08-01 01:49:11.555+0600 I/CAPI_APPFW_APPLICATION(10914): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-01 01:49:11.555+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(10914) status(3)
08-01 01:49:11.555+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:49:11.555+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 01:49:11.555+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.bt-syspopup(10914)
08-01 01:49:11.555+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 10914, appid: com.samsung.bt-syspopup, status: fg
08-01 01:49:11.565+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:49:11.575+0600 I/Tizen::App( 1185): (499) > LaunchedApp(com.samsung.bt-syspopup)
08-01 01:49:11.575+0600 I/Tizen::App( 1185): (733) > Finished invoking application event listener for com.samsung.bt-syspopup, 10914.
08-01 01:49:11.585+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:11.585+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:11.585+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:11.585+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:11.585+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 01:49:12.115+0600 E/EFL     (10914): ecore_x<10914> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6305995
08-01 01:49:12.245+0600 E/EFL     (10914): ecore_x<10914> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6306121
08-01 01:49:12.285+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:12.305+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:12.315+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 01:49:12.355+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 01:49:12.355+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 01:49:12.355+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.bt-syspopup(10914)
08-01 01:49:12.355+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 10914, appid: com.samsung.bt-syspopup, status: bg
08-01 01:49:12.355+0600 I/Tizen::System( 1185): (259) > Active app [ug-bluetoo], current [com.samsun] 
08-01 01:49:12.355+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:12.365+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:49:12.365+0600 I/CAPI_APPFW_APPLICATION(10914): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-01 01:49:12.365+0600 I/CAPI_APPFW_APPLICATION(10914): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
08-01 01:49:12.486+0600 I/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: __sound_manager_finalize(715) > <ENTER>
08-01 01:49:12.486+0600 E/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: __sound_manager_finalize(718) > [__sound_manager_finalize] failed to mm_session_finish(), ret(0x80000b01)
08-01 01:49:12.486+0600 I/TIZEN_N_SOUND_MANAGER(10914): sound_manager.c: __sound_manager_finalize(721) > <LEAVE>
08-01 01:49:12.506+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10914 pgid = 10914
08-01 01:49:12.516+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(143) > dead_pid(10914)
08-01 01:49:12.606+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 01:49:12.606+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 01:49:12.606+0600 E/AUL_PAD ( 1321): launchpad.c: main(698) > error reading sigchld info
08-01 01:49:12.606+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 10914
08-01 01:49:12.606+0600 I/Tizen::App( 1185): (243) > App[com.samsung.bt-syspopup] pid[10914] terminate event is forwarded
08-01 01:49:12.606+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 01:49:12.606+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [com.samsung.bt-syspopup, 10914, ]
08-01 01:49:12.606+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 01:49:12.606+0600 I/Tizen::App( 1185): (506) > TerminatedApp(com.samsung.bt-syspopup)
08-01 01:49:12.606+0600 I/Tizen::App( 1185): (512) > Not registered pid(10914)
08-01 01:49:12.606+0600 I/Tizen::System( 1185): (246) > Terminated app [com.samsung.bt-syspopup]
08-01 01:49:12.606+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:12.606+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10914
08-01 01:49:12.606+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10914
08-01 01:49:12.616+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:12.626+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:49:12.626+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for com.samsung.bt-syspopup, 10914.
08-01 01:49:12.726+0600 I/UXT     (11456): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
08-01 01:49:16.449+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6310330
08-01 01:49:16.539+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6310413
08-01 01:49:17.360+0600 W/AUL_AMD (  630): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-01 01:49:17.911+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6311789
08-01 01:49:18.041+0600 E/EFL     (10648): ecore_x<10648> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6311914
08-01 01:49:18.081+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 01:49:18.081+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 01:49:18.081+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(190) > send_signal BG ug-bluetooth-efl-single(10648)
08-01 01:49:18.081+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 10648, appid: ug-bluetooth-efl-single, status: bg
08-01 01:49:18.081+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:18.091+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(8277) status(3)
08-01 01:49:18.091+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:49:18.091+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 01:49:18.091+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG ug-bluetooth-efl(8277)
08-01 01:49:18.091+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 8277, appid: ug-bluetooth-efl, status: fg
08-01 01:49:18.091+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 01:49:18.101+0600 E/EFL     (10648): eo<10648> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x80037fc0's acvie is  NULL, entry: 0xb34a4e18, 0xb86fc7b8, 0
08-01 01:49:18.101+0600 E/EFL     (10648): eo<10648> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x80037fc0 is not pointing to a valid object. Maybe it has already been freed.
08-01 01:49:18.101+0600 E/EFL     (10648): eo<10648> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x80037fc0) is an invalid ref.
08-01 01:49:18.101+0600 E/EFL     (10648): <10648> lib/ecore/ecore_idler.c:91 _ecore_idler_del() safety check failed: idler == NULL
08-01 01:49:18.101+0600 E/CAPI_NETWORK_BLUETOOTH(10648): bluetooth-hid.c: bt_hid_host_deinitialize(95) > [bt_hid_host_deinitialize] NOT_SUPPORTED(0xc0000002)
08-01 01:49:18.221+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:18.221+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:18.221+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:18.221+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:18.241+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d46518), gem(22), surface(0xb7df2bd0)
08-01 01:49:18.251+0600 I/CAPI_NETWORK_CONNECTION(10648): connection.c: connection_destroy(427) > Destroy handle: 0xb8abe808
08-01 01:49:18.261+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d46518), gem(22), surface(0xb7e198f8)
08-01 01:49:18.301+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d1c8f8), gem(36), surface(0xb7e4eb80)
08-01 01:49:18.301+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d1c8f8), gem(36), surface(0xb7da9528)
08-01 01:49:18.311+0600 E/EFL     ( 8277): edje<8277> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:18.311+0600 E/EFL     ( 8277): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:18.311+0600 E/EFL     ( 8277): edje<8277> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:18.311+0600 E/EFL     ( 8277): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:18.321+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:18.321+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:18.331+0600 E/CAPI_NETWORK_CONNECTION(10648): connection_profile.c: connection_profile_unset_state_changed_cb(1080) > Invalid parameter
08-01 01:49:18.331+0600 E/CAPI_NETWORK_CONNECTION(10648): connection_profile.c: connection_profile_destroy(308) > Invalid parameter
08-01 01:49:18.351+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(10648) status(4)
08-01 01:49:18.371+0600 I/Tizen::System( 1185): (259) > Active app [ug-bluetoo], current [ug-bluetoo] 
08-01 01:49:18.371+0600 I/Tizen::System( 1185): (273) > Current App[ug-bluetoo] is already actived.
08-01 01:49:18.371+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 01:49:18.381+0600 I/APP_CORE( 8277): appcore-efl.c: __do_app(520) > [APP 8277] Event: RESUME State: PAUSED
08-01 01:49:18.381+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7e00eb0), gem(28), surface(0xb7e6b0c0)
08-01 01:49:18.411+0600 W/UI_GADGET(10648): manager.c: ugman_tree_dump(185) > [34m============== TREE_DUMP =============[0m
08-01 01:49:18.411+0600 W/UI_GADGET(10648): manager.c: ugman_tree_dump(186) > [34mROOT: Manager(0xb89067c0)[0m
08-01 01:49:18.411+0600 W/UI_GADGET(10648): manager.c: ugman_ug_destroy(600) > [34mug parent is null[0m
08-01 01:49:18.471+0600 I/MALI    (10648): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
08-01 01:49:18.471+0600 I/MALI    (10648): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=10648   close drm_fd=29 
08-01 01:49:18.471+0600 I/MALI    (10648): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
08-01 01:49:18.481+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 36
08-01 01:49:18.571+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7e4cf60), gem(28), surface(0xb7cc2928)
08-01 01:49:18.772+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10648 pgid = 10648
08-01 01:49:18.772+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(143) > dead_pid(10648)
08-01 01:49:18.802+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 01:49:18.802+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 01:49:18.802+0600 E/AUL_PAD ( 1321): launchpad.c: main(698) > error reading sigchld info
08-01 01:49:18.812+0600 I/Tizen::App( 1185): (243) > App[ug-bluetooth-efl-single] pid[10648] terminate event is forwarded
08-01 01:49:18.812+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 01:49:18.812+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [ug-bluetooth-efl-single, 10648, ]
08-01 01:49:18.812+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 01:49:18.812+0600 I/Tizen::App( 1185): (506) > TerminatedApp(ug-bluetooth-efl-single)
08-01 01:49:18.812+0600 I/Tizen::App( 1185): (512) > Not registered pid(10648)
08-01 01:49:18.812+0600 I/Tizen::System( 1185): (246) > Terminated app [ug-bluetooth-efl-single]
08-01 01:49:18.812+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:18.812+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 10648
08-01 01:49:18.812+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10648
08-01 01:49:18.812+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10648
08-01 01:49:18.832+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:18.832+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:49:18.832+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for ug-bluetooth-efl-single, 10648.
08-01 01:49:19.492+0600 E/EFL     ( 8277): ecore_x<8277> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6313375
08-01 01:49:19.502+0600 I/MALI    ( 8277): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:49:19.522+0600 I/MALI    ( 8277): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:49:19.552+0600 I/MALI    ( 8277): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:49:19.622+0600 E/EFL     ( 8277): ecore_x<8277> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6313501
08-01 01:49:19.652+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 22
08-01 01:49:19.652+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(1207) > app status : 5
08-01 01:49:19.652+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(190) > send_signal BG ug-bluetooth-efl(8277)
08-01 01:49:19.652+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 8277, appid: ug-bluetooth-efl, status: bg
08-01 01:49:19.652+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:19.663+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(9720) status(3)
08-01 01:49:19.663+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:49:19.663+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 01:49:19.663+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.bluetooth(9720)
08-01 01:49:19.663+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 9720, appid: org.example.bluetooth, status: fg
08-01 01:49:19.673+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 01:49:19.673+0600 E/EFL     ( 8277): eo<8277> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x801a673a's acvie is  NULL, entry: 0xb35129b8, 0xb7af7a80, 0
08-01 01:49:19.673+0600 E/EFL     ( 8277): eo<8277> lib/eo/eo_ptr_indirection.x:297 _eo_obj_pointer_get() eo_id 0x801a673a's generation is not matched, entry: 0xb35129b8, 0xb7af7a80, 427, 314
08-01 01:49:19.673+0600 E/EFL     ( 8277): eo<8277> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x801a673a is not pointing to a valid object. Maybe it has already been freed.
08-01 01:49:19.673+0600 E/EFL     ( 8277): eo<8277> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x801a673a) is an invalid ref.
08-01 01:49:19.673+0600 E/EFL     ( 8277): <8277> lib/ecore/ecore_idler.c:91 _ecore_idler_del() safety check failed: idler == NULL
08-01 01:49:19.673+0600 E/CAPI_NETWORK_BLUETOOTH( 8277): bluetooth-hid.c: bt_hid_host_deinitialize(95) > [bt_hid_host_deinitialize] NOT_SUPPORTED(0xc0000002)
08-01 01:49:19.753+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:19.753+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:19.753+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:19.753+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:19.823+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e4cf60), gem(22), surface(0xb7e198f8)
08-01 01:49:19.843+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e4cf60), gem(22), surface(0xb7e6b0c0)
08-01 01:49:19.873+0600 I/CAPI_NETWORK_CONNECTION( 8277): connection.c: connection_destroy(427) > Destroy handle: 0xb7e39480
08-01 01:49:19.883+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d74050), gem(27), surface(0xb7da9528)
08-01 01:49:19.883+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d74050), gem(27), surface(0xb7df2bd0)
08-01 01:49:19.893+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:19.893+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:19.913+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(8277) status(4)
08-01 01:49:19.923+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 15
08-01 01:49:19.933+0600 I/Tizen::System( 1185): (259) > Active app [org.exampl], current [ug-bluetoo] 
08-01 01:49:19.933+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:19.943+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:49:19.943+0600 I/APP_CORE( 9720): appcore-efl.c: __do_app(520) > [APP 9720] Event: RESUME State: PAUSED
08-01 01:49:19.943+0600 I/CAPI_APPFW_APPLICATION( 9720): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-01 01:49:19.943+0600 E/EFL     ( 9720): edje<9720> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:19.943+0600 E/EFL     ( 9720): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:19.943+0600 E/EFL     ( 9720): edje<9720> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-01 01:49:19.943+0600 E/EFL     ( 9720): By the power of Grayskull, your previous Embryo stack is now broken!
08-01 01:49:19.983+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7cb94d8), gem(26), surface(0xb7cc2928)
08-01 01:49:20.003+0600 W/UI_GADGET( 8277): manager.c: ugman_tree_dump(185) > [34m============== TREE_DUMP =============[0m
08-01 01:49:20.003+0600 W/UI_GADGET( 8277): manager.c: ugman_tree_dump(186) > [34mROOT: Manager(0xb7d42c68)[0m
08-01 01:49:20.003+0600 W/UI_GADGET( 8277): manager.c: ugman_ug_destroy(600) > [34mug parent is null[0m
08-01 01:49:20.043+0600 I/MALI    ( 8277): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
08-01 01:49:20.043+0600 I/MALI    ( 8277): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=8277   close drm_fd=29 
08-01 01:49:20.043+0600 I/MALI    ( 8277): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
08-01 01:49:20.043+0600 W/AUL_AMD (  630): amd_request.c: __request_handler(912) > __request_handler: 36
08-01 01:49:20.313+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8277 pgid = 8277
08-01 01:49:20.313+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(143) > dead_pid(8277)
08-01 01:49:20.353+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 01:49:20.353+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 01:49:20.353+0600 E/AUL_PAD ( 1321): launchpad.c: main(698) > error reading sigchld info
08-01 01:49:20.353+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 8277
08-01 01:49:20.353+0600 I/Tizen::App( 1185): (243) > App[ug-bluetooth-efl] pid[8277] terminate event is forwarded
08-01 01:49:20.353+0600 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
08-01 01:49:20.353+0600 I/Tizen::System( 1185): (196) > Accessory Owner is removed [ug-bluetooth-efl, 8277, ]
08-01 01:49:20.353+0600 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
08-01 01:49:20.353+0600 I/Tizen::App( 1185): (506) > TerminatedApp(ug-bluetooth-efl)
08-01 01:49:20.353+0600 I/Tizen::App( 1185): (512) > Not registered pid(8277)
08-01 01:49:20.353+0600 I/Tizen::System( 1185): (246) > Terminated app [ug-bluetooth-efl]
08-01 01:49:20.353+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:20.353+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8277
08-01 01:49:20.353+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8277
08-01 01:49:20.363+0600 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1066
08-01 01:49:20.363+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:20.363+0600 I/Tizen::System( 1185): (157) > change brightness system value.
08-01 01:49:20.363+0600 I/Tizen::App( 1185): (782) > Finished invoking application event listener for ug-bluetooth-efl, 8277.
08-01 01:49:21.084+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:21.084+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:21.084+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:21.084+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:21.584+0600 E/EFL     ( 9720): ecore_x<9720> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6315461
08-01 01:49:21.664+0600 E/EFL     ( 9720): ecore_x<9720> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6315533
08-01 01:49:21.785+0600 D/bluetooth( 9720): [bt_socket_connect_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
08-01 01:49:22.655+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:22.655+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:22.655+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:22.655+0600 E/RESOURCED(  665): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-01 01:49:23.086+0600 W/AUL_AMD (  630): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-01 01:49:24.347+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.347+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.347+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.347+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:49:24.357+0600 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
08-01 01:49:24.657+0600 W/AUL_AMD (  630): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-01 01:49:25.628+0600 D/bluetooth( 9720): Callback: Socket of connection - 49.
08-01 01:49:25.628+0600 D/bluetooth( 9720): Callback: Role of connection - 2.
08-01 01:49:25.628+0600 D/bluetooth( 9720): Callback: Address of connection - 90:00:DB:03:34:6A.
08-01 01:49:25.819+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:25.839+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3367) > pid(947) status(3)
08-01 01:49:25.839+0600 W/AUL_AMD (  630): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-01 01:49:25.839+0600 W/AUL_AMD (  630): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
08-01 01:49:25.839+0600 W/AUL     (  630): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(947)
08-01 01:49:25.839+0600 W/AUL     (  630): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 947, appid: com.samsung.homescreen, status: fg
08-01 01:49:25.839+0600 E/AUL     (  630): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
08-01 01:49:25.849+0600 I/Tizen::Net::Wifi( 1185): (941) > The background scan result updated.
08-01 01:49:25.859+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9720 pgid = 9720
08-01 01:49:25.859+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(143) > dead_pid(9720)
08-01 01:49:25.889+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d77518), gem(22), surface(0xb7da9528)
08-01 01:49:25.909+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7d77518), gem(22), surface(0xb7e6b0c0)
08-01 01:49:25.949+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e52dd8), gem(26), surface(0xb7e198f8)
08-01 01:49:25.949+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb7e52dd8), gem(26), surface(0xb7cd8000)
08-01 01:49:25.969+0600 E/EFL     (  295): eo<295> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-01 01:49:25.969+0600 I/APP_CORE(  947): appcore-efl.c: __do_app(520) > [APP 947] Event: RESUME State: PAUSED
08-01 01:49:25.969+0600 I/CAPI_APPFW_APPLICATION(  947): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-01 01:49:25.969+0600 E/cluster-home(  947): homescreen.cpp: OnResume(233) >  app resume
08-01 01:49:25.999+0600 I/AUL_PAD ( 1321): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-01 01:49:25.999+0600 I/AUL_PAD ( 1321): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-01 01:49:25.999+0600 E/AUL_PAD ( 1321): launchpad.c: main(698) > error reading sigchld info
08-01 01:49:26.009+0600 I/ESD     (  843): esd_main.c: __esd_app_dead_handler(1773) > pid: 9720
08-01 01:49:26.009+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9720
08-01 01:49:26.009+0600 W/AUL_AMD (  630): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9720
08-01 01:49:26.009+0600 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1067
08-01 01:49:26.009+0600 I/Tizen::System( 1185): (259) > Active app [com.samsun], current [org.exampl] 
08-01 01:49:26.019+0600 I/MALI    (  947): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
08-01 01:49:26.019+0600 I/MALI    (  295): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb7e1e220), gem(15), surface(0xb7e198f8)
08-01 01:49:26.029+0600 E/RESOURCED(  665): iface.c: lookup_ifname(355) > Please provide valid argument!
08-01 01:49:26.049+0600 I/Tizen::Io( 1185): (729) > Entry not found
08-01 01:49:26.059+0600 E/weather-widget( 1292): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
08-01 01:49:26.079+0600 W/CRASH_MANAGER(11556): worker.c: worker_job(1199) > 1109720626c75146999456
