/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>

/* Yandex Mobile Native Ads error domain. */
extern NSString *const kYMANativeAdErrorDomain;

/* Yandex Mobile Ads error codes. */
typedef NS_ENUM(NSUInteger, YMANativeErrorCode) {
    /* Returned for attempt to bind ad to view without providing view for any of required assets. */
    YMANativeAdErrorCodeNoViewForAsset,
    /* Returned for attempt to bind ad to invalid view. */
    YMANativeAdErrorCodeInvalidViewForBinding,
    /* Returned for attempt to bind invalid ad. */
    YMANativeAdErrorCodeInvalidBinder,
    /* Returned for attempt to bind ad to view which doesn't correspond ad type. */
    YMANativeAdErrorCodeAdTypeMismatch
};
