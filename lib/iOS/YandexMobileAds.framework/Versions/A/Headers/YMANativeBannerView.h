/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <UIKit/UIKit.h>
#import <YandexMobileAds/YMANativeImageLoadingObserver.h>

@protocol YMANativeGenericAd;
@class YMANativeTemplateAppearance;

NS_ASSUME_NONNULL_BEGIN

/**
 * YMANativeBannerView provides template for displaying native ads.
 * Banner appearance such as asset offsets, fonts, colors, sizes, etc.
 * may be confugured with @p applyAppearance: method.
 * YMANativeBannerView is optimized to be displayed in @p UITableView.
 */
@interface YMANativeBannerView : UIView <YMANativeAdImageLoadingObserver>

/**
 * Native ad.
 */
@property (nonatomic, strong, nullable) id<YMANativeGenericAd> ad;

/**
 * Configures banner appearance. Banner appearance is not changed if appearance is modified after this call.
 * Default appearance is used if @p applyAppearance: is not called.
 *
 * @param appearance Banner appearance.
 */
- (void)applyAppearance:(YMANativeTemplateAppearance *)appearance;

/**
 * Calculates height of banner for particular ad, apperance and width.
 *
 * @param ad Native ad.
 * @param width Banner width.
 * @param appearance Banner appearance which is used as parameter in @p applyAppearance: method for banner.
 * Default appearance is used if @p appearance is nil.
 *
 * @return Banner height.
 */
+ (CGFloat)heightWithAd:(id<YMANativeGenericAd>)ad
                  width:(CGFloat)width
             appearance:(nullable YMANativeTemplateAppearance *)appearance;

@end

NS_ASSUME_NONNULL_END
