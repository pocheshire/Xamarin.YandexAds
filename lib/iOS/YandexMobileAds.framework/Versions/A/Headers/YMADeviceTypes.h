/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>

/* Yandex Mobile Ads options for device type. */
typedef NS_OPTIONS(NSUInteger, YMADeviceType) {
    /* No device */
    YMADeviceTypeNone = 0,
    /* Hardware device */
    YMADeviceTypeHardware = 1 << 0,
    /* Simulator */
    YMADeviceTypeSimulator  = 1 << 1
};
