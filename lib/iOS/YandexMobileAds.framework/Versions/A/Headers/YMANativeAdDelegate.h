/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

@protocol YMANativeAdDelegate <NSObject>

@optional

/**
 * Should be implemented to present ad content in webview.
 * If method is not implemented, clicks are handled outside of the app with #[UIApplication openURL:].

 * @discussion In iOS one view controller cannot present several modal controllers simultaneously.
 * So returned view controller should be the topmost one.
 *
 * @return View controller which will present modal controller as a response to user interaction with banner.
 */
- (UIViewController *)viewControllerForPresentingModalView;

/**
 * Notifies delegate whenever app becomes inactive after user clicked on an ad
 * that will launch another application (Phone, App Store, SMS).
 *
 * @param ad Ad sending the message.
 */
- (void)nativeAdWillLeaveApplication:(null_unspecified id)ad;

/**
 * Notifies delegate just before presenting user a full screen view, such as in-app browser,
 * in response to clicking on an ad.
 *
 * @param ad Ad sending the message.
 * @param viewController View controller, which is being presented.
 */
- (void)nativeAd:(null_unspecified id)ad willPresentScreen:(nullable UIViewController *)viewController;

/**
 * Notifies delegate just after fullscreen view has been dismissed.
 * This is a counterpart method for #nativeAdController:willPresentScreen:
 *
 * @param ad Ad sending the message.
 * @param viewController View controller, which is being dismissed.
 */
- (void)nativeAd:(null_unspecified id)ad didDismissScreen:(nullable UIViewController *)viewController;

/**
 * Notifies delegate when ad should be closed as a result of user interaction.
 *
 * @param ad Ad sending the message.
 */
- (void)closeNativeAd:(null_unspecified id)ad;

@end

NS_ASSUME_NONNULL_END
