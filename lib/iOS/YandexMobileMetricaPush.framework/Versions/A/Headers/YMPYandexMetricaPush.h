/*
 *  Version for iOS
 *  © 2016-2019 YANDEX
 *  You may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  https://yandex.com/legal/appmetrica_sdk_agreement/
 */

#import <Foundation/Foundation.h>

#if __has_include("YMPYandexMetricaPushEnvironment.h")
    #import "YMPYandexMetricaPushEnvironment.h"
    #import "YMPUserNotificationCenterDelegate.h"
    #import "YMPUserNotificationCenterHandling.h"
#else
    #import <YandexMobileMetricaPush/YMPYandexMetricaPushEnvironment.h>
    #import <YandexMobileMetricaPush/YMPUserNotificationCenterDelegate.h>
    #import <YandexMobileMetricaPush/YMPUserNotificationCenterHandling.h>
#endif

NS_ASSUME_NONNULL_BEGIN

@interface YMPYandexMetricaPush : NSObject

#ifdef YMP_USER_NOTIFICATIONS_CENTER_AVAILABLE

/** Returning YMPUserNotificationCenterDelegate that handles foreground push notifications on iOS 10+.
 The YMPUserNotificationCenterDelegate protocol is derived from UNUserNotificationCenterDelegate.
 To handle foreground push notifications, execute this line before the application finishes its launching process:

 [UNUserNotificationCenter currentNotificationCenter].delegate = [YMPYandexMetricaPush userNotificationCenterDelegate];

 If you want to handle push notifications on your own, use +userNotificationCenterHandler.

 @return The delegate that implements the YMPUserNotificationCenterDelegate protocol.
 */
+ (id<YMPUserNotificationCenterDelegate>)userNotificationCenterDelegate API_AVAILABLE(ios(10.0));

/** Returning YMPUserNotificationCenterDelegate that allows handling foreground push notifications on iOS 10+.
 Use this delegate if you implement UNUserNotificationCenterDelegate protocol with custom logic.
 You should implement every method from UNUserNotificationCenterDelegate and call proper methods of this delegate.

 If you want a simplier way to handle push notification use +userNotificationCenterDelegate.

 @return The delegate that implements the YMPUserNotificationCenterHandling protocol.
 */
+ (id<YMPUserNotificationCenterHandling>)userNotificationCenterHandler API_AVAILABLE(ios(10.0));

/** Handling a push notification from the notification service extension.
 Should be called in the didReceiveNotificationRequest:withContentHandler: method implementation.

 @param request The current request.
 */
+ (void)handleDidReceiveNotificationRequest:(UNNotificationRequest *)request API_AVAILABLE(ios(10.0));

#endif

/** Setting push notification device token with production environment.
 If value is nil, previously set device token is revoked.
 Should be called after AppMetrica initialization.

 @param data Device token data.
 */
+ (void)setDeviceTokenFromData:(nullable NSData *)data;

/** Setting push notification device token with specific environment.
 If value is nil, previously set device token is revoked.
 Should be called after AppMetrica initialization.

 @param data Device token data.
 @param pushEnvironment Application APNs environment.
 */
+ (void)setDeviceTokenFromData:(nullable NSData *)data pushEnvironment:(YMPYandexMetricaPushEnvironment)pushEnvironment;

/** Handling push notification from application launch options.
 Should be called after AppMetrica initialization.

 @param launchOptions A dictionary that contains information related to the 
 application launch options, potentially including a notification info.
 */
+ (void)handleApplicationDidFinishLaunchingWithOptions:(nullable NSDictionary *)launchOptions;

/** Handling push notification event.
 Should be called after AppMetrica initialization.

 @param userInfo A dictionary that contains information related to the remote notification,
 potentially including a badge number for the app icon, an alert sound,
 an alert message to display to the user, a notification identifier
 and custom data.
 */
+ (void)handleRemoteNotification:(NSDictionary *)userInfo;

/** Returning user data string from push notification payload.

 @param userInfo A dictionary that contains information related to the remote notification,
 potentially including a badge number for the app icon, an alert sound,
 an alert message to display to the user, a notification identifier
 and custom data.
 @return A string with custom user data.
 */
+ (nullable NSString *)userDataForNotification:(NSDictionary *)userInfo;

/** Returning YES if push notification is related to AppMetrica.

 @param userInfo A dictionary that contains information related to the remote notification,
 potentially including a badge number for the app icon, an alert sound,
 an alert message to display to the user, a notification identifier
 and custom data.
 @return YES for SDK related notifications.
 */
+ (BOOL)isNotificationRelatedToSDK:(NSDictionary *)userInfo;

/** Informing the library about appGroup that is shared between the app and notification service extension.
 
 @param appGroup Shared appGroup between the app and notification service extension.
 */
+ (void)setExtensionAppGroup:(NSString *)appGroup;

@end

NS_ASSUME_NONNULL_END
