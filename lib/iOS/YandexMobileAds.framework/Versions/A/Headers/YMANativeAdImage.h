/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

/**
 * YMANativeAdImage represents image asset. 
 * Size is always available. Image is unavailable until loaded.
 */
@interface YMANativeAdImage : NSObject

/**
 * Image size.
 */
@property (nonatomic, assign, readonly) CGSize size;

/**
 * Loaded image. Image is available only after it has been loaded.
 */
@property (nonatomic, strong, readonly, nullable) UIImage *imageValue;

@end

NS_ASSUME_NONNULL_END
