S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.4.0.3
Build-Number: Z130HDDU0CPD6
Build-Date: 2016.04.28 20:23:28

Crash Information
Process Name: wifi
PID: 2343
Date: 2016-07-05 15:16:17+0600
Executable File Path: /opt/usr/apps/org.example.wifi/bin/wifi
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2343, uid 5000)

Register Information
r0   = 0xb8ca4a20, r1   = 0x00000000
r2   = 0x0000004e, r3   = 0xd6a40d00
r4   = 0xbefa0eb0, r5   = 0x00000002
r6   = 0x00000008, r7   = 0xbefa4390
r8   = 0xb2a60f24, r9   = 0x00000000
r10  = 0xb2a7b311, fp   = 0xb8c81d28
ip   = 0xb6774fb4, sp   = 0xbefa0e48
lr   = 0xb2a7b4a5, pc   = 0xb6774fc8
cpsr = 0x200b0010

Memory Information
MemTotal:   730440 KB
MemFree:     73836 KB
Buffers:     29860 KB
Cached:     260348 KB
VmPeak:     107320 KB
VmSize:     107316 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24364 KB
VmRSS:       24364 KB
VmData:      34516 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2343 TID = 2343
2343 2358 2743 2744 

Maps Information
b1501000 b1d00000 rw-p [stack:2744]
b1e29000 b2628000 rw-p [stack:2743]
b2628000 b2639000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2649000 b264e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b26da000 b26e2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b26f3000 b26f4000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2704000 b2718000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b272c000 b272d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b273d000 b2740000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2751000 b2752000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2762000 b2764000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2774000 b2776000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2786000 b2796000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b27a6000 b27b2000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2a02000 b2a19000 r-xp /usr/lib/libnetwork.so.0.0.0
b2a2a000 b2a31000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2a42000 b2a51000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.62
b2a63000 b2a69000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2a79000 b2a7d000 r-xp /opt/usr/apps/org.example.wifi/bin/wifi
b2b9e000 b2c81000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2cb8000 b2ce0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2cf2000 b34f1000 rw-p [stack:2358]
b34f1000 b34f3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3503000 b350d000 r-xp /lib/libnss_files-2.20-2014.11.so
b351e000 b3527000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3538000 b3549000 r-xp /lib/libnsl-2.20-2014.11.so
b355c000 b3562000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3573000 b3574000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b359c000 b35a3000 r-xp /usr/lib/libminizip.so.1.0.0
b35b3000 b35b8000 r-xp /usr/lib/libstorage.so.0.1
b35c8000 b361d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3633000 b3647000 r-xp /usr/lib/libcapi-media-camera.so.0.1.89
b3657000 b369b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b36ab000 b36b3000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b36c3000 b36f3000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3706000 b37bf000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b37d3000 b3827000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3838000 b3853000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3863000 b3924000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3937000 b3949000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3959000 b395d000 r-xp /usr/lib/libogg.so.0.7.1
b396d000 b398f000 r-xp /usr/lib/libvorbis.so.0.4.3
b399f000 b3a83000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b3a9f000 b3aac000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3abd000 b3b00000 r-xp /usr/lib/libsndfile.so.1.0.25
b3b15000 b3b5c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3b6d000 b3b73000 r-xp /usr/lib/libjson-c.so.2.0.1
b3b84000 b3b8b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3b9b000 b3bdb000 r-xp /usr/lib/libmdm.so.1.2.10
b3beb000 b3bf3000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3c02000 b3c12000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3c33000 b3c93000 r-xp /usr/lib/libasound.so.2.0.0
b3ca5000 b3cdb000 r-xp /usr/lib/libpulse.so.0.16.2
b3cec000 b3cef000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3cff000 b3d02000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d12000 b3d17000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3d27000 b3d28000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3d38000 b3d43000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3d57000 b3d5e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d6e000 b3d74000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d84000 b3d89000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3d99000 b3db4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3dc4000 b3dcb000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3ddb000 b3dde000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3def000 b3e1d000 r-xp /usr/lib/libidn.so.11.5.44
b3e2d000 b3e43000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3e54000 b3e5e000 r-xp /usr/lib/libcares.so.2.1.0
b3e6e000 b3e78000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.31
b3e88000 b3e8a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.19
b3e9a000 b3e9b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3eab000 b3eaf000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3ec0000 b3ee8000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ef9000 b3f22000 r-xp /usr/lib/libturbojpeg.so
b3f42000 b3f48000 r-xp /usr/lib/libgif.so.4.1.6
b3f58000 b3f9e000 r-xp /usr/lib/libcurl.so.4.3.0
b3faf000 b3fd0000 r-xp /usr/lib/libexif.so.12.3.3
b3feb000 b4000000 r-xp /usr/lib/libtts.so
b4011000 b4019000 r-xp /usr/lib/libfeedback.so.0.1.4
b4029000 b40e9000 r-xp /usr/lib/libdali-core.so.0.0.0
b40f4000 b41e7000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b4207000 b42e1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b42f8000 b42fa000 r-xp /usr/lib/libboost_system.so.1.51.0
b430a000 b4310000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b4320000 b4343000 r-xp /usr/lib/libboost_thread.so.1.51.0
b4354000 b4356000 r-xp /usr/lib/libappsvc.so.0.1.0
b4366000 b4368000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4379000 b437e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4395000 b4397000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b43a7000 b43ae000 r-xp /usr/lib/libsensord-share.so
b43be000 b43d6000 r-xp /usr/lib/libsensor.so.1.1.0
b43e7000 b43ea000 r-xp /usr/lib/libXv.so.1.0.0
b43fa000 b43ff000 r-xp /usr/lib/libutilX.so.1.1.0
b440f000 b4414000 r-xp /usr/lib/libappcore-common.so.1.1
b4424000 b442b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.14
b443e000 b4442000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4453000 b451d000 r-xp /usr/lib/libCOREGL.so.4.0
b4534000 b4537000 r-xp /usr/lib/libuuid.so.1.3.0
b4548000 b455f000 r-xp /usr/lib/libblkid.so.1.1.0
b4570000 b4572000 r-xp /usr/lib/libXau.so.6.0.0
b4582000 b4585000 r-xp /usr/lib/libEGL.so.1.4
b458d000 b4593000 r-xp /usr/lib/libxcb-render.so.0.0.0
b45a3000 b45a5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45b6000 b45c4000 r-xp /usr/lib/libGLESv2.so.2.0
b45cd000 b462f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4644000 b465c000 r-xp /usr/lib/libmount.so.1.1.0
b466d000 b4681000 r-xp /usr/lib/libxcb.so.1.1.0
b4692000 b4699000 r-xp /lib/libcrypt-2.20-2014.11.so
b46d1000 b46e2000 r-xp /usr/lib/libsharedrule-client.so.1.0.0
b46f3000 b46f5000 r-xp /usr/lib/libiri.so
b4705000 b4710000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4721000 b4736000 r-xp /lib/libexpat.so.1.5.2
b4748000 b4806000 r-xp /usr/lib/libcairo.so.2.11200.14
b4819000 b4821000 r-xp /usr/lib/libdrm.so.2.4.0
b4831000 b4834000 r-xp /usr/lib/libdri2.so.0.0.0
b4845000 b4893000 r-xp /usr/lib/libssl.so.1.0.0
b48a8000 b48b4000 r-xp /usr/lib/libeeze.so.1.13.0
b48c4000 b48cd000 r-xp /usr/lib/libethumb.so.1.13.0
b48dd000 b48e0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b48f0000 b4aa7000 r-xp /usr/lib/libcrypto.so.1.0.0
b56fe000 b5707000 r-xp /usr/lib/libXi.so.6.1.0
b5717000 b5719000 r-xp /usr/lib/libXgesture.so.7.0.0
b5729000 b572d000 r-xp /usr/lib/libXtst.so.6.1.0
b573d000 b5743000 r-xp /usr/lib/libXrender.so.1.3.0
b5753000 b5759000 r-xp /usr/lib/libXrandr.so.2.2.0
b576a000 b576c000 r-xp /usr/lib/libXinerama.so.1.0.0
b577c000 b577f000 r-xp /usr/lib/libXfixes.so.3.1.0
b578f000 b579a000 r-xp /usr/lib/libXext.so.6.4.0
b57aa000 b57ac000 r-xp /usr/lib/libXdamage.so.1.1.0
b57bc000 b57be000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57cf000 b58b1000 r-xp /usr/lib/libX11.so.6.3.0
b58c4000 b58cb000 r-xp /usr/lib/libXcursor.so.1.0.2
b58db000 b58f3000 r-xp /usr/lib/libudev.so.1.6.0
b58f5000 b58f8000 r-xp /lib/libattr.so.1.1.0
b5908000 b5928000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b592a000 b592f000 r-xp /usr/lib/libffi.so.6.0.2
b593f000 b5957000 r-xp /lib/libz.so.1.2.8
b5967000 b5969000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5979000 b5a4e000 r-xp /usr/lib/libxml2.so.2.9.2
b5a63000 b5afe000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b1a000 b5b1d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b2d000 b5b46000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b57000 b5b68000 r-xp /lib/libresolv-2.20-2014.11.so
b5b7c000 b5bf6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5c0b000 b5c0d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c1d000 b5c24000 r-xp /usr/lib/libembryo.so.1.13.0
b5c34000 b5c4c000 r-xp /usr/lib/libpng12.so.0.50.0
b5c5d000 b5c80000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ca1000 b5cb5000 r-xp /usr/lib/libector.so.1.13.0
b5cc6000 b5cde000 r-xp /usr/lib/liblua-5.1.so
b5cef000 b5d46000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d5a000 b5d82000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d93000 b5da6000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db7000 b5dee000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dff000 b5e0d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1d000 b5e25000 r-xp /usr/lib/libtbm.so.1.0.0
b5e35000 b5e42000 r-xp /usr/lib/libeio.so.1.13.0
b5e52000 b5e54000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e64000 b5e69000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e79000 b5e90000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea2000 b5ec2000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed2000 b5ef2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef4000 b5efa000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f0a000 b5f1b000 r-xp /usr/lib/libemotion.so.1.13.0
b5f2c000 b5f33000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f43000 b5f52000 r-xp /usr/lib/libeo.so.1.13.0
b5f63000 b5f75000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f86000 b5f8b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f9b000 b5fb4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc4000 b5fe1000 r-xp /usr/lib/libeet.so.1.13.0
b5ffa000 b6042000 r-xp /usr/lib/libeina.so.1.13.0
b6053000 b6063000 r-xp /usr/lib/libefl.so.1.13.0
b6074000 b6159000 r-xp /usr/lib/libicuuc.so.51.1
b6176000 b62b6000 r-xp /usr/lib/libicui18n.so.51.1
b62cd000 b6305000 r-xp /usr/lib/libecore_x.so.1.13.0
b6317000 b631a000 r-xp /lib/libcap.so.2.21
b632a000 b6353000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6364000 b636b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637d000 b63b4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c5000 b64b0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c3000 b653c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654e000 b6553000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6563000 b656d000 r-xp /usr/lib/libvconf.so.0.2.45
b657d000 b657f000 r-xp /usr/lib/libvasum.so.0.3.1
b658f000 b6591000 r-xp /usr/lib/libttrace.so.1.1
b65a1000 b65a4000 r-xp /usr/lib/libiniparser.so.0
b65b4000 b65da000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ea000 b65ef000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6600000 b6617000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6628000 b6693000 r-xp /lib/libm-2.20-2014.11.so
b66a4000 b66aa000 r-xp /lib/librt-2.20-2014.11.so
b66bb000 b66c8000 r-xp /usr/lib/libunwind.so.8.0.1
b66fe000 b6822000 r-xp /lib/libc-2.20-2014.11.so
b6837000 b6850000 r-xp /lib/libgcc_s-4.9.so.1
b6860000 b6942000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6953000 b697d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698e000 b69ca000 r-xp /usr/lib/libsystemd.so.0.4.0
b69cc000 b6a4e000 r-xp /usr/lib/libedje.so.1.13.0
b6a61000 b6a7f000 r-xp /usr/lib/libecore.so.1.13.0
b6a9f000 b6c26000 r-xp /usr/lib/libevas.so.1.13.0
b6c5b000 b6c6f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c83000 b6eb8000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee6000 b6eea000 r-xp /usr/lib/libsmack.so.1.0.0
b6efa000 b6f01000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f11000 b6f13000 r-xp /usr/lib/libdlog.so.0.0.0
b6f23000 b6f26000 r-xp /usr/lib/libbundle.so.0.1.22
b6f36000 b6f38000 r-xp /lib/libdl-2.20-2014.11.so
b6f49000 b6f61000 r-xp /usr/lib/libaul.so.0.1.0
b6f75000 b6f7a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8b000 b6f98000 r-xp /usr/lib/liblptcp.so
b6faa000 b6fae000 r-xp /usr/lib/libsys-assert.so
b6fbf000 b6fdf000 r-xp /lib/ld-2.20-2014.11.so
b6ff0000 b6ff5000 r-xp /usr/bin/launchpad-loader
b8aac000 b8da9000 rw-p [heap]
bef85000 befa6000 rw-p [stack]
b8aac000 b8da9000 rw-p [heap]
bef85000 befa6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2343)
Call Stack Count: 1
 0: strstr + 0x14 (0xb6774fc8) [/lib/libc.so.6] + 0x76fc8
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
o_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
07-05 15:15:58.831+0600 I/APP_CORE( 1458): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
07-05 15:15:58.831+0600 I/APP_CORE( 1458): appcore-efl.c: __do_app(637) > [APP 1458] Initial Launching, call the resume_cb
07-05 15:15:58.831+0600 I/CAPI_APPFW_APPLICATION( 1458): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
07-05 15:15:58.831+0600 I/CISS    ( 1458): ciss-main.c: __ciss_app_resume(182) > [CISS] Enter
07-05 15:15:58.831+0600 I/CISS    ( 1458): ciss-main.c: __ciss_app_resume(209) > [CISS] win=0x0x80004a26 main=0x0x8000a654
07-05 15:15:58.831+0600 I/CISS    ( 1458): ciss-ussd.c: _ciss_create_ussd_view(127) > [CISS] Enter
07-05 15:15:58.831+0600 I/CISS    ( 1458): ciss-ussd.c: _ciss_create_ussd_view(135) > [CISS] [CISS-USSD]ad->tapi_event.event_type = 100
07-05 15:15:58.841+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.841+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.851+0600 I/CISS    ( 1458): ciss-widget.c: _ciss_create_entry(597) > [CISS] Enter
07-05 15:15:58.861+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.861+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.871+0600 I/QUICKPANEL( 1026): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
07-05 15:15:58.871+0600 W/QUICKPANEL( 1026): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
07-05 15:15:58.871+0600 I/QUICKPANEL( 1026): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: com.samsung.message-lite, insert: 1[0;m
07-05 15:15:58.892+0600 W/LOCKSCREEN(  869): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
07-05 15:15:58.892+0600 E/LOCKSCREEN(  869): contextual-info.c: contextual_info_effect_notification(1544) > [contextual_info_effect_notification:1544:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
07-05 15:15:58.892+0600 E/LOCKSCREEN(  869): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
07-05 15:15:58.892+0600 W/LOCKSCREEN(  869): daemon.c: lockd_event(1029) > [lockd_event:1029:W] event:80000:VIEW_IDLE
07-05 15:15:58.892+0600 W/LOCKSCREEN(  869): daemon.c: _event_route(839) > [_event_route:839:W] event:80000 event_info:0
07-05 15:15:58.902+0600 E/QUICKPANEL( 1026): NotificationItemModel.cpp: __getIconPath(1346) > [0;31m* Critical * length error[0][0;m
07-05 15:15:58.902+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.902+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.902+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.902+0600 E/QUICKPANEL( 1026): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
07-05 15:15:58.902+0600 W/QUICKPANEL( 1026): NotificationItemModel.cpp: __addNotification(637) > [0;35mcom.samsung.message-lite - notification is inserted.[0;m
07-05 15:15:58.912+0600 I/QUICKPANEL( 1026): ScrollContainerViManager.cpp: startAnimation(80) > [0;32mOther animation is playing.[0;m
07-05 15:15:58.912+0600 W/QUICKPANEL( 1026): NotificationItemModel.cpp: insertNotification(237) > [0;35mEvent notification is inserted.[0;m
07-05 15:15:58.912+0600 E/EFL     ( 1026): eo<1026> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
07-05 15:15:58.922+0600 I/QUICKPANEL( 1026): ScrollContainerViManager.cpp: __onAnimationFinished(460) > [0;32mNext animation is started.[0;m
07-05 15:15:58.922+0600 E/EFL     ( 1026): eo<1026> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
07-05 15:15:58.922+0600 I/QUICKPANEL( 1026): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
07-05 15:15:58.922+0600 E/LOCKSCREEN(  869): notification-panel.c: notification_panel_stop(388) > [notification_panel_stop:388:E] Not registered
07-05 15:15:58.922+0600 E/TIZEN_N_SYSTEM_SETTINGS( 1472): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=2
07-05 15:15:58.922+0600 E/TIZEN_N_SYSTEM_SETTINGS( 1472): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 2, key = 2, type = 0
07-05 15:15:58.922+0600 I/Tizen::System( 1472): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-05 15:15:58.922+0600 I/Tizen::System( 1472): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-05 15:15:58.922+0600 I/Tizen::System( 1472): (355) > Try to awake client processes.
07-05 15:15:58.922+0600 I/Tizen::System( 1472): (362) > Event is delivered to b8961488.
07-05 15:15:58.942+0600 E/EFL     ( 1458): elementary<1458> elm_entry.c:7898 elm_entry_cursor_handler_disabled_set() will be deprecated!!!
07-05 15:15:58.942+0600 I/CISS    ( 1458): ciss-widget.c: _ciss_create_entry(607) > [CISS] Exit
07-05 15:15:58.942+0600 I/CISS    ( 1458): ciss-widget.c: _ciss_create_cutlink(1232) > [CISS] Enter
07-05 15:15:58.942+0600 I/CISS    ( 1458): ciss-widget.c: __ciss_match_cb(1221) > [CISS] Enter
07-05 15:15:58.952+0600 E/EFL     ( 1026): edje<1026> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/listitem/notification has a non-fixed part 'elm.text.time'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-05 15:15:58.962+0600 I/CISS    ( 1458): ciss-widget.c: __ciss_match_cb(1221) > [CISS] Enter
07-05 15:15:58.962+0600 I/CISS    ( 1458): ciss-widget.c: __ciss_match_cb(1221) > [CISS] Enter
07-05 15:15:58.972+0600 I/CISS    ( 1458): ciss-widget.c: _ciss_create_cutlink(1258) > [CISS] [CISS-MMI] p_cutlink_string = Balance:306.65TK Validity:Aug 03 2016<br/>Need balance?Reply 1 for 10Tk balance. 12.39Tk will be charged tomorrow
07-05 15:15:58.972+0600 I/CISS    ( 1458): ciss-widget.c: _ciss_create_cutlink(1270) > [CISS] Leave
07-05 15:15:59.082+0600 E/EFL     (  685): <685> lib/ecore_ipc/ecore_ipc.c:803 ecore_ipc_client_send() safety check failed: !cl->client is true
07-05 15:15:59.082+0600 I/CISS    ( 1458): ciss-ussd.c: _ciss_create_ussd_view(208) > [CISS] require action
07-05 15:15:59.202+0600 I/CISS    ( 1458): ciss-ussd.c: _ciss_create_ussd_view(243) > [CISS] Leave
07-05 15:15:59.312+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76859b0), gem(23), surface(0xb76e9db8)
07-05 15:15:59.342+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb767bbf0), gem(26), surface(0xb76edf58)
07-05 15:15:59.722+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:15:59.732+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:15:59.732+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:15:59.732+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:15:59.732+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:15:59.732+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:15:59.732+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:15:59.812+0600 E/EFL     ( 1458): ecore_x<1458> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=201099
07-05 15:15:59.892+0600 E/EFL     ( 1458): ecore_x<1458> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=201180
07-05 15:15:59.902+0600 I/CISS    ( 1458): ciss-ussd.c: _ciss_ussd_quit_cb(55) > [CISS] Enter
07-05 15:15:59.902+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_send_tapi_request(146) > [CISS] Enter
07-05 15:15:59.902+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_send_tapi_request(180) > [CISS] [CISS-ENGINE] ss_flavor= 0,0
07-05 15:15:59.902+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_send_tapi_request(395) > [CISS] processUnstructuredSS_Request
07-05 15:15:59.902+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_send_tapi_request(403) > [CISS] [CISS-ENGINE] stUssdRecord.Length = 0, stUssdRecord.ussd_string = 
07-05 15:15:59.913+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_send_tapi_request(438) > [CISS] Leave
07-05 15:15:59.923+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 22
07-05 15:15:59.923+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(1207) > app status : 5
07-05 15:15:59.923+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.ciss(1458)
07-05 15:15:59.923+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1458, appid: com.samsung.ciss, status: bg
07-05 15:15:59.923+0600 I/CAPI_APPFW_APPLICATION( 1458): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
07-05 15:15:59.923+0600 I/CISS    ( 1458): ciss-main.c: __ciss_app_pause(154) > [CISS] Enter
07-05 15:15:59.983+0600 I/CAPI_APPFW_APPLICATION( 1458): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
07-05 15:15:59.983+0600 I/CISS    ( 1458): ciss-main.c: __ciss_app_terminate(115) > [CISS] Enter
07-05 15:15:59.993+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:15:59.993+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __windowFocusInCb(986) > [0;34m>>>HIT<<<[0;m
07-05 15:15:59.993+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __resetMissedCallCount(572) > [0;34m>>>HIT<<<[0;m
07-05 15:16:00.003+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76c1af0), gem(22), surface(0xb76f3b38)
07-05 15:16:00.003+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76859b0), gem(23), surface(0xb76e27f8)
07-05 15:16:00.023+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:00.053+0600 I/Tizen::System( 1472): (259) > Active app [com.samsun], current [com.samsun] 
07-05 15:16:00.053+0600 I/Tizen::System( 1472): (273) > Current App[com.samsun] is already actived.
07-05 15:16:00.063+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_tapi_event_clean(1308) > [CISS] ad->is_ussd_request = 0
07-05 15:16:00.063+0600 I/CISS    ( 1458): ciss-main.c: __ciss_app_terminate(149) > [CISS] Leave
07-05 15:16:00.083+0600 I/CISS    ( 1458): ciss-tapi-request.c: __ciss_ss_ussd_resp_cb(1398) > [CISS] Enter
07-05 15:16:00.083+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_tapi_sat_ussd_resp_handle(1128) > [CISS] Enter
07-05 15:16:00.083+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_tapi_sat_ussd_resp_handle(1179) > [CISS] result=0x0 ad->is_sat_request=0
07-05 15:16:00.083+0600 I/CISS    ( 1458): ciss-tapi-request.c: _ciss_tapi_sat_ussd_resp_handle(1223) > [CISS] TAPI_SS_USSD_TYPE_USER_REL
07-05 15:16:00.093+0600 I/PHONE   ( 1211): PhLogDbMgr.cpp: updateMissedLogDbAsSeen(756) > [0;32mBEGIN >>>>[0;m
07-05 15:16:00.093+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __windowFocusInCb(986) > [0;34m>>>HIT<<<[0;m
07-05 15:16:00.093+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: __resetMissedCallCount(572) > [0;34m>>>HIT<<<[0;m
07-05 15:16:00.143+0600 I/PHONE   ( 1211): PhLogDbMgr.cpp: updateMissedLogDbAsSeen(756) > [0;32mBEGIN >>>>[0;m
07-05 15:16:00.363+0600 I/AUL_PAD ( 1455): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1458 pgid = 1458
07-05 15:16:00.363+0600 I/AUL_PAD ( 1455): sigchild.h: __sigchild_action(143) > dead_pid(1458)
07-05 15:16:00.373+0600 E/VCONF   ( 2616): vconf.c: vconf_get_bool(2736) > The type(41) of keynode(db/SyncML/oma-dm-service/fmmLockIsSet) is not BOOL
07-05 15:16:00.393+0600 I/AUL_PAD ( 1455): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
07-05 15:16:00.393+0600 I/AUL_PAD ( 1455): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
07-05 15:16:00.393+0600 E/AUL_PAD ( 1455): launchpad.c: main(698) > error reading sigchld info
07-05 15:16:00.393+0600 I/ESD     (  934): esd_main.c: __esd_app_dead_handler(1773) > pid: 1458
07-05 15:16:00.393+0600 I/Tizen::App( 1472): (243) > App[com.samsung.ciss] pid[1458] terminate event is forwarded
07-05 15:16:00.393+0600 I/Tizen::System( 1472): (256) > osp.accessorymanager.service provider is found.
07-05 15:16:00.393+0600 I/Tizen::System( 1472): (196) > Accessory Owner is removed [com.samsung.ciss, 1458, ]
07-05 15:16:00.393+0600 I/Tizen::System( 1472): (256) > osp.system.service provider is found.
07-05 15:16:00.393+0600 I/Tizen::App( 1472): (506) > TerminatedApp(com.samsung.ciss)
07-05 15:16:00.393+0600 I/Tizen::App( 1472): (512) > Not registered pid(1458)
07-05 15:16:00.393+0600 I/Tizen::System( 1472): (246) > Terminated app [com.samsung.ciss]
07-05 15:16:00.393+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:16:00.393+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1458
07-05 15:16:00.393+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 1458
07-05 15:16:00.403+0600 E/RESOURCED(  689): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.257
07-05 15:16:00.403+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:16:00.403+0600 I/Tizen::App( 1472): (782) > Finished invoking application event listener for com.samsung.ciss, 1458.
07-05 15:16:00.483+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(195) > ""
07-05 15:16:00.483+0600 E/UXT     (  685): uxt_util.c: uxt_util_get_date_time_text_by_locale(397) > text : 3:16 p.m.
07-05 15:16:00.483+0600 I/INDICATOR(  685): clock.c: getTimeFormatted(176) > "time format : 3:16 p.m."
07-05 15:16:00.483+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(244) > "time format : 3:16 p.m."
07-05 15:16:00.483+0600 W/INDICATOR(  685): clock.c: indicator_clock_changed_cb(272) > 
07-05 15:16:00.483+0600 I/INDICATOR(  685): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145636833 Time: <font_size=31> </font_size> <font_size=31> 3:16 p.m.</font_size></font>"
07-05 15:16:00.503+0600 I/MALI    ( 1211): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
07-05 15:16:00.713+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
07-05 15:16:00.913+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:01.174+0600 E/EFL     ( 1211): ecore_x<1211> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=202417
07-05 15:16:01.174+0600 E/EFL     ( 1211): ecore_x<1211> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=202469
07-05 15:16:01.174+0600 I/PHONE   ( 1211): CtTabView.cpp: onPop(233) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.174+0600 I/PHONE   ( 1211): PhDialerView.cpp: onTabPop(161) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.174+0600 I/PHONE   ( 1211): PhLogMainListView.cpp: onTabPop(543) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.174+0600 I/PHONE   ( 1211): CtListView.cpp: onTabPop(1485) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.174+0600 I/PHONE   ( 1211): CtListView.cpp: __cleanSearchbar(2271) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.174+0600 E/EFL     ( 1211): <1211> elm_main.c:1298 elm_object_part_content_get() safety check failed: obj == NULL
07-05 15:16:01.174+0600 E/PHONE   ( 1211): CtListView.cpp: __clearGalSearchItems(4921) > [0;31m* Critical * __genlist is NULL[0;m
07-05 15:16:01.174+0600 I/WAPP    ( 1211): WNaviframe.cpp: onLastItemPop(252) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.184+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(880) status(3)
07-05 15:16:01.184+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
07-05 15:16:01.184+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
07-05 15:16:01.184+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(880)
07-05 15:16:01.184+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 880, appid: com.samsung.homescreen, status: fg
07-05 15:16:01.194+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb767bbf0), gem(12), surface(0xb76635c8)
07-05 15:16:01.194+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:16:01.204+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb767bbf0), gem(12), surface(0xb76f3108)
07-05 15:16:01.214+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:01.234+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 36
07-05 15:16:01.244+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76df8f8), gem(16), surface(0xb769cfa0)
07-05 15:16:01.244+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76df8f8), gem(16), surface(0xb76dc208)
07-05 15:16:01.274+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:01.274+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:01.284+0600 I/Tizen::System( 1472): (259) > Active app [com.samsun], current [com.samsun] 
07-05 15:16:01.284+0600 I/Tizen::System( 1472): (273) > Current App[com.samsun] is already actived.
07-05 15:16:01.314+0600 I/APP_CORE(  880): appcore-efl.c: __do_app(520) > [APP 880] Event: RESUME State: PAUSED
07-05 15:16:01.314+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
07-05 15:16:01.314+0600 E/cluster-home(  880): homescreen.cpp: OnResume(233) >  app resume
07-05 15:16:01.324+0600 I/APP_CORE( 1211): appcore-efl.c: __do_app(520) > [APP 1211] Event: PAUSE State: RUNNING
07-05 15:16:01.324+0600 I/CAPI_APPFW_APPLICATION( 1211): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
07-05 15:16:01.324+0600 I/WAPP    ( 1211): WApp.cpp: __onPause(79) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.324+0600 I/PHONE   ( 1211): ContactsApp.cpp: onPause(73) > [0;34m>>>HIT<<<[0;m
07-05 15:16:01.324+0600 W/UI_GADGET( 1211): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
07-05 15:16:01.334+0600 I/MALI    (  880): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xac381890), gem(17), surface(0xac393b28)
07-05 15:16:01.334+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76f52e0), gem(14), surface(0xb76cafc0)
07-05 15:16:01.334+0600 I/INDICATOR(  685): connection.c: ps_type_callback(568) > "ps_type_callback 3"
07-05 15:16:01.354+0600 I/TIZEN_N_EFL_UTIL_WINDOW( 1211): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 25
07-05 15:16:01.354+0600 E/APP_CORE( 1211): appcore-efl.c: _capture_and_make_file(1631) > win[3c00003] widget[480] height[800]
07-05 15:16:01.354+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 33
07-05 15:16:01.374+0600 E/weather-widget( 1343): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
07-05 15:16:01.384+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(1211) status(4)
07-05 15:16:01.384+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.contacts(1211)
07-05 15:16:01.384+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1211, appid: com.samsung.contacts, status: bg
07-05 15:16:01.394+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=202603
07-05 15:16:01.394+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=202686
07-05 15:16:01.394+0600 E/cluster-view(  880): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
07-05 15:16:01.394+0600 E/cluster-view(  880): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
07-05 15:16:01.414+0600 I/CAPI_TELEPHONY( 1186): telephony_network.c: telephony_network_get_type(327) > network_type:[4]
07-05 15:16:01.434+0600 I/CAPI_TELEPHONY( 1186): telephony_network.c: telephony_network_get_cell_id(72) > cell_id:[71923209]
07-05 15:16:01.464+0600 E/weather-widget( 1343): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
07-05 15:16:01.464+0600 E/weather-widget( 1343): WidgetMain.cpp: ResumeWidgetInstance(584) > [0;40;31m[ResumeWidgetInstance(): 584] (widgetViewDataPtr->GetIsFirstCreated() == true) [break][0;m
07-05 15:16:01.464+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
07-05 15:16:01.474+0600 I/CAPI_TELEPHONY( 1186): telephony_network.c: telephony_network_get_lac(46) > lac:[40414]
07-05 15:16:01.514+0600 I/CAPI_TELEPHONY( 1186): telephony_network.c: telephony_network_get_mcc(166) > mcc:[470]
07-05 15:16:01.534+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76edfd0), gem(14), surface(0xb769cfa0)
07-05 15:16:01.544+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
07-05 15:16:01.544+0600 W/AUL     ( 1343): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1343, appid: com.samsung.weather-m-widget, status: fg
07-05 15:16:01.554+0600 I/CAPI_TELEPHONY( 1186): telephony_network.c: telephony_network_get_mnc(196) > plmn:[47007], length:[5]
07-05 15:16:01.554+0600 I/CAPI_TELEPHONY( 1186): telephony_network.c: telephony_network_get_mnc(207) > mnc:[07]
07-05 15:16:01.604+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=202828
07-05 15:16:01.604+0600 E/cluster-view(  880): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
07-05 15:16:01.614+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=202902
07-05 15:16:01.614+0600 E/cluster-view(  880): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
07-05 15:16:01.654+0600 I/INDICATOR(  685): connection.c: indicator_conn_change_cb(379) > "CONNECTION WiFi Status: 3"
07-05 15:16:01.654+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:01.654+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:01.654+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:01.654+0600 I/MALI    (  880): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
07-05 15:16:01.664+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:01.664+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:01.664+0600 I/MALI    (  880): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
07-05 15:16:01.684+0600 I/MALI    (  880): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
07-05 15:16:03.786+0600 I/APP_CORE(  869): appcore-efl.c: __do_app(520) > [APP 869] Event: MEM_FLUSH State: PAUSED
07-05 15:16:04.917+0600 W/AUL_AMD (  648): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
07-05 15:16:06.359+0600 I/APP_CORE( 1211): appcore-efl.c: __do_app(520) > [APP 1211] Event: MEM_FLUSH State: PAUSED
07-05 15:16:07.720+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:16:07.730+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:16:07.730+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:07.730+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:07.730+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:07.730+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:07.730+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:08.731+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:16:08.741+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:16:08.741+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:08.741+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:08.741+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:08.741+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:08.741+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:08.841+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:09.732+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:16:09.742+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:16:09.742+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:09.742+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:09.742+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:09.742+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:09.742+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:10.223+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=211516
07-05 15:16:10.383+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=211684
07-05 15:16:10.723+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:16:10.733+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:16:10.733+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:10.733+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:10.733+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:10.733+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:10.733+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:10.933+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=212226
07-05 15:16:10.973+0600 W/cluster-home(  880): cluster-data-provider.cpp: OnMainScrollStarted(4740) >  Main Scroll Started
07-05 15:16:10.973+0600 W/cluster-home(  880): cluster-data-provider.cpp: OnMainScrollStarted(4742) >  Main Scroll Started Done
07-05 15:16:11.003+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __provider_pause_cb(304) > widget obj was paused
07-05 15:16:11.003+0600 I/CAPI_WIDGET_APPLICATION( 1343): widget_app.c: __check_status_for_cgroup(152) > enter background group
07-05 15:16:11.003+0600 W/AUL     ( 1343): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 1343, appid: com.samsung.weather-m-widget, status: bg
07-05 15:16:11.083+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=212387
07-05 15:16:11.774+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:12.235+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=213531
07-05 15:16:12.435+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:12.725+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214024
07-05 15:16:12.995+0600 W/cluster-view(  880): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2313) >  booster timer is still running on apps-view, Stop boost timer!!!
07-05 15:16:13.175+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214469
07-05 15:16:13.276+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:13.316+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214609
07-05 15:16:13.576+0600 W/cluster-view(  880): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2313) >  booster timer is still running on apps-view, Stop boost timer!!!
07-05 15:16:14.297+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
07-05 15:16:14.357+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215657
07-05 15:16:14.397+0600 E/EFL     (  880): ecore_x<880> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215696
07-05 15:16:14.407+0600 W/AUL     (  880): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.wifi)
07-05 15:16:14.407+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 1
07-05 15:16:14.407+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(2527) > caller pid : 880
07-05 15:16:14.417+0600 E/RESOURCED(  689): block.c: block_prelaunch_state(138) > insert data org.example.wifi, table num : 2
07-05 15:16:14.417+0600 E/RESOURCED(  689): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
07-05 15:16:14.417+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3074) > loading shared rule
07-05 15:16:14.417+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(285) > Enter
07-05 15:16:14.427+0600 I/SHAREDRULE_CLIENT(  648): SocketConnection.h: SocketConnection(47) > Created
07-05 15:16:14.427+0600 I/SHAREDRULE_SERVER(  595): SocketService.cpp: mainloop(234) > Got incoming connection
07-05 15:16:14.427+0600 I/SHAREDRULE_SERVER(  595): SocketConnection.h: SocketConnection(47) > Created
07-05 15:16:14.427+0600 I/SHAREDRULE_CLIENT(  648): SharedruleClient.cpp: loadSharedrule(305) > return result : 0
07-05 15:16:14.427+0600 W/AUL_AMD (  648): amd_launch.c: _start_app(3081) > pad pid(-5)
07-05 15:16:14.427+0600 W/AUL_PAD ( 1455): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
07-05 15:16:14.427+0600 W/AUL_PAD ( 1455): launchpad.c: __send_result_to_caller(267) > Check app launching
07-05 15:16:14.457+0600 I/CAPI_APPFW_APPLICATION( 2343): app_main.c: ui_app_main(789) > app_efl_main
07-05 15:16:14.457+0600 I/CAPI_APPFW_APPLICATION( 2343): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
07-05 15:16:14.477+0600 E/TBM     ( 2343): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
07-05 15:16:14.537+0600 W/AUL     (  648): app_signal.c: aul_send_app_launch_request_signal(425) > send_app_launch_signal, pid: 2343, appid: org.example.wifi
07-05 15:16:14.537+0600 E/AUL     (  648): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
07-05 15:16:14.547+0600 W/AUL     (  880): launch.c: app_request_to_launchpad(425) > request cmd(1) result(2343)
07-05 15:16:14.547+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:16:14.547+0600 E/CAPI_NETWORK_WIFI( 2343): net_wifi.c: wifi_deactivate(148) > Not initialized
07-05 15:16:14.607+0600 E/RESOURCED(  689): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.wifi
07-05 15:16:14.767+0600 I/CAPI_NETWORK_WIFI( 2343): net_wifi.c: wifi_initialize(74) > Wi-Fi successfully initialized
07-05 15:16:14.767+0600 D/wifi    ( 2343): [wifi_initialize] Success.
07-05 15:16:14.807+0600 I/APP_CORE( 2343): appcore-efl.c: __do_app(520) > [APP 2343] Event: RESET State: CREATED
07-05 15:16:14.807+0600 I/CAPI_APPFW_APPLICATION( 2343): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
07-05 15:16:14.807+0600 E/EFL     ( 2343): edje<2343> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
07-05 15:16:14.807+0600 E/EFL     ( 2343): By the power of Grayskull, your previous Embryo stack is now broken!
07-05 15:16:14.817+0600 E/EFL     ( 2343): edje<2343> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
07-05 15:16:14.817+0600 E/EFL     ( 2343): By the power of Grayskull, your previous Embryo stack is now broken!
07-05 15:16:14.827+0600 E/EFL     ( 2343): edje<2343> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
07-05 15:16:14.827+0600 E/EFL     ( 2343): By the power of Grayskull, your previous Embryo stack is now broken!
07-05 15:16:14.867+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:14.867+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:14.917+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76b9b00), gem(21), surface(0xb767d7e0)
07-05 15:16:14.917+0600 I/Tizen::System( 1472): (259) > Active app [org.exampl], current [com.samsun] 
07-05 15:16:14.917+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:16:14.917+0600 W/APP_CORE( 2343): appcore-efl.c: __show_cb(932) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6800002
07-05 15:16:14.917+0600 W/AUL_AMD (  648): amd_request.c: __request_handler(912) > __request_handler: 35
07-05 15:16:14.927+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:16:14.997+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb767bbf0), gem(14), surface(0xb76cadb0)
07-05 15:16:14.997+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76b9b00), gem(21), surface(0xb76e0e48)
07-05 15:16:14.997+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb767bbf0), gem(14), surface(0xb76dec20)
07-05 15:16:15.007+0600 I/APP_CORE(  880): appcore-efl.c: __do_app(520) > [APP 880] Event: PAUSE State: RUNNING
07-05 15:16:15.007+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
07-05 15:16:15.007+0600 E/cluster-home(  880): homescreen.cpp: OnPause(260) >  app pause
07-05 15:16:15.007+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(880) status(4)
07-05 15:16:15.007+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(880)
07-05 15:16:15.007+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 880, appid: com.samsung.homescreen, status: bg
07-05 15:16:15.017+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(2343) status(3)
07-05 15:16:15.017+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.wifi(2343)
07-05 15:16:15.017+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 2343, appid: org.example.wifi, status: fg
07-05 15:16:15.027+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:16:15.057+0600 I/APP_CORE( 2343): appcore-efl.c: __do_app(520) > [APP 2343] Event: RESUME State: CREATED
07-05 15:16:15.067+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76f52e0), gem(12), surface(0xb76ca958)
07-05 15:16:15.077+0600 I/APP_CORE( 2343): appcore-efl.c: __do_app(635) > Legacy lifecycle: 0
07-05 15:16:15.077+0600 I/APP_CORE( 2343): appcore-efl.c: __do_app(637) > [APP 2343] Initial Launching, call the resume_cb
07-05 15:16:15.077+0600 I/CAPI_APPFW_APPLICATION( 2343): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
07-05 15:16:15.358+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(2343) status(0)
07-05 15:16:15.358+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:16:15.368+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76e9a48), gem(12), surface(0xb76db438)
07-05 15:16:15.568+0600 E/RESOURCED(  689): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.260
07-05 15:16:15.668+0600 I/Tizen::App( 1472): (499) > LaunchedApp(org.example.wifi)
07-05 15:16:15.668+0600 I/Tizen::App( 1472): (733) > Finished invoking application event listener for org.example.wifi, 2343.
07-05 15:16:16.449+0600 I/UXT     ( 2746): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
07-05 15:16:16.539+0600 E/EFL     ( 2343): ecore_x<2343> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=217834
07-05 15:16:16.609+0600 E/EFL     ( 2343): ecore_x<2343> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=217886
07-05 15:16:16.609+0600 E/VCONF   ( 2343): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
07-05 15:16:16.609+0600 E/VCONF   ( 2343): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
07-05 15:16:16.609+0600 E/VCONF   ( 2343): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
07-05 15:16:16.609+0600 E/VCONF   ( 2343): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2343) : db/ise/keysound error
07-05 15:16:16.609+0600 E/VCONF   ( 2343): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
07-05 15:16:16.609+0600 E/VCONF   ( 2343): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
07-05 15:16:16.659+0600 D/wifi    ( 2343): Succeeded to get Wi-Fi device state.
07-05 15:16:16.659+0600 E/EFL     ( 2343): <2343> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
07-05 15:16:17.279+0600 E/EFL     ( 2343): ecore_x<2343> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=218577
07-05 15:16:17.660+0600 E/EFL     ( 2343): <2343> elm_main.c:1251 elm_object_part_text_get() safety check failed: obj == NULL
07-05 15:16:17.660+0600 I/Tizen::Net::Wifi( 1472): (941) > The background scan result updated.
07-05 15:16:17.730+0600 I/CAPI_NETWORK_WIFI( 2343): libnetwork.c: __libnet_update_profile_iterator(230) > Wi-Fi profile count: 7
07-05 15:16:17.730+0600 D/wifi    ( 2343): AP name : BaBu, state : Connected
07-05 15:16:17.730+0600 D/wifi    ( 2343): AP name : NextGen, state : Disconnected
07-05 15:16:17.820+0600 I/Tizen::Net::Wifi( 1472): (1085) > _WifiService is not registered.
07-05 15:16:17.820+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
07-05 15:16:17.820+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:17.820+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:17.820+0600 E/INDICATOR(  685): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
07-05 15:16:17.830+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:17.830+0600 E/INDICATOR(  685): box.c: _update_icon(232) > (!list) -> _update_icon() return
07-05 15:16:17.890+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:17.930+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3367) > pid(880) status(3)
07-05 15:16:17.930+0600 W/AUL_AMD (  648): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
07-05 15:16:17.930+0600 W/AUL_AMD (  648): amd_launch.c: __e17_status_handler(3388) > back key ungrab error
07-05 15:16:17.930+0600 W/AUL     (  648): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(880)
07-05 15:16:17.930+0600 W/AUL     (  648): app_signal.c: aul_send_app_status_change_signal(583) > send_app_status_change_signal, pid: 880, appid: com.samsung.homescreen, status: fg
07-05 15:16:17.930+0600 I/AUL_PAD ( 1455): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2343 pgid = 2343
07-05 15:16:17.930+0600 I/AUL_PAD ( 1455): sigchild.h: __sigchild_action(143) > dead_pid(2343)
07-05 15:16:17.940+0600 E/AUL     (  648): app_signal.c: __app_dbus_signal_filter(82) > reject by security issue - no interface
07-05 15:16:17.980+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76859b0), gem(12), surface(0xb76f4e20)
07-05 15:16:17.990+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76859b0), gem(12), surface(0xb76d7798)
07-05 15:16:17.990+0600 I/MALI    (  880): tizen_buffer.c: tizen_dri2_get_buffers(814) > Re-used flag set for un-cached buffer.
07-05 15:16:18.030+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76edfd0), gem(14), surface(0xb76f4f78)
07-05 15:16:18.040+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(948) > [EGL-X11] eglimage target 0 imported bo(0xb76edfd0), gem(14), surface(0xb76def38)
07-05 15:16:18.040+0600 I/AUL_PAD ( 1455): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
07-05 15:16:18.040+0600 I/AUL_PAD ( 1455): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
07-05 15:16:18.040+0600 E/AUL_PAD ( 1455): launchpad.c: main(698) > error reading sigchld info
07-05 15:16:18.040+0600 I/Tizen::App( 1472): (243) > App[org.example.wifi] pid[2343] terminate event is forwarded
07-05 15:16:18.040+0600 I/Tizen::System( 1472): (256) > osp.accessorymanager.service provider is found.
07-05 15:16:18.040+0600 I/Tizen::System( 1472): (196) > Accessory Owner is removed [org.example.wifi, 2343, ]
07-05 15:16:18.040+0600 I/Tizen::System( 1472): (256) > osp.system.service provider is found.
07-05 15:16:18.040+0600 I/Tizen::App( 1472): (506) > TerminatedApp(org.example.wifi)
07-05 15:16:18.040+0600 I/Tizen::App( 1472): (512) > Not registered pid(2343)
07-05 15:16:18.040+0600 I/Tizen::System( 1472): (246) > Terminated app [org.example.wifi]
07-05 15:16:18.040+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:16:18.040+0600 I/ESD     (  934): esd_main.c: __esd_app_dead_handler(1773) > pid: 2343
07-05 15:16:18.040+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2343
07-05 15:16:18.040+0600 W/AUL_AMD (  648): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2343
07-05 15:16:18.050+0600 E/EFL     (  301): eo<301> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
07-05 15:16:18.050+0600 E/RESOURCED(  689): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.263
07-05 15:16:18.050+0600 I/APP_CORE(  880): appcore-efl.c: __do_app(520) > [APP 880] Event: RESUME State: PAUSED
07-05 15:16:18.050+0600 I/CAPI_APPFW_APPLICATION(  880): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
07-05 15:16:18.050+0600 E/cluster-home(  880): homescreen.cpp: OnResume(233) >  app resume
07-05 15:16:18.070+0600 I/Tizen::System( 1472): (157) > change brightness system value.
07-05 15:16:18.070+0600 I/Tizen::App( 1472): (782) > Finished invoking application event listener for org.example.wifi, 2343.
07-05 15:16:18.100+0600 I/MALI    (  301): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(852) > [EGL-X11] eglimage target 30b0 imported bo(0xb76b9b00), gem(21), surface(0xb76746e0)
07-05 15:16:18.120+0600 E/weather-widget( 1343): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
07-05 15:16:18.120+0600 I/Tizen::System( 1472): (259) > Active app [com.samsun], current [org.exampl] 
07-05 15:16:18.140+0600 I/Tizen::Io( 1472): (729) > Entry not found
07-05 15:16:18.140+0600 E/weather-widget( 1343): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
07-05 15:16:18.160+0600 E/weather-common( 1343): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
07-05 15:16:18.190+0600 W/CRASH_MANAGER( 2761): worker.c: worker_job(1199) > 1102343776966146771017
