/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>

/**
 * YMALog provides control over SDK logging.
 *
 * @warning Class is deprecated in favor of #YMAMobileAds
 */
__attribute__((deprecated("[YMAMobileAds enableLogging] should be used instead")))
@interface YMALog : NSObject

/**
 * Enables SDK logs. Logs are disabled by default.
 */
+ (void)enableLogging;

@end
