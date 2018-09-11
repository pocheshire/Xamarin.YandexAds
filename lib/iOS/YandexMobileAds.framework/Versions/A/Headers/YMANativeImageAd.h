/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>
#import <YandexMobileAds/YMANativeGenericAd.h>

@class YMANativeImageAdView;
@protocol YMANativeAdDelegate;

NS_ASSUME_NONNULL_BEGIN

/**
 * YMANativeImageAd allows to bind image ad to view.
 * @see YMANativeGenericAd.h for generic ad methods.
 */
@protocol YMANativeImageAd <YMANativeGenericAd>

/**
 * Sets values of all image ad assets to native image ad view, installs impression and click handlers.
 *
 * @param view Root ad view, superview for all asset views.
 * @param delegate Ad delegate, which provides view controller for presenting modal content and handles ad events.
 * Passed delegate overwrites ad @p delegate property value.
 * @param error Binding error. @see YMANativeAdErrors.h for error codes.
 *
 * @return YES if binding succeeded, otherwise NO.
 */
- (BOOL)bindImageAdToView:(YMANativeImageAdView *)view
                 delegate:(nullable id<YMANativeAdDelegate>)delegate
                    error:(NSError **)error;

@end

NS_ASSUME_NONNULL_END
