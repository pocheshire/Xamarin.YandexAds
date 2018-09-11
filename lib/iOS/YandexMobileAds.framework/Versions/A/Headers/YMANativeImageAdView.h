/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <UIKit/UIKit.h>

@protocol YMANativeImageAd;

/**
 * YMANativeImageAdView represents view for image ad type. It contains views for all of image ad assets.
 * YMANativeImageAd provided by loader should be used to set ad assets into view.
 */

NS_ASSUME_NONNULL_BEGIN

@interface YMANativeImageAdView : UIView

/**
 * Button for user feedback.
 */
@property (nonatomic, weak, nullable) IBOutlet UIButton *feedbackButton;

/**
 * ImageView for ad image.
 */
@property (nonatomic, weak) IBOutlet UIImageView *imageView;

/**
 * Ad, which is bound to view. Ad automatically sets this property during binding.
 * Ad stops all activities such as visibility monitoring when it is released.
 */
@property (nonatomic, strong, readonly, nullable) id<YMANativeImageAd> ad;

@end

NS_ASSUME_NONNULL_END
