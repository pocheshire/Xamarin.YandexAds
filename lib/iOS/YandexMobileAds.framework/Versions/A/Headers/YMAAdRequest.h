/*
 * Version for iOS © 2015–2018 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://yandex.com/legal/mobileads_sdk_agreement/
 */

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

NS_ASSUME_NONNULL_BEGIN

/**
 * Ad request contains data for ad targeting.
 */
@interface YMAAdRequest : NSObject <NSCopying, NSMutableCopying>

/**
 * Current location.
 */
@property (nonatomic, copy, readonly, nullable) CLLocation *location;

/**
 * Query input from user.
 */
@property (nonatomic, copy, readonly, nullable) NSString *contextQuery;

/**
 * Array of tag strings describing current user context.
 */
@property (nonatomic, copy, readonly, nullable) NSArray *contextTags;

/**
 * User's gender.
 * @see YMAGender.h for possible values.
 */
@property (nonatomic, copy, readonly, nullable) NSString *gender;

/**
 * User's age.
 */
@property (nonatomic, strong, readonly, nullable) NSNumber *age;

/**
 * Custom parameters containing NSString keys and values.
 */
@property (nonatomic, copy, readonly, nullable) NSDictionary *parameters;

/**
 * Returns ad request containing user location, query input and context tags.
 * @param location User location.
 * @param contextQuery Query input from user.
 * @param contextTags Array of tag strings describing current user context.
 *
 * @return Ad request containing user location, query input and context tags.
 */
- (instancetype)initWithLocation:(nullable CLLocation *)location
                    contextQuery:(nullable NSString *)contextQuery
                     contextTags:(nullable NSArray *)contextTags;

/**
 * Returns ad request containing user location, query input, context tags and additional parameters.
 * @param location User location.
 * @param contextQuery Query input from user.
 * @param contextTags Array of tag strings describing current user context.
 * @param parameters Additional parameters.
 *
 * @return Ad request containing user location, query input, context tags and additional parameters.
 */
- (instancetype)initWithLocation:(nullable CLLocation *)location
                    contextQuery:(nullable NSString *)contextQuery
                     contextTags:(nullable NSArray *)contextTags
                      parameters:(nullable NSDictionary *)parameters NS_DESIGNATED_INITIALIZER;

@end

/**
 * YMAMutableAdRequest is mutable version of YMAAdRequest, which allows to modify request parameters.
 */
@interface YMAMutableAdRequest : YMAAdRequest

/**
 * Current location.
 */
@property (nonatomic, copy, nullable) CLLocation *location;

/**
 * Query input from user.
 */
@property (nonatomic, copy, nullable) NSString *contextQuery;

/**
 * Array of tag strings describing current user context.
 */
@property (nonatomic, copy, nullable) NSArray *contextTags;

/**
 * User's gender.
 * @see YMAGender.h for possible values.
 */
@property (nonatomic, copy, nullable) NSString *gender;

/**
 * User's age.
 */
@property (nonatomic, strong, nullable) NSNumber *age;

/**
 * Custom parameters containing NSString keys and values.
 */
@property (nonatomic, copy, nullable) NSDictionary *parameters;

@end

NS_ASSUME_NONNULL_END
