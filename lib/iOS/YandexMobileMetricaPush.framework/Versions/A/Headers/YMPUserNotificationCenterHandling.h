/*
 *  Version for iOS
 *  © 2016-2019 YANDEX
 *  You may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  https://yandex.com/legal/appmetrica_sdk_agreement/
 */

#if __has_include("YMPDefines.h")
    #import "YMPDefines.h"
#else
    #import <YandexMobileMetricaPush/YMPDefines.h>
#endif

#ifdef YMP_USER_NOTIFICATIONS_CENTER_AVAILABLE

@class UNNotification;
@class UNNotificationResponse;

NS_ASSUME_NONNULL_BEGIN

/** A delegate for manual handling foreground push notifications on iOS 10+.
 Use this delegate if you implement the UNUserNotificationCenterDelegate protocol with custom logic.
 You should implement all methods of UNUserNotificationCenterDelegate and call proper methods of this delegate.

 Implementation of this delegate is provided by [YMPYandexMetricaPush userNotificationCenterHandler].
 */
API_AVAILABLE(ios(10.0))
@protocol YMPUserNotificationCenterHandling <NSObject>

/** Call this method in your implementation of userNotificationCenter:willPresentNotification:withCompletionHandler:.
 */
- (void)userNotificationCenterWillPresentNotification:(UNNotification *)notification;

/** Call this method in your implementation of userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:.
 */
- (void)userNotificationCenterDidReceiveNotificationResponse:(UNNotificationResponse *)response;

/** Call this method in your implementation of userNotificationCenter:openSettingsForNotification:.
 */
- (void)userNotificationCenterOpenSettingsForNotification:(nullable UNNotification *)notification API_AVAILABLE(ios(12.0));

@end

NS_ASSUME_NONNULL_END

#endif
