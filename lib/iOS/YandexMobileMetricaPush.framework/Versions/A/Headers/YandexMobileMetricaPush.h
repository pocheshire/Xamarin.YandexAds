/*
 *  Version for iOS
 *  © 2016-2019 YANDEX
 *  You may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  https://yandex.com/legal/appmetrica_sdk_agreement/
 */

#if __has_include("YMPYandexMetricaPush.h")
    #import "YMPYandexMetricaPush.h"
    #import "YMPYandexMetricaPushEnvironment.h"
    #import "YMPUserNotificationCenterDelegate.h"
    #import "YMPUserNotificationCenterHandling.h"
    #import "YMPDefines.h"
    #import "YMPVersion.h"
#else
    #import <YandexMobileMetricaPush/YMPYandexMetricaPush.h>
    #import <YandexMobileMetricaPush/YMPYandexMetricaPushEnvironment.h>
    #import <YandexMobileMetricaPush/YMPUserNotificationCenterDelegate.h>
    #import <YandexMobileMetricaPush/YMPUserNotificationCenterHandling.h>
    #import <YandexMobileMetricaPush/YMPDefines.h>
    #import <YandexMobileMetricaPush/YMPVersion.h>
#endif

