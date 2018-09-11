/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@protocol YMANativeGenericAd;

/**
 * Objects conforming to @p YMANativeAdImageLoadingObserver protocol are notified about image loading progress.
 */
@protocol YMANativeAdImageLoadingObserver <NSObject>

/**
 * Notifies delegate when ad finishes loading images.
 *
 * @param ad Ad sending the message.
 */
- (void)nativeAdDidFinishLoadingImages:(id<YMANativeGenericAd>)ad;

@end

NS_ASSUME_NONNULL_END
