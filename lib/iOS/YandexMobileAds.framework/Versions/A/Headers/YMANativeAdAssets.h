/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>

@class YMANativeAdImage;

/**
 * Ad assets.
 */
@interface YMANativeAdAssets : NSObject

/**
 * Age restrictions. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *age;

/**
 * Ad body text. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *body;

/**
 * Call to action. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *callToAction;

/**
 * Advertiser's domain. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *domain;

/**
 * Website favicon. Available in content ads.
 */
@property (nonatomic, strong, nullable) YMANativeAdImage *favicon;

/**
 * YES if ad has ability to process user feedback by displaying corresponding button, otherwise NO.
 * May be available in content, app install and image ads.
 */
@property (nonatomic, assign) BOOL feedbackAvailable;

/**
 * App icon. Available in app install ads.
 */
@property (nonatomic, strong, nullable) YMANativeAdImage *icon;

/**
 * Main ad image. Available in content, app install and image ads.
 */
@property (nonatomic, strong, nullable) YMANativeAdImage *image;

/**
 * Price. Available in app install ads.
 */
@property (nonatomic, copy, nullable) NSString *price;

/**
 * App rating. Available in app install ads.
 */
@property (nonatomic, strong, nullable) NSNumber *rating;

/**
 * App reviews number. Available in app install ads.
 */
@property (nonatomic, copy, nullable) NSString *reviewCount;

/**
 * Sponsored text. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *sponsored;

/**
 * Ad title. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *title;

/**
 * Warning text. Available in content and app install ads.
 */
@property (nonatomic, copy, nullable) NSString *warning;

@end
