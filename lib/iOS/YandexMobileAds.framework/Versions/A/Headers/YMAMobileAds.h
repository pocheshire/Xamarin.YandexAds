/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>
#import <YandexMobileAds/YMADeviceTypes.h>

@interface YMAMobileAds : NSObject

/**
 * Enables SDK logs. Logs are disabled by default.
 */
+ (void)enableLogging;

/**
 * Returns SDK version.
 *
 * @return SDK version in X.YY format.
 */
+ (NSString *)SDKVersion;

/** Enable/disable location tracking.
 Location is collected automatically if tracking is enabled and application has appropriate permission.
 SDK does not prompt user to allow location tracking.
 Location which is passed in YMAAdRequest overrides location which is collected automatically.
 Automatic location tracking is enabled by default.
 
 @param enabled NO to disable automatic location tracking; otherwise location is tracked automatically.
 */
+ (void)setLocationTrackingEnabled:(BOOL)enabled;

/** Enable/disable ad visibility validation error indicator.
 Indicator is enabled for simulator by default. Pass YMADeviceTypeNone to disable indicator for all devices.
 Indicator is not displayed in apps installed from AppStore regardless of passed device type.
 
 @param deviceType Device type for showing ad visibility validation error indicator.
 */
+ (void)enableVisibilityErrorIndicatorForDeviceType:(YMADeviceType)deviceType;

@end
