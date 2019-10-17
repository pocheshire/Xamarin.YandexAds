using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.YandexAds.iOS
{
    // @interface YMAIcon : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAIcon
    {
        // @property (readonly, copy, nonatomic) NSString * program;
        [Export("program")]
        string Program { get; }

        // @property (readonly, assign, nonatomic) YMAIconHorizontalPosition horizontalPosition;
        [Export("horizontalPosition", ArgumentSemantic.Assign)]
        YMAIconHorizontalPosition HorizontalPosition { get; }

        // @property (readonly, assign, nonatomic) YMAIconVerticalPosition verticalPosition;
        [Export("verticalPosition", ArgumentSemantic.Assign)]
        YMAIconVerticalPosition VerticalPosition { get; }

        // @property (readonly, assign, nonatomic) int x;
        [Export("x")]
        int X { get; }

        // @property (readonly, assign, nonatomic) int y;
        [Export("y")]
        int Y { get; }

        // @property (readonly, assign, nonatomic) int width;
        [Export("width")]
        int Width { get; }

        // @property (readonly, assign, nonatomic) int height;
        [Export("height")]
        int Height { get; }

        // @property (readonly, assign, nonatomic) YMAIconResourceType resourceType;
        [Export("resourceType", ArgumentSemantic.Assign)]
        YMAIconResourceType ResourceType { get; }

        // @property (readonly, copy, nonatomic) NSString * resourceURI;
        [Export("resourceURI")]
        string ResourceURI { get; }
    }

    // @interface YMABlocksInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface YMABlocksInfo
    {
        // @property (readonly, assign, nonatomic) int version;
        [Export("version")]
        int Version { get; }

        // @property (readonly, copy, nonatomic) NSString * partnerID;
        [Export("partnerID")]
        string PartnerID { get; }

        // @property (readonly, copy, nonatomic) NSString * sessionID;
        [Export("sessionID")]
        string SessionID { get; }

        // @property (readonly, copy, nonatomic) NSString * categoryID;
        [Export("categoryID")]
        string CategoryID { get; }

        // @property (readonly, copy, nonatomic) NSString * categoryName;
        [Export("categoryName")]
        string CategoryName { get; }

        // @property (readonly, copy, nonatomic) NSString * skin;
        [Export("skin")]
        string Skin { get; }

        // @property (readonly, assign, nonatomic) BOOL VPaidEnabled;
        [Export("VPaidEnabled")]
        bool VPaidEnabled { get; }

        // @property (readonly, assign, nonatomic) int bufferEmptyLimit;
        [Export("bufferEmptyLimit")]
        int BufferEmptyLimit { get; }

        // @property (readonly, copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, assign, nonatomic) int skipDelay;
        [Export("skipDelay")]
        int SkipDelay { get; }

        // @property (readonly, assign, nonatomic) BOOL showTimeLeft;
        [Export("showTimeLeft")]
        bool ShowTimeLeft { get; }

        // @property (readonly, assign, nonatomic) BOOL showSkipTimeLeft;
        [Export("showSkipTimeLeft")]
        bool ShowSkipTimeLeft { get; }

        // @property (readonly, assign, nonatomic) int VASTTimeout;
        [Export("VASTTimeout")]
        int VASTTimeout { get; }

        // @property (readonly, assign, nonatomic) int videoTimeout;
        [Export("videoTimeout")]
        int VideoTimeout { get; }

        // @property (readonly, assign, nonatomic) int wrapperTimeout;
        [Export("wrapperTimeout")]
        int WrapperTimeout { get; }

        // @property (readonly, assign, nonatomic) int wrapperMaxCount;
        [Export("wrapperMaxCount")]
        int WrapperMaxCount { get; }

        // @property (readonly, assign, nonatomic) int VPaidTimeout;
        [Export("VPaidTimeout")]
        int VPaidTimeout { get; }

        // @property (readonly, assign, nonatomic) int skinTimeout;
        [Export("skinTimeout")]
        int SkinTimeout { get; }

        // @property (readonly, assign, nonatomic) int bufferFullTimeout;
        [Export("bufferFullTimeout")]
        int BufferFullTimeout { get; }

        // @property (readonly, copy, nonatomic) NSArray * blocks;
        [Export("blocks", ArgumentSemantic.Copy)]
        YMABlock []Blocks { get; }
    }

    // @interface YMACreative : NSObject
    [BaseType(typeof(NSObject))]
    interface YMACreative
    {
        // @property (readonly, copy, nonatomic) NSString * ID;
        [Export("ID")]
        string ID { get; }

        // @property (readonly, assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; }

        // @property (readonly, copy, nonatomic) NSString * clickThrough;
        [Export("clickThrough")]
        string ClickThrough { get; }

        // @property (readonly, copy, nonatomic) NSArray * mediaFiles;
        [Export("mediaFiles", ArgumentSemantic.Copy)]
        YMAMediaFile []MediaFiles { get; }

        // @property (readonly, copy, nonatomic) NSArray * icons;
        [Export("icons", ArgumentSemantic.Copy)]
        YMAIcon []Icons { get; }
    }

    // @interface YMANativeAppInstallAdView : UIView
    [BaseType(typeof(UIView))]
    interface YMANativeAppInstallAdView
    {
        // @property (nonatomic, weak) UILabel * _Nullable ageLabel __attribute__((iboutlet));
        [NullAllowed, Export("ageLabel", ArgumentSemantic.Weak)]
        UILabel AgeLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable bodyLabel __attribute__((iboutlet));
        [NullAllowed, Export("bodyLabel", ArgumentSemantic.Weak)]
        UILabel BodyLabel { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable callToActionButton __attribute__((iboutlet));
        [NullAllowed, Export("callToActionButton", ArgumentSemantic.Weak)]
        UIButton CallToActionButton { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable domainLabel __attribute__((iboutlet));
        [NullAllowed, Export("domainLabel", ArgumentSemantic.Weak)]
        UILabel DomainLabel { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable feedbackButton __attribute__((iboutlet));
        [NullAllowed, Export("feedbackButton", ArgumentSemantic.Weak)]
        UIButton FeedbackButton { get; set; }

        // @property (nonatomic, weak) UIImageView * _Nullable iconImageView __attribute__((iboutlet));
        [NullAllowed, Export("iconImageView", ArgumentSemantic.Weak)]
        UIImageView IconImageView { get; set; }

        // @property (nonatomic, weak) UIImageView * _Nullable imageView __attribute__((iboutlet)) __attribute__((deprecated("Use mediaView instead")));
        [NullAllowed, Export("imageView", ArgumentSemantic.Weak)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic, weak) YMANativeMediaView * _Nullable mediaView __attribute__((iboutlet));
        [NullAllowed, Export("mediaView", ArgumentSemantic.Weak)]
        YMANativeMediaView MediaView { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable priceLabel __attribute__((iboutlet));
        [NullAllowed, Export("priceLabel", ArgumentSemantic.Weak)]
        UILabel PriceLabel { get; set; }

        // @property (nonatomic, weak) UIView<YMARating> * _Nullable ratingView __attribute__((iboutlet));
        [NullAllowed, Export("ratingView", ArgumentSemantic.Weak)]
        YMARating RatingView { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable reviewCountLabel __attribute__((iboutlet));
        [NullAllowed, Export("reviewCountLabel", ArgumentSemantic.Weak)]
        UILabel ReviewCountLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable sponsoredLabel __attribute__((iboutlet));
        [NullAllowed, Export("sponsoredLabel", ArgumentSemantic.Weak)]
        UILabel SponsoredLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable titleLabel __attribute__((iboutlet));
        [NullAllowed, Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable warningLabel __attribute__((iboutlet));
        [NullAllowed, Export("warningLabel", ArgumentSemantic.Weak)]
        UILabel WarningLabel { get; set; }

        // @property (readonly, nonatomic, strong) id<YMANativeAppInstallAd> _Nullable ad;
        [NullAllowed, Export("ad", ArgumentSemantic.Strong)]
        YMANativeAppInstallAd Ad { get; }
    }

    // @interface YMANativeAdLoader : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMANativeAdLoader
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull blockID;
        [Export("blockID", ArgumentSemantic.Strong)]
        string BlockID { get; }

        // @property (readonly, nonatomic, strong) YMANativeAdLoaderConfiguration * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Strong)]
        YMANativeAdLoaderConfiguration Configuration { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        YMANativeAdLoaderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMANativeAdLoaderDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithBlockID:(NSString * _Nonnull)blockID __attribute__((deprecated("Use initWithConfiguration: instead")));
        [Export("initWithBlockID:")]
        IntPtr Constructor(string blockID);

        // -(instancetype _Nonnull)initWithConfiguration:(YMANativeAdLoaderConfiguration * _Nonnull)configuration;
        [Export("initWithConfiguration:")]
        IntPtr Constructor(YMANativeAdLoaderConfiguration configuration);

        // -(void)loadAdWithRequest:(YMAAdRequest * _Nullable)request;
        [Export("loadAdWithRequest:")]
        void LoadAdWithRequest([NullAllowed] YMAAdRequest request);
    }

    // @protocol YMANativeAdLoaderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMANativeAdLoaderDelegate
    {
        // @optional -(void)nativeAdLoader:(YMANativeAdLoader * _Null_unspecified)loader didLoadContentAd:(id<YMANativeContentAd> _Nonnull)ad;
        [Export("nativeAdLoader:didLoadContentAd:")]
        void DidLoadContentAd(YMANativeAdLoader loader, YMANativeContentAd ad);

        // @optional -(void)nativeAdLoader:(YMANativeAdLoader * _Null_unspecified)loader didLoadAppInstallAd:(id<YMANativeAppInstallAd> _Nonnull)ad;
        [Export("nativeAdLoader:didLoadAppInstallAd:")]
        void DidLoadAppInstallAd(YMANativeAdLoader loader, YMANativeAppInstallAd ad);

        // @optional -(void)nativeAdLoader:(YMANativeAdLoader * _Null_unspecified)loader didLoadImageAd:(id<YMANativeImageAd> _Nonnull)ad;
        [Export("nativeAdLoader:didLoadImageAd:")]
        void DidLoadImageAd(YMANativeAdLoader loader, YMANativeImageAd ad);

        // @optional -(void)nativeAdLoader:(YMANativeAdLoader * _Null_unspecified)loader didFailLoadingWithError:(NSError * _Nonnull)error;
        [Export("nativeAdLoader:didFailLoadingWithError:")]
        void DidFailLoadingWithError(YMANativeAdLoader loader, NSError error);
    }

    partial interface Constants
    {
        // extern NSString *const kYMANativeAdTypeContent;
        [Field("kYMANativeAdTypeContent", "__Internal")]
        NSString kYMANativeAdTypeContent { get; }

        // extern NSString *const kYMANativeAdTypeAppInstall;
        [Field("kYMANativeAdTypeAppInstall", "__Internal")]
        NSString kYMANativeAdTypeAppInstall { get; }

        // extern NSString *const kYMANativeAdTypeImage;
        [Field("kYMANativeAdTypeImage", "__Internal")]
        NSString kYMANativeAdTypeImage { get; }
    }

    // @interface YMAVideoController : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAVideoController
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        YMAVideoDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMAVideoDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    // @protocol YMARating <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMARating
    {
        // @required -(NSNumber * _Nullable)rating;
        // @required -(void)setRating:(NSNumber * _Nullable)rating;
        [Abstract]
        [NullAllowed, Export("rating")]
        NSNumber Rating { get; set; }
    }

    // @interface YMAVASTRequestConfiguration : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVASTRequestConfiguration : INSCopying, INSMutableCopying
    {
        // @property (readonly, nonatomic, strong) YMAVMAPAdBreak * _Nonnull adBreak;
        [Export("adBreak", ArgumentSemantic.Strong)]
        YMAVMAPAdBreak AdBreak { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable parameters;
        [NullAllowed, Export("parameters", ArgumentSemantic.Copy)]
        NSDictionary Parameters { get; }

        // -(instancetype _Nonnull)initWithAdBreak:(YMAVMAPAdBreak * _Nonnull)adBreak;
        [Export("initWithAdBreak:")]
        IntPtr Constructor(YMAVMAPAdBreak adBreak);
    }

    // @interface YMAMutableVASTRequestConfiguration : YMAVASTRequestConfiguration
    [BaseType(typeof(YMAVASTRequestConfiguration))]
    interface YMAMutableVASTRequestConfiguration
    {
        // @property (copy, nonatomic) NSDictionary * _Nullable parameters;
        [NullAllowed, Export("parameters", ArgumentSemantic.Copy)]
        NSDictionary Parameters { get; set; }
    }

    // @interface YMANativeAdMedia : NSObject
    [BaseType(typeof(NSObject))]
    interface YMANativeAdMedia
    {
        // @property (readonly, assign, nonatomic) CGFloat aspectRatio;
        [Export("aspectRatio")]
        nfloat AspectRatio { get; }
    }

    // @interface YMAVMAP : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVMAP
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull version;
        [Export("version")]
        string Version { get; }

        // @property (readonly, copy, nonatomic) NSArray<YMAVMAPAdBreak *> * _Nonnull adBreaks;
        [Export("adBreaks", ArgumentSemantic.Copy)]
        YMAVMAPAdBreak[] AdBreaks { get; }

        // @property (readonly, copy, nonatomic) NSArray<YMAVMAPExtension *> * _Nonnull extensions;
        [Export("extensions", ArgumentSemantic.Copy)]
        YMAVMAPExtension[] Extensions { get; }
    }

    // @interface YMAMediaFile : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAMediaFile
    {
        // @property (readonly, copy, nonatomic) NSString * ID;
        [Export("ID")]
        string ID { get; }

        // @property (readonly, copy, nonatomic) NSString * URI;
        [Export("URI")]
        string URI { get; }

        // @property (readonly, assign, nonatomic) YMADeliveryMethod deliveryMethod;
        [Export("deliveryMethod", ArgumentSemantic.Assign)]
        YMADeliveryMethod DeliveryMethod { get; }

        // @property (readonly, assign, nonatomic) int width;
        [Export("width")]
        int Width { get; }

        // @property (readonly, assign, nonatomic) int height;
        [Export("height")]
        int Height { get; }

        // @property (readonly, copy, nonatomic) NSString * MIMEType;
        [Export("MIMEType")]
        string MIMEType { get; }

        // @property (readonly, assign, nonatomic) int bitRate;
        [Export("bitRate")]
        int BitRate { get; }
    }

    // @interface YMAVMAPExtension : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVMAPExtension
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull value;
        [Export("value")]
        string Value { get; }
    }

    // @interface YMANativeImageAdView : UIView
    [BaseType(typeof(UIView))]
    interface YMANativeImageAdView
    {
        // @property (nonatomic, weak) UIButton * _Nullable feedbackButton __attribute__((iboutlet));
        [NullAllowed, Export("feedbackButton", ArgumentSemantic.Weak)]
        UIButton FeedbackButton { get; set; }

        // @property (nonatomic, weak) UIImageView * _Nullable imageView __attribute__((iboutlet)) __attribute__((deprecated("Use mediaView instead")));
        [NullAllowed, Export("imageView", ArgumentSemantic.Weak)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic, weak) YMANativeMediaView * _Nullable mediaView __attribute__((iboutlet));
        [NullAllowed, Export("mediaView", ArgumentSemantic.Weak)]
        YMANativeMediaView MediaView { get; set; }

        // @property (readonly, nonatomic, strong) id<YMANativeImageAd> _Nullable ad;
        [NullAllowed, Export("ad", ArgumentSemantic.Strong)]
        YMANativeImageAd Ad { get; }
    }

    // @interface YMAVMAPAdBreak : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVMAPAdBreak
    {
        // @property (readonly, nonatomic, strong) YMAVMAPAdSource * _Nonnull adSource;
        [Export("adSource", ArgumentSemantic.Strong)]
        YMAVMAPAdSource AdSource { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable breakID;
        [NullAllowed, Export("breakID")]
        string BreakID { get; }

        // @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull breakTypes;
        [Export("breakTypes", ArgumentSemantic.Strong)]
        string[] BreakTypes { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable repeatAfterMillis;
        [NullAllowed, Export("repeatAfterMillis", ArgumentSemantic.Strong)]
        NSNumber RepeatAfterMillis { get; }

        // @property (readonly, nonatomic, strong) YMAVMAPTimeOffset * _Nonnull timeOffset;
        [Export("timeOffset", ArgumentSemantic.Strong)]
        YMAVMAPTimeOffset TimeOffset { get; }

        // @property (readonly, copy, nonatomic) NSArray<YMAVMAPExtension *> * _Nonnull extensions;
        [Export("extensions", ArgumentSemantic.Copy)]
        YMAVMAPExtension[] Extensions { get; }
    }

    // @interface YMANativeAdLoaderConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface YMANativeAdLoaderConfiguration
    {
        // extern NSString *const _Nonnull kYMANativeImageSizeSmall;
        [Field("kYMANativeImageSizeSmall", "__Internal")]
        NSString kYMANativeImageSizeSmall { get; }

        // extern NSString *const _Nonnull kYMANativeImageSizeMedium;
        [Field("kYMANativeImageSizeMedium", "__Internal")]
        NSString kYMANativeImageSizeMedium { get; }

        // extern NSString *const _Nonnull kYMANativeImageSizeLarge;
        [Field("kYMANativeImageSizeLarge", "__Internal")]
        NSString kYMANativeImageSizeLarge { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull blockID;
        [Export("blockID")]
        string BlockID { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nonnull imageSizes;
        [Export("imageSizes", ArgumentSemantic.Copy)]
        NSObject []ImageSizes { get; }

        // @property (readonly, assign, nonatomic) BOOL shouldLoadImagesAutomatically;
        [Export("shouldLoadImagesAutomatically")]
        bool ShouldLoadImagesAutomatically { get; }

        // -(instancetype _Nonnull)initWithBlockID:(NSString * _Nonnull)blockID loadImagesAutomatically:(BOOL)shouldLoadImagesAutomatically;
        [Export("initWithBlockID:loadImagesAutomatically:")]
        IntPtr Constructor(string blockID, bool shouldLoadImagesAutomatically);

        // -(instancetype _Nonnull)initWithBlockID:(NSString * _Nonnull)blockID imageSizes:(NSArray * _Nonnull)imageSizes loadImagesAutomatically:(BOOL)shouldLoadImagesAutomatically __attribute__((objc_designated_initializer));
        [Export("initWithBlockID:imageSizes:loadImagesAutomatically:")]
        [DesignatedInitializer]
        IntPtr Constructor(string blockID, NSObject []imageSizes, bool shouldLoadImagesAutomatically);
    }

    // @protocol YMANativeAdImageLoadingObserver <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMANativeAdImageLoadingObserver
    {
        // @required -(void)nativeAdDidFinishLoadingImages:(id<YMANativeGenericAd> _Nonnull)ad;
        [Abstract]
        [Export("nativeAdDidFinishLoadingImages:")]
        void NativeAdDidFinishLoadingImages(YMANativeGenericAd ad);
    }

    // @interface YMANativeBannerView : UIView <YMANativeAdImageLoadingObserver>
    [BaseType(typeof(UIView))]
    interface YMANativeBannerView : YMANativeAdImageLoadingObserver
    {
        // @property (nonatomic, strong) id<YMANativeGenericAd> _Nullable ad;
        [NullAllowed, Export("ad", ArgumentSemantic.Strong)]
        YMANativeGenericAd Ad { get; set; }

        // -(void)applyAppearance:(YMANativeTemplateAppearance * _Nonnull)appearance;
        [Export("applyAppearance:")]
        void ApplyAppearance(YMANativeTemplateAppearance appearance);

        // +(CGFloat)heightWithAd:(id<YMANativeGenericAd> _Nonnull)ad width:(CGFloat)width appearance:(YMANativeTemplateAppearance * _Nullable)appearance;
        [Static]
        [Export("heightWithAd:width:appearance:")]
        nfloat HeightWithAd(YMANativeGenericAd ad, nfloat width, [NullAllowed] YMANativeTemplateAppearance appearance);
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const kYMAVMAPErrorDomain;
        [Field("kYMAVMAPErrorDomain", "__Internal")]
        NSString kYMAVMAPErrorDomain { get; }
    }

    // @interface YMAVMAPAdSource : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVMAPAdSource
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nullable allowMultipleAds;
        [NullAllowed, Export("allowMultipleAds", ArgumentSemantic.Strong)]
        NSNumber AllowMultipleAds { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable ID;
        [NullAllowed, Export("ID")]
        string ID { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable followRedirects;
        [NullAllowed, Export("followRedirects", ArgumentSemantic.Strong)]
        NSNumber FollowRedirects { get; }
    }

    // @interface YMAYandexVASTAds : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAYandexVASTAds
    {
        // extern NSString *const YMAVASTSpecialResponseTextKey;
        [Field("YMAVASTSpecialResponseTextKey", "__Internal")]
        NSString YMAVASTSpecialResponseTextKey { get; }

        // +(void)loadBlocksInfoForPartnerID:(NSString *)partnerID categoryID:(NSString *)categoryID delegate:(id<YMABlocksInfoLoaderDelegate>)delegate;
        [Static]
        [Export("loadBlocksInfoForPartnerID:categoryID:delegate:")]
        void LoadBlocksInfoForPartnerID(string partnerID, string categoryID, YMABlocksInfoLoaderDelegate @delegate);

        // +(void)loadVideoAdsWithRequest:(YMAVideoAdsRequest *)request delegate:(id<YMAVideoAdLoaderDelegate>)delegate;
        [Static]
        [Export("loadVideoAdsWithRequest:delegate:")]
        void LoadVideoAdsWithRequest(YMAVideoAdsRequest request, YMAVideoAdLoaderDelegate @delegate);
    }

    // @protocol YMABlocksInfoLoaderDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMABlocksInfoLoaderDelegate
    {
        // @required -(void)loaderDidLoadBlocksInfo:(YMABlocksInfo *)blocksInfo;
        [Abstract]
        [Export("loaderDidLoadBlocksInfo:")]
        void LoaderDidLoadBlocksInfo(YMABlocksInfo blocksInfo);

        // @required -(void)loaderDidFailLoadingBlocksInfoWithError:(NSError *)error;
        [Abstract]
        [Export("loaderDidFailLoadingBlocksInfoWithError:")]
        void LoaderDidFailLoadingBlocksInfoWithError(NSError error);
    }

    // @protocol YMAVideoAdLoaderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMAVideoAdLoaderDelegate
    {
        // @required -(void)loaderDidLoadVideoAds:(NSArray *)ads;
        [Abstract]
        [Export("loaderDidLoadVideoAds:")]
        void LoaderDidLoadVideoAds(YMAVASTAd []ads);

        // @required -(void)loaderDidFailLoadingVideoAdsWithError:(NSError *)error;
        [Abstract]
        [Export("loaderDidFailLoadingVideoAdsWithError:")]
        void LoaderDidFailLoadingVideoAdsWithError(NSError error);
    }

    // @interface YMABlock : NSObject
    [BaseType(typeof(NSObject))]
    interface YMABlock
    {
        // @property (readonly, copy, nonatomic) NSString * ID;
        [Export("ID")]
        string ID { get; }

        // @property (readonly, assign, nonatomic) YMABlockType blockType;
        [Export("blockType", ArgumentSemantic.Assign)]
        YMABlockType BlockType { get; }

        // @property (readonly, assign, nonatomic) int startTime;
        [Export("startTime")]
        int StartTime { get; }

        // @property (readonly, assign, nonatomic) int duration;
        [Export("duration")]
        int Duration { get; }

        // @property (readonly, assign, nonatomic) int positionsCount;
        [Export("positionsCount")]
        int PositionsCount { get; }
    }

    // @interface YMAVASTAd : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAVASTAd
    {
        // @property (readonly, assign, nonatomic) YMAVASTAdType adType;
        [Export("adType", ArgumentSemantic.Assign)]
        YMAVASTAdType AdType { get; }

        // @property (readonly, copy, nonatomic) NSString * adSystem;
        [Export("adSystem")]
        string AdSystem { get; }

        // @property (readonly, copy, nonatomic) NSString * adTitle;
        [Export("adTitle")]
        string AdTitle { get; }

        // @property (readonly, copy, nonatomic) NSString * adDescription;
        [Export("adDescription")]
        string AdDescription { get; }

        // @property (readonly, copy, nonatomic) NSString * survey;
        [Export("survey")]
        string Survey { get; }

        // @property (readonly, copy, nonatomic) NSArray * creatives;
        [Export("creatives", ArgumentSemantic.Copy)]
        YMACreative []Creatives { get; }

        // @property (readonly, copy, nonatomic) NSString * VASTAdTagURI;
        [Export("VASTAdTagURI")]
        string VASTAdTagURI { get; }

        // @property (readonly, copy, nonatomic) NSString * rawVAST;
        [Export("rawVAST")]
        string RawVAST { get; }
    }

    // @interface YMAVASTTracker : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAVASTTracker
    {
        // extern NSString *const kYMAVASTAdImpression;
        [Field("kYMAVASTAdImpression", "__Internal")]
        NSString kYMAVASTAdImpression { get; }

        // extern NSString *const kYMACreativeStart;
        [Field("kYMACreativeStart", "__Internal")]
        NSString kYMACreativeStart { get; }

        // extern NSString *const kYMACreativeFirstQuartile;
        [Field("kYMACreativeFirstQuartile", "__Internal")]
        NSString kYMACreativeFirstQuartile { get; }

        // extern NSString *const kYMACreativeMidpoint;
        [Field("kYMACreativeMidpoint", "__Internal")]
        NSString kYMACreativeMidpoint { get; }

        // extern NSString *const kYMACreativeThirdQuartile;
        [Field("kYMACreativeThirdQuartile", "__Internal")]
        NSString kYMACreativeThirdQuartile { get; }

        // extern NSString *const kYMACreativeComplete;
        [Field("kYMACreativeComplete", "__Internal")]
        NSString kYMACreativeComplete { get; }

        // extern NSString *const kYMACreativeMute;
        [Field("kYMACreativeMute", "__Internal")]
        NSString kYMACreativeMute { get; }

        // extern NSString *const kYMACreativeUnmute;
        [Field("kYMACreativeUnmute", "__Internal")]
        NSString kYMACreativeUnmute { get; }

        // extern NSString *const kYMACreativeFullscreen;
        [Field("kYMACreativeFullscreen", "__Internal")]
        NSString kYMACreativeFullscreen { get; }

        // extern NSString *const kYMACreativeExpand;
        [Field("kYMACreativeExpand", "__Internal")]
        NSString kYMACreativeExpand { get; }

        // extern NSString *const kYMACreativeCollapse;
        [Field("kYMACreativeCollapse", "__Internal")]
        NSString kYMACreativeCollapse { get; }

        // extern NSString *const kYMACreativeClose;
        [Field("kYMACreativeClose", "__Internal")]
        NSString kYMACreativeClose { get; }

        // extern NSString *const kYMACreativeClickTracking;
        [Field("kYMACreativeClickTracking", "__Internal")]
        NSString kYMACreativeClickTracking { get; }

        // +(void)trackAdEvent:(YMAVASTAd *)ad eventName:(NSString *)eventName;
        [Static]
        [Export("trackAdEvent:eventName:")]
        void TrackAdEvent(YMAVASTAd ad, string eventName);

        // +(void)trackCreativeEvent:(YMACreative *)creative eventName:(NSString *)eventName;
        [Static]
        [Export("trackCreativeEvent:eventName:")]
        void TrackCreativeEvent(YMACreative creative, string eventName);
    }

    // @interface YMAVideoAdsRequest : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMAVideoAdsRequest : INSCopying, INSMutableCopying
    {
        // extern NSString *const kYMAVideoAdsCharsetUTF8;
        [Field("kYMAVideoAdsCharsetUTF8", "__Internal")]
        NSString kYMAVideoAdsCharsetUTF8 { get; }

        // extern NSString *const kYMAVideoAdsCharsetCP1251;
        [Field("kYMAVideoAdsCharsetCP1251", "__Internal")]
        NSString kYMAVideoAdsCharsetCP1251 { get; }

        // extern NSString *const kYMAVideoAdsCharsetKOI8R;
        [Field("kYMAVideoAdsCharsetKOI8R", "__Internal")]
        NSString kYMAVideoAdsCharsetKOI8R { get; }

        // extern NSString *const kYMAVideoAdsCharsetKOI8U;
        [Field("kYMAVideoAdsCharsetKOI8U", "__Internal")]
        NSString kYMAVideoAdsCharsetKOI8U { get; }

        // -(id)initWithBlockID:(NSString *)blockID blocksInfo:(YMABlocksInfo *)blocksInfo pageRef:(NSString *)pageRef targetRef:(NSString *)targetRef;
        [Export("initWithBlockID:blocksInfo:pageRef:targetRef:")]
        IntPtr Constructor(string blockID, YMABlocksInfo blocksInfo, string pageRef, string targetRef);

        // @property (readonly, copy, nonatomic) NSString * blockID;
        [Export("blockID")]
        string BlockID { get; }

        // @property (readonly, nonatomic, strong) YMABlocksInfo * blocksInfo;
        [Export("blocksInfo", ArgumentSemantic.Strong)]
        YMABlocksInfo BlocksInfo { get; }

        // @property (readonly, copy, nonatomic) NSString * pageRef;
        [Export("pageRef")]
        string PageRef { get; }

        // @property (readonly, copy, nonatomic) NSString * targetRef;
        [Export("targetRef")]
        string TargetRef { get; }

        // @property (readonly, copy, nonatomic) NSValue * playerSize;
        [Export("playerSize", ArgumentSemantic.Copy)]
        NSValue PlayerSize { get; }

        // @property (readonly, copy, nonatomic) NSString * externalUserID;
        [Export("externalUserID")]
        string ExternalUserID { get; }

        // @property (readonly, copy, nonatomic) NSString * publisherID;
        [Export("publisherID")]
        string PublisherID { get; }

        // @property (readonly, copy, nonatomic) NSString * publisherName;
        [Export("publisherName")]
        string PublisherName { get; }

        // @property (readonly, copy, nonatomic) NSString * contentID;
        [Export("contentID")]
        string ContentID { get; }

        // @property (readonly, copy, nonatomic) NSString * contentName;
        [Export("contentName")]
        string ContentName { get; }

        // @property (readonly, copy, nonatomic) NSString * genreID __attribute__((deprecated("genreIDs should be used instead")));
        [Export("genreID")]
        string GenreID { get; }

        // @property (readonly, copy, nonatomic) NSArray * genreIDs;
        [Export("genreIDs", ArgumentSemantic.Copy)]
        NSString []GenreIDs { get; }

        // @property (readonly, copy, nonatomic) NSArray * genreNames;
        [Export("genreNames", ArgumentSemantic.Copy)]
        NSString []GenreNames { get; }

        // @property (readonly, copy, nonatomic) NSArray * tags;
        [Export("tags", ArgumentSemantic.Copy)]
        NSString []Tags { get; }

        // @property (readonly, assign, nonatomic) NSInteger bitrate;
        [Export("bitrate")]
        nint Bitrate { get; }

        // @property (readonly, copy, nonatomic) NSString * charset;
        [Export("charset")]
        string Charset { get; }

        // @property (readonly, copy, nonatomic) NSString * extendedParameters;
        [Export("extendedParameters")]
        string ExtendedParameters { get; }
    }

    // @interface YMAMutableVideoAdsRequest : YMAVideoAdsRequest
    [BaseType(typeof(YMAVideoAdsRequest))]
    interface YMAMutableVideoAdsRequest
    {
        // @property (copy, nonatomic) NSValue * playerSize;
        [Export("playerSize", ArgumentSemantic.Copy)]
        NSValue PlayerSize { get; set; }

        // @property (copy, nonatomic) NSString * externalUserID;
        [Export("externalUserID")]
        string ExternalUserID { get; set; }

        // @property (copy, nonatomic) NSString * publisherID;
        [Export("publisherID")]
        string PublisherID { get; set; }

        // @property (copy, nonatomic) NSString * publisherName;
        [Export("publisherName")]
        string PublisherName { get; set; }

        // @property (copy, nonatomic) NSString * contentID;
        [Export("contentID")]
        string ContentID { get; set; }

        // @property (copy, nonatomic) NSString * contentName;
        [Export("contentName")]
        string ContentName { get; set; }

        // @property (copy, nonatomic) NSString * genreID __attribute__((deprecated("genreIDs should be used instead")));
        [Export("genreID")]
        string GenreID { get; set; }

        // @property (copy, nonatomic) NSArray * genreIDs;
        [Export("genreIDs", ArgumentSemantic.Copy)]
        NSString []GenreIDs { get; set; }

        // @property (copy, nonatomic) NSArray * genreNames;
        [Export("genreNames", ArgumentSemantic.Copy)]
        NSString []GenreNames { get; set; }

        // @property (copy, nonatomic) NSArray * tags;
        [Export("tags", ArgumentSemantic.Copy)]
        NSString []Tags { get; set; }

        // @property (assign, nonatomic) NSInteger bitrate;
        [Export("bitrate")]
        nint Bitrate { get; set; }

        // @property (copy, nonatomic) NSString * charset;
        [Export("charset")]
        string Charset { get; set; }

        // @property (copy, nonatomic) NSString * extendedParameters;
        [Export("extendedParameters")]
        string ExtendedParameters { get; set; }
    }

    partial interface Constants
    {
        // extern NSString *const kYMAAdsErrorDomain;
        [Field("kYMAAdsErrorDomain", "__Internal")]
        NSString kYMAAdsErrorDomain { get; }
    }

    partial interface Constants
    {
        // extern NSString *const kYMAVASTErrorDomain;
        [Field("kYMAVASTErrorDomain", "__Internal")]
        NSString kYMAVASTErrorDomain { get; }
    }

    partial interface Constants
    {
        // extern NSString *const _Nonnull kYMABreakIDInpage;
        [Field("kYMABreakIDInpage", "__Internal")]
        NSString kYMABreakIDInpage { get; }

        // extern NSString *const _Nonnull kYMABreakIDMidRoll;
        [Field("kYMABreakIDMidRoll", "__Internal")]
        NSString kYMABreakIDMidRoll { get; }

        // extern NSString *const _Nonnull kYMABreakIDPauseRoll;
        [Field("kYMABreakIDPauseRoll", "__Internal")]
        NSString kYMABreakIDPauseRoll { get; }

        // extern NSString *const _Nonnull kYMABreakIDPostRoll;
        [Field("kYMABreakIDPostRoll", "__Internal")]
        NSString kYMABreakIDPostRoll { get; }

        // extern NSString *const _Nonnull kYMABreakIDPreRoll;
        [Field("kYMABreakIDPreRoll", "__Internal")]
        NSString kYMABreakIDPreRoll { get; }
    }

    partial interface Constants
    {
        // extern NSString *const _Nonnull kYMABreakTypeLinear;
        [Field("kYMABreakTypeLinear", "__Internal")]
        NSString kYMABreakTypeLinear { get; }

        // extern NSString *const _Nonnull kYMABreakTypeNonLinear;
        [Field("kYMABreakTypeNonLinear", "__Internal")]
        NSString kYMABreakTypeNonLinear { get; }

        // extern NSString *const _Nonnull kYMABreakTypeDisplay;
        [Field("kYMABreakTypeDisplay", "__Internal")]
        NSString kYMABreakTypeDisplay { get; }
    }

    // @interface YMAVMAPTimeOffset : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVMAPTimeOffset
    {
        // @property (readonly, copy, nonatomic) NSString * rawValue;
        [Export("rawValue")]
        string RawValue { get; }
    }

    // @interface YMAVMAPRequestConfiguration : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMAVMAPRequestConfiguration : INSCopying, INSMutableCopying
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull pageID;
        [Export("pageID")]
        string PageID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull categoryID;
        [Export("categoryID")]
        string CategoryID { get; }

        // -(instancetype _Nonnull)initWithPageID:(NSString * _Nonnull)pageID;
        [Export("initWithPageID:")]
        IntPtr Constructor(string pageID);
    }

    // @interface YMAMutableVMAPRequestConfiguration : YMAVMAPRequestConfiguration
    [BaseType(typeof(YMAVMAPRequestConfiguration))]
    interface YMAMutableVMAPRequestConfiguration
    {
        // @property (copy, nonatomic) NSString * _Nullable categoryID;
        [NullAllowed, Export("categoryID")]
        string CategoryID { get; set; }
    }

    // @interface YMAVMAPLoader : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAVMAPLoader
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        YMAVMAPLoaderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMAVMAPLoaderDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)loadVMAPWithRequestConfiguration:(YMAVMAPRequestConfiguration * _Nonnull)requestConfiguration;
        [Export("loadVMAPWithRequestConfiguration:")]
        void LoadVMAPWithRequestConfiguration(YMAVMAPRequestConfiguration requestConfiguration);
    }

    // @protocol YMAVMAPLoaderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMAVMAPLoaderDelegate
    {
        // @required -(void)loader:(YMAVMAPLoader * _Nonnull)loader didLoadVMAP:(YMAVMAP * _Nonnull)VMAP;
        [Abstract]
        [Export("loader:didLoadVMAP:")]
        void DidLoadVMAP(YMAVMAPLoader loader, YMAVMAP VMAP);

        // @required -(void)loader:(YMAVMAPLoader * _Nonnull)loader didFailLoadingVMAPWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("loader:didFailLoadingVMAPWithError:")]
        void DidFailLoadingVMAPWithError(YMAVMAPLoader loader, NSError error);
    }

    // @interface YMAVideoAdLoader : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAVideoAdLoader
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        YMAVideoAdLoaderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMAVideoAdLoaderDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)loadVASTWithRequestConfiguration:(YMAVASTRequestConfiguration * _Nonnull)requestConfiguration;
        [Export("loadVASTWithRequestConfiguration:")]
        void LoadVASTWithRequestConfiguration(YMAVASTRequestConfiguration requestConfiguration);
    }

    // @interface YMANativeContentAdView : UIView
    [BaseType(typeof(UIView))]
    interface YMANativeContentAdView
    {
        // @property (nonatomic, weak) UILabel * _Nullable ageLabel __attribute__((iboutlet));
        [NullAllowed, Export("ageLabel", ArgumentSemantic.Weak)]
        UILabel AgeLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable bodyLabel __attribute__((iboutlet));
        [NullAllowed, Export("bodyLabel", ArgumentSemantic.Weak)]
        UILabel BodyLabel { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable callToActionButton __attribute__((iboutlet));
        [NullAllowed, Export("callToActionButton", ArgumentSemantic.Weak)]
        UIButton CallToActionButton { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable feedbackButton __attribute__((iboutlet));
        [NullAllowed, Export("feedbackButton", ArgumentSemantic.Weak)]
        UIButton FeedbackButton { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable domainLabel __attribute__((iboutlet));
        [NullAllowed, Export("domainLabel", ArgumentSemantic.Weak)]
        UILabel DomainLabel { get; set; }

        // @property (nonatomic, weak) UIImageView * _Nullable iconImageView __attribute__((iboutlet));
        [NullAllowed, Export("iconImageView", ArgumentSemantic.Weak)]
        UIImageView IconImageView { get; set; }

        // @property (nonatomic, weak) UIImageView * _Nullable imageView __attribute__((iboutlet)) __attribute__((deprecated("Use mediaView instead")));
        [NullAllowed, Export("imageView", ArgumentSemantic.Weak)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic, weak) YMANativeMediaView * _Nullable mediaView __attribute__((iboutlet));
        [NullAllowed, Export("mediaView", ArgumentSemantic.Weak)]
        YMANativeMediaView MediaView { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable sponsoredLabel __attribute__((iboutlet));
        [NullAllowed, Export("sponsoredLabel", ArgumentSemantic.Weak)]
        UILabel SponsoredLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable titleLabel __attribute__((iboutlet));
        [NullAllowed, Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, weak) UILabel * _Nullable warningLabel __attribute__((iboutlet));
        [NullAllowed, Export("warningLabel", ArgumentSemantic.Weak)]
        UILabel WarningLabel { get; set; }

        // @property (readonly, nonatomic, strong) id<YMANativeContentAd> _Nullable ad;
        [NullAllowed, Export("ad", ArgumentSemantic.Strong)]
        YMANativeContentAd Ad { get; }
    }

    // @protocol YMANativeGenericAd <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMANativeGenericAd
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        YMANativeAdDelegate Delegate { get; set; }

        // @required @property (nonatomic, weak) id<YMANativeAdDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @required -(void)addImageLoadingObserver:(id<YMANativeAdImageLoadingObserver> _Nonnull)observer;
        [Abstract]
        [Export("addImageLoadingObserver:")]
        void AddImageLoadingObserver(YMANativeAdImageLoadingObserver observer);

        // @required -(void)removeImageLoadingObserver:(id<YMANativeAdImageLoadingObserver> _Nonnull)observer;
        [Abstract]
        [Export("removeImageLoadingObserver:")]
        void RemoveImageLoadingObserver(YMANativeAdImageLoadingObserver observer);

        // @required -(NSString * _Nonnull)adType;
        [Abstract]
        [Export("adType")]
        string AdType { get; }

        // @required -(YMANativeAdAssets * _Nonnull)adAssets;
        [Abstract]
        [Export("adAssets")]
        YMANativeAdAssets AdAssets { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull info;
        [Abstract]
        [Export("info")]
        string Info { get; }

        // @required -(void)loadImages;
        [Abstract]
        [Export("loadImages")]
        void LoadImages();
    }

    // @protocol YMAReward <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMAReward
    {
        // @required @property (readonly, assign, nonatomic) NSInteger amount;
        [Abstract]
        [Export("amount")]
        nint Amount { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Abstract]
        [Export("type")]
        string Type { get; }
    }

    // @interface YMAAdView : UIView
    [BaseType(typeof(UIView))]
    interface YMAAdView
    {
        [Wrap("WeakDelegate")]
        YMAAdViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMAAdViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, copy, nonatomic) NSString * blockID;
        [Export("blockID")]
        string BlockID { get; }

        // @property (readonly, nonatomic, strong) YMAVideoController * videoController;
        [Export("videoController", ArgumentSemantic.Strong)]
        YMAVideoController VideoController { get; }

        // -(instancetype)initWithBlockID:(NSString *)blockID adSize:(YMAAdSize *)adSize delegate:(id<YMAAdViewDelegate>)delegate;
        [Export("initWithBlockID:adSize:delegate:")]
        IntPtr Constructor(string blockID, YMAAdSize adSize, YMAAdViewDelegate @delegate);

        // -(instancetype)initWithBlockID:(NSString *)blockID size:(CGSize)size delegate:(id<YMAAdViewDelegate>)delegate __attribute__((deprecated("[YMAAdView initWithBlockID:adSize:delegate:] should be used instead")));
        [Export("initWithBlockID:size:delegate:")]
        IntPtr Constructor(string blockID, CGSize size, YMAAdViewDelegate @delegate);

        // -(void)displayAtTopInView:(UIView *)view;
        [Export("displayAtTopInView:")]
        void DisplayAtTopInView(UIView view);

        // -(void)displayAtBottomInView:(UIView *)view;
        [Export("displayAtBottomInView:")]
        void DisplayAtBottomInView(UIView view);

        // -(void)loadAd;
        [Export("loadAd")]
        void LoadAd();

        // -(void)loadAdWithRequest:(YMAAdRequest *)request;
        [Export("loadAdWithRequest:")]
        void LoadAdWithRequest(YMAAdRequest request);

        // -(CGSize)adContentSize;
        [Export("adContentSize")]
        CGSize AdContentSize { get; }
    }

    // @protocol YMAAdViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMAAdViewDelegate
    {
        // @optional -(UIViewController *)viewControllerForPresentingModalView;
        [Export("viewControllerForPresentingModalView")]
        UIViewController ViewControllerForPresentingModalView { get; }

        // @optional -(void)adViewDidLoad:(YMAAdView *)adView;
        [Export("adViewDidLoad:")]
        void AdViewDidLoad(YMAAdView adView);

        // @optional -(void)adViewDidFailLoading:(YMAAdView *)adView error:(NSError *)error;
        [Export("adViewDidFailLoading:error:")]
        void AdViewDidFailLoading(YMAAdView adView, NSError error);

        // @optional -(void)adViewWillLeaveApplication:(YMAAdView *)adView;
        [Export("adViewWillLeaveApplication:")]
        void AdViewWillLeaveApplication(YMAAdView adView);

        // @optional -(void)adViewWillPresentScreen:(UIViewController *)viewController;
        [Export("adViewWillPresentScreen:")]
        void AdViewWillPresentScreen(UIViewController viewController);

        // @optional -(void)adViewDidDismissScreen:(UIViewController *)viewController;
        [Export("adViewDidDismissScreen:")]
        void AdViewDidDismissScreen(UIViewController viewController);
    }

    // @protocol YMANativeImageAd <YMANativeGenericAd>
    [Protocol, Model]
    [BaseType(typeof(YMANativeGenericAd))]
    interface YMANativeImageAd
    {
        // @required -(BOOL)bindImageAdToView:(YMANativeImageAdView * _Nonnull)view delegate:(id<YMANativeAdDelegate> _Nullable)delegate error:(NSError * _Nullable * _Nullable)error;
        [Abstract]
        [Export("bindImageAdToView:delegate:error:")]
        bool Delegate(YMANativeImageAdView view, [NullAllowed] YMANativeAdDelegate @delegate, [NullAllowed] out NSError error);
    }

    partial interface Constants
    {
        // extern NSString *const _Nonnull kYMAGenderMale;
        [Field("kYMAGenderMale", "__Internal")]
        NSString kYMAGenderMale { get; }

        // extern NSString *const _Nonnull kYMAGenderFemale;
        [Field("kYMAGenderFemale", "__Internal")]
        NSString kYMAGenderFemale { get; }
    }

    // @interface YMAMobileAds : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAMobileAds
    {
        // +(void)enableLogging;
        [Static]
        [Export("enableLogging")]
        void EnableLogging();

        // +(NSString *)SDKVersion;
        [Static]
        [Export("SDKVersion")]
        string SDKVersion { get; }

        // +(void)setLocationTrackingEnabled:(BOOL)enabled;
        [Static]
        [Export("setLocationTrackingEnabled:")]
        void SetLocationTrackingEnabled(bool enabled);

        // +(void)enableVisibilityErrorIndicatorForDeviceType:(YMADeviceType)deviceType;
        [Static]
        [Export("enableVisibilityErrorIndicatorForDeviceType:")]
        void EnableVisibilityErrorIndicatorForDeviceType(YMADeviceType deviceType);

        // +(void)setUserConsent:(BOOL)consent;
        [Static]
        [Export("setUserConsent:")]
        void SetUserConsent(bool consent);
    }

    // @interface YMAAdSize : NSObject
    [BaseType(typeof(NSObject))]
    interface YMAAdSize
    {
        // @property (readonly, assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull attributes;
        [Export("attributes", ArgumentSemantic.Copy)]
        NSDictionary Attributes { get; }

        // +(instancetype _Nonnull)fixedSizeWithCGSize:(CGSize)size;
        [Static]
        [Export("fixedSizeWithCGSize:")]
        YMAAdSize FixedSizeWithCGSize(CGSize size);

        // +(instancetype _Nonnull)flexibleSize;
        [Static]
        [Export("flexibleSize")]
        YMAAdSize FlexibleSize();

        // +(instancetype _Nonnull)flexibleSizeWithContainerWidth:(CGFloat)width;
        [Static]
        [Export("flexibleSizeWithContainerWidth:")]
        YMAAdSize FlexibleSizeWithContainerWidth(nfloat width);

        // +(instancetype _Nonnull)flexibleSizeWithCGSize:(CGSize)size;
        [Static]
        [Export("flexibleSizeWithCGSize:")]
        YMAAdSize FlexibleSizeWithCGSize(CGSize size);

        // extern const CGSize YMAAdSizeBanner_320x50;
        [Field("YMAAdSizeBanner_320x50", "__Internal")]
        CGSize YMAAdSizeBanner_320x50 { get; }

        // extern const CGSize YMAAdSizeBanner_320x100;
        [Field("YMAAdSizeBanner_320x100", "__Internal")]
        CGSize YMAAdSizeBanner_320x100 { get; }

        // extern const CGSize YMAAdSizeBanner_300x250;
        [Field("YMAAdSizeBanner_300x250", "__Internal")]
        CGSize YMAAdSizeBanner_300x250 { get; }

        // extern const CGSize YMAAdSizeBanner_300x300;
        [Field("YMAAdSizeBanner_300x300", "__Internal")]
        CGSize YMAAdSizeBanner_300x300 { get; }

        // extern const CGSize YMAAdSizeBanner_240x400;
        [Field("YMAAdSizeBanner_240x400", "__Internal")]
        CGSize YMAAdSizeBanner_240x400 { get; }

        // extern const CGSize YMAAdSizeBanner_400x240;
        [Field("YMAAdSizeBanner_400x240", "__Internal")]
        CGSize YMAAdSizeBanner_400x240 { get; }

        // extern const CGSize YMAAdSizeBanner_728x90;
        [Field("YMAAdSizeBanner_728x90", "__Internal")]
        CGSize YMAAdSizeBanner_728x90 { get; }
    }

    // @interface YMAAdRequest : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMAAdRequest : INSCopying, INSMutableCopying
    {
        // @property (readonly, copy, nonatomic) CLLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Copy)]
        CLLocation Location { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable contextQuery;
        [NullAllowed, Export("contextQuery")]
        string ContextQuery { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable contextTags;
        [NullAllowed, Export("contextTags", ArgumentSemantic.Copy)]
        NSString []ContextTags { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable gender;
        [NullAllowed, Export("gender")]
        string Gender { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable age;
        [NullAllowed, Export("age", ArgumentSemantic.Strong)]
        NSNumber Age { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable parameters;
        [NullAllowed, Export("parameters", ArgumentSemantic.Copy)]
        NSDictionary Parameters { get; }

        // -(instancetype _Nonnull)initWithLocation:(CLLocation * _Nullable)location contextQuery:(NSString * _Nullable)contextQuery contextTags:(NSArray * _Nullable)contextTags;
        [Export("initWithLocation:contextQuery:contextTags:")]
        IntPtr Constructor([NullAllowed] CLLocation location, [NullAllowed] string contextQuery, [NullAllowed] NSString []contextTags);

        // -(instancetype _Nonnull)initWithLocation:(CLLocation * _Nullable)location contextQuery:(NSString * _Nullable)contextQuery contextTags:(NSArray * _Nullable)contextTags parameters:(NSDictionary * _Nullable)parameters __attribute__((objc_designated_initializer));
        [Export("initWithLocation:contextQuery:contextTags:parameters:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] CLLocation location, [NullAllowed] string contextQuery, [NullAllowed] NSString []contextTags, [NullAllowed] NSDictionary parameters);
    }

    // @interface YMAMutableAdRequest : YMAAdRequest
    [BaseType(typeof(YMAAdRequest))]
    interface YMAMutableAdRequest
    {
        // @property (copy, nonatomic) CLLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Copy)]
        CLLocation Location { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable contextQuery;
        [NullAllowed, Export("contextQuery")]
        string ContextQuery { get; set; }

        // @property (copy, nonatomic) NSArray * _Nullable contextTags;
        [NullAllowed, Export("contextTags", ArgumentSemantic.Copy)]
        NSString []ContextTags { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable gender;
        [NullAllowed, Export("gender")]
        string Gender { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable age;
        [NullAllowed, Export("age", ArgumentSemantic.Strong)]
        NSNumber Age { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable parameters;
        [NullAllowed, Export("parameters", ArgumentSemantic.Copy)]
        NSDictionary Parameters { get; set; }
    }

    // @interface YMAInterstitialController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface YMAInterstitialController
    {
        // @property (readonly, copy, nonatomic) NSString * blockID;
        [Export("blockID")]
        string BlockID { get; }

        // @property (readonly, assign, nonatomic) BOOL loaded;
        [Export("loaded")]
        bool Loaded { get; }

        [Wrap("WeakDelegate")]
        YMAInterstitialDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMAInterstitialDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL shouldOpenLinksInApp;
        [Export("shouldOpenLinksInApp")]
        bool ShouldOpenLinksInApp { get; set; }

        // @property (readonly, assign, nonatomic) BOOL hasBeenPresented;
        [Export("hasBeenPresented")]
        bool HasBeenPresented { get; }

        // -(instancetype)initWithBlockID:(NSString *)blockID;
        [Export("initWithBlockID:")]
        IntPtr Constructor(string blockID);

        // -(void)load;
        [Export("load")]
        void Load();

        // -(void)loadWithRequest:(YMAAdRequest *)request;
        [Export("loadWithRequest:")]
        void LoadWithRequest(YMAAdRequest request);

        // -(void)presentInterstitialFromViewController:(UIViewController *)viewController;
        [Export("presentInterstitialFromViewController:")]
        void PresentInterstitialFromViewController(UIViewController viewController);

        // -(void)presentInterstitialFromViewController:(UIViewController *)viewController dismissalBlock:(void (^)(void))dismissalBlock;
        [Export("presentInterstitialFromViewController:dismissalBlock:")]
        void PresentInterstitialFromViewController(UIViewController viewController, Action dismissalBlock);
    }

    // @protocol YMAInterstitialDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMAInterstitialDelegate
    {
        // @optional -(void)interstitialDidLoadAd:(YMAInterstitialController *)interstitial;
        [Export("interstitialDidLoadAd:")]
        void InterstitialDidLoadAd(YMAInterstitialController interstitial);

        // @optional -(void)interstitialDidFailToLoadAd:(YMAInterstitialController *)interstitial error:(NSError *)error;
        [Export("interstitialDidFailToLoadAd:error:")]
        void InterstitialDidFailToLoadAd(YMAInterstitialController interstitial, NSError error);

        // @optional -(void)interstitialWillLeaveApplication:(YMAInterstitialController *)interstitial;
        [Export("interstitialWillLeaveApplication:")]
        void InterstitialWillLeaveApplication(YMAInterstitialController interstitial);

        // @optional -(void)interstitialDidFailToPresentAd:(YMAInterstitialController *)interstitial error:(NSError *)error;
        [Export("interstitialDidFailToPresentAd:error:")]
        void InterstitialDidFailToPresentAd(YMAInterstitialController interstitial, NSError error);

        // @optional -(void)interstitialWillAppear:(YMAInterstitialController *)interstitial;
        [Export("interstitialWillAppear:")]
        void InterstitialWillAppear(YMAInterstitialController interstitial);

        // @optional -(void)interstitialDidAppear:(YMAInterstitialController *)interstitial;
        [Export("interstitialDidAppear:")]
        void InterstitialDidAppear(YMAInterstitialController interstitial);

        // @optional -(void)interstitialWillDisappear:(YMAInterstitialController *)interstitial;
        [Export("interstitialWillDisappear:")]
        void InterstitialWillDisappear(YMAInterstitialController interstitial);

        // @optional -(void)interstitialDidDisappear:(YMAInterstitialController *)interstitial;
        [Export("interstitialDidDisappear:")]
        void InterstitialDidDisappear(YMAInterstitialController interstitial);

        // @optional -(void)interstitialWillPresentScreen:(UIViewController *)webBrowser;
        [Export("interstitialWillPresentScreen:")]
        void InterstitialWillPresentScreen(UIViewController webBrowser);
    }

    // @interface YMARewardedAd : NSObject
    [BaseType(typeof(NSObject))]
    interface YMARewardedAd
    {
        // @property (readonly, copy, nonatomic) NSString * blockID;
        [Export("blockID")]
        string BlockID { get; }

        // @property (readonly, assign, nonatomic) BOOL loaded;
        [Export("loaded")]
        bool Loaded { get; }

        [Wrap("WeakDelegate")]
        YMARewardedAdDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<YMARewardedAdDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL shouldOpenLinksInApp;
        [Export("shouldOpenLinksInApp")]
        bool ShouldOpenLinksInApp { get; set; }

        // @property (readonly, assign, nonatomic) BOOL hasBeenPresented;
        [Export("hasBeenPresented")]
        bool HasBeenPresented { get; }

        // @property (copy, nonatomic) NSString * userID;
        [Export("userID")]
        string UserID { get; set; }

        // -(instancetype)initWithBlockID:(NSString *)blockID;
        [Export("initWithBlockID:")]
        IntPtr Constructor(string blockID);

        // -(void)load;
        [Export("load")]
        void Load();

        // -(void)loadWithRequest:(YMAAdRequest *)request;
        [Export("loadWithRequest:")]
        void LoadWithRequest(YMAAdRequest request);

        // -(void)presentFromViewController:(UIViewController *)viewController;
        [Export("presentFromViewController:")]
        void PresentFromViewController(UIViewController viewController);

        // -(void)presentFromViewController:(UIViewController *)viewController dismissalBlock:(void (^)(void))dismissalBlock;
        [Export("presentFromViewController:dismissalBlock:")]
        void PresentFromViewController(UIViewController viewController, Action dismissalBlock);
    }

    // @protocol YMARewardedAdDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMARewardedAdDelegate
    {
        // @optional -(void)rewardedAd:(YMARewardedAd *)rewardedAd didReward:(id<YMAReward>)reward;
        [Export("rewardedAd:didReward:")]
        void RewardedAd(YMARewardedAd rewardedAd, YMAReward reward);

        // @optional -(void)rewardedAdDidLoadAd:(YMARewardedAd *)rewardedAd;
        [Export("rewardedAdDidLoadAd:")]
        void RewardedAdDidLoadAd(YMARewardedAd rewardedAd);

        // @optional -(void)rewardedAdDidFailToLoadAd:(YMARewardedAd *)rewardedAd error:(NSError *)error;
        [Export("rewardedAdDidFailToLoadAd:error:")]
        void RewardedAdDidFailToLoadAd(YMARewardedAd rewardedAd, NSError error);

        // @optional -(void)rewardedAdWillLeaveApplication:(YMARewardedAd *)rewardedAd;
        [Export("rewardedAdWillLeaveApplication:")]
        void RewardedAdWillLeaveApplication(YMARewardedAd rewardedAd);

        // @optional -(void)rewardedAdDidFailToPresentAd:(YMARewardedAd *)rewardedAd error:(NSError *)error;
        [Export("rewardedAdDidFailToPresentAd:error:")]
        void RewardedAdDidFailToPresentAd(YMARewardedAd rewardedAd, NSError error);

        // @optional -(void)rewardedAdWillAppear:(YMARewardedAd *)rewardedAd;
        [Export("rewardedAdWillAppear:")]
        void RewardedAdWillAppear(YMARewardedAd rewardedAd);

        // @optional -(void)rewardedAdDidAppear:(YMARewardedAd *)rewardedAd;
        [Export("rewardedAdDidAppear:")]
        void RewardedAdDidAppear(YMARewardedAd rewardedAd);

        // @optional -(void)rewardedAdWillDisappear:(YMARewardedAd *)rewardedAd;
        [Export("rewardedAdWillDisappear:")]
        void RewardedAdWillDisappear(YMARewardedAd rewardedAd);

        // @optional -(void)rewardedAdDidDisappear:(YMARewardedAd *)rewardedAd;
        [Export("rewardedAdDidDisappear:")]
        void RewardedAdDidDisappear(YMARewardedAd rewardedAd);

        // @optional -(void)rewardedAd:(YMARewardedAd *)rewardedAd willPresentScreen:(UIViewController *)viewController;
        [Export("rewardedAd:willPresentScreen:")]
        void RewardedAd(YMARewardedAd rewardedAd, UIViewController viewController);
    }

    // @interface YMALog : NSObject
    [BaseType(typeof(NSObject))]
    interface YMALog
    {
        // +(void)enableLogging;
        [Static]
        [Export("enableLogging")]
        void EnableLogging();
    }

    // @protocol YMAVideoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMAVideoDelegate
    {
        // @optional -(void)videoControllerDidFinishPlayingVideo:(YMAVideoController * _Nonnull)videoController;
        [Export("videoControllerDidFinishPlayingVideo:")]
        void VideoControllerDidFinishPlayingVideo(YMAVideoController videoController);
    }

    // @protocol YMANativeContentAd <YMANativeGenericAd>
    [Protocol, Model]
    [BaseType(typeof(YMANativeGenericAd))]
    interface YMANativeContentAd
    {
        // @required -(BOOL)bindContentAdToView:(YMANativeContentAdView * _Nonnull)view delegate:(id<YMANativeAdDelegate> _Nullable)delegate error:(NSError * _Nullable * _Nullable)error;
        [Abstract]
        [Export("bindContentAdToView:delegate:error:")]
        bool Delegate(YMANativeContentAdView view, [NullAllowed] YMANativeAdDelegate @delegate, [NullAllowed] out NSError error);
    }

    // @protocol YMANativeAppInstallAd <YMANativeGenericAd>
    [Protocol, Model]
    [BaseType(typeof(YMANativeGenericAd))]
    interface YMANativeAppInstallAd
    {
        // @required -(BOOL)bindAppInstallAdToView:(YMANativeAppInstallAdView * _Nonnull)view delegate:(id<YMANativeAdDelegate> _Nullable)delegate error:(NSError * _Nullable * _Nullable)error;
        [Abstract]
        [Export("bindAppInstallAdToView:delegate:error:")]
        bool Delegate(YMANativeAppInstallAdView view, [NullAllowed] YMANativeAdDelegate @delegate, [NullAllowed] out NSError error);
    }

    // @protocol YMANativeAdDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMANativeAdDelegate
    {
        // @optional -(UIViewController * _Nonnull)viewControllerForPresentingModalView;
        [Export("viewControllerForPresentingModalView")]
        UIViewController ViewControllerForPresentingModalView { get; }

        // @optional -(void)nativeAdWillLeaveApplication:(id _Null_unspecified)ad;
        [Export("nativeAdWillLeaveApplication:")]
        void NativeAdWillLeaveApplication(NSObject ad);

        // @optional -(void)nativeAd:(id _Null_unspecified)ad willPresentScreen:(UIViewController * _Nullable)viewController;
        [Export("nativeAd:willPresentScreen:")]
        void NativeAdWillPresentScreen(NSObject ad, [NullAllowed] UIViewController viewController);

        // @optional -(void)nativeAd:(id _Null_unspecified)ad didDismissScreen:(UIViewController * _Nullable)viewController;
        [Export("nativeAd:didDismissScreen:")]
        void NativeAdDidDismissScreen(NSObject ad, [NullAllowed] UIViewController viewController);

        // @optional -(void)closeNativeAd:(id _Null_unspecified)ad;
        [Export("closeNativeAd:")]
        void CloseNativeAd(NSObject ad);
    }

    partial interface Constants
    {
        // extern NSString *const kYMANativeAdErrorDomain;
        [Field("kYMANativeAdErrorDomain", "__Internal")]
        NSString kYMANativeAdErrorDomain { get; }
    }

    // @interface YMANativeTemplateAppearance : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMANativeTemplateAppearance : INSCopying, INSMutableCopying
    {
        // @property (readonly, assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; }

        // @property (readonly, assign, nonatomic) YMAHorizontalOffset contentPadding;
        [Export("contentPadding", ArgumentSemantic.Assign)]
        YMAHorizontalOffset ContentPadding { get; }

        // @property (readonly, assign, nonatomic) YMAHorizontalOffset imageMargins;
        [Export("imageMargins", ArgumentSemantic.Assign)]
        YMAHorizontalOffset ImageMargins { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable ageAppearance;
        [NullAllowed, Export("ageAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance AgeAppearance { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable bodyAppearance;
        [NullAllowed, Export("bodyAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance BodyAppearance { get; }

        // @property (readonly, copy, nonatomic) YMAButtonAppearance * _Nullable callToActionAppearance;
        [NullAllowed, Export("callToActionAppearance", ArgumentSemantic.Copy)]
        YMAButtonAppearance CallToActionAppearance { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable domainAppearance;
        [NullAllowed, Export("domainAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance DomainAppearance { get; }

        // @property (readonly, copy, nonatomic) YMAImageAppearance * _Nullable faviconAppearance;
        [NullAllowed, Export("faviconAppearance", ArgumentSemantic.Copy)]
        YMAImageAppearance FaviconAppearance { get; }

        // @property (readonly, copy, nonatomic) YMAImageAppearance * _Nullable imageAppearance;
        [NullAllowed, Export("imageAppearance", ArgumentSemantic.Copy)]
        YMAImageAppearance ImageAppearance { get; }

        // @property (readonly, copy, nonatomic) YMARatingAppearance * _Nullable ratingAppearance;
        [NullAllowed, Export("ratingAppearance", ArgumentSemantic.Copy)]
        YMARatingAppearance RatingAppearance { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable sponsoredAppearance;
        [NullAllowed, Export("sponsoredAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance SponsoredAppearance { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable titleAppearance;
        [NullAllowed, Export("titleAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance TitleAppearance { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable reviewCountAppearance;
        [NullAllowed, Export("reviewCountAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance ReviewCountAppearance { get; }

        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nullable warningAppearance;
        [NullAllowed, Export("warningAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance WarningAppearance { get; }

        // +(instancetype _Nonnull)defaultAppearance;
        [Static]
        [Export("defaultAppearance")]
        YMANativeTemplateAppearance DefaultAppearance();
    }

    // @interface YMAMutableNativeTemplateAppearance : YMANativeTemplateAppearance
    [BaseType(typeof(YMANativeTemplateAppearance))]
    interface YMAMutableNativeTemplateAppearance
    {
        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (assign, nonatomic) YMAHorizontalOffset contentPadding;
        [Export("contentPadding", ArgumentSemantic.Assign)]
        YMAHorizontalOffset ContentPadding { get; set; }

        // @property (assign, nonatomic) YMAHorizontalOffset imageMargins;
        [Export("imageMargins", ArgumentSemantic.Assign)]
        YMAHorizontalOffset ImageMargins { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable ageAppearance;
        [NullAllowed, Export("ageAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance AgeAppearance { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable bodyAppearance;
        [NullAllowed, Export("bodyAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance BodyAppearance { get; set; }

        // @property (copy, nonatomic) YMAButtonAppearance * _Nullable callToActionAppearance;
        [NullAllowed, Export("callToActionAppearance", ArgumentSemantic.Copy)]
        YMAButtonAppearance CallToActionAppearance { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable domainAppearance;
        [NullAllowed, Export("domainAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance DomainAppearance { get; set; }

        // @property (copy, nonatomic) YMAImageAppearance * _Nullable faviconAppearance;
        [NullAllowed, Export("faviconAppearance", ArgumentSemantic.Copy)]
        YMAImageAppearance FaviconAppearance { get; set; }

        // @property (copy, nonatomic) YMAImageAppearance * _Nullable imageAppearance;
        [NullAllowed, Export("imageAppearance", ArgumentSemantic.Copy)]
        YMAImageAppearance ImageAppearance { get; set; }

        // @property (copy, nonatomic) YMARatingAppearance * _Nullable ratingAppearance;
        [NullAllowed, Export("ratingAppearance", ArgumentSemantic.Copy)]
        YMARatingAppearance RatingAppearance { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable sponsoredAppearance;
        [NullAllowed, Export("sponsoredAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance SponsoredAppearance { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable titleAppearance;
        [NullAllowed, Export("titleAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance TitleAppearance { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable reviewCountAppearance;
        [NullAllowed, Export("reviewCountAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance ReviewCountAppearance { get; set; }

        // @property (copy, nonatomic) YMALabelAppearance * _Nullable warningAppearance;
        [NullAllowed, Export("warningAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance WarningAppearance { get; set; }
    }

    // @interface YMALabelAppearance : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMALabelAppearance : INSCopying, INSMutableCopying
    {
        // @property (readonly, nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; }

        // +(instancetype _Nonnull)appearanceWithFont:(UIFont * _Nonnull)font textColor:(UIColor * _Nonnull)textColor;
        [Static]
        [Export("appearanceWithFont:textColor:")]
        YMALabelAppearance AppearanceWithFont(UIFont font, UIColor textColor);
    }

    // @interface YMAMutableLabelAppearance : YMALabelAppearance
    [BaseType(typeof(YMALabelAppearance))]
    interface YMAMutableLabelAppearance
    {
        // @property (nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface YMAButtonAppearance : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMAButtonAppearance : INSCopying, INSMutableCopying
    {
        // @property (readonly, copy, nonatomic) YMALabelAppearance * _Nonnull textAppearance;
        [Export("textAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance TextAppearance { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull highlightedTextColor;
        [Export("highlightedTextColor", ArgumentSemantic.Strong)]
        UIColor HighlightedTextColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull normalColor;
        [Export("normalColor", ArgumentSemantic.Strong)]
        UIColor NormalColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull highlightedColor;
        [Export("highlightedColor", ArgumentSemantic.Strong)]
        UIColor HighlightedColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; }

        // @property (readonly, assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; }

        // +(instancetype _Nonnull)appearanceWithTextAppearance:(YMALabelAppearance * _Nonnull)textAppearance normalColor:(UIColor * _Nonnull)normalColor highlightedColor:(UIColor * _Nonnull)highlightedColor borderColor:(UIColor * _Nonnull)borderColor borderWidth:(CGFloat)borderWidth;
        [Static]
        [Export("appearanceWithTextAppearance:normalColor:highlightedColor:borderColor:borderWidth:")]
        YMAButtonAppearance AppearanceWithTextAppearance(YMALabelAppearance textAppearance, UIColor normalColor, UIColor highlightedColor, UIColor borderColor, nfloat borderWidth);

        // +(instancetype _Nonnull)appearanceWithTextAppearance:(YMALabelAppearance * _Nonnull)textAppearance highlightedTextColor:(UIColor * _Nonnull)highlightedTextColor normalColor:(UIColor * _Nonnull)normalColor highlightedColor:(UIColor * _Nonnull)highlightedColor borderColor:(UIColor * _Nonnull)borderColor borderWidth:(CGFloat)borderWidth;
        [Static]
        [Export("appearanceWithTextAppearance:highlightedTextColor:normalColor:highlightedColor:borderColor:borderWidth:")]
        YMAButtonAppearance AppearanceWithTextAppearance(YMALabelAppearance textAppearance, UIColor highlightedTextColor, UIColor normalColor, UIColor highlightedColor, UIColor borderColor, nfloat borderWidth);
    }

    // @interface YMAMutableButtonAppearance : YMAButtonAppearance
    [BaseType(typeof(YMAButtonAppearance))]
    interface YMAMutableButtonAppearance
    {
        // @property (copy, nonatomic) YMALabelAppearance * _Nonnull textAppearance;
        [Export("textAppearance", ArgumentSemantic.Copy)]
        YMALabelAppearance TextAppearance { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull highlightedTextColor;
        [Export("highlightedTextColor", ArgumentSemantic.Strong)]
        UIColor HighlightedTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull normalColor;
        [Export("normalColor", ArgumentSemantic.Strong)]
        UIColor NormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull highlightedColor;
        [Export("highlightedColor", ArgumentSemantic.Strong)]
        UIColor HighlightedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }
    }

    // @interface YMARatingAppearance : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMARatingAppearance : INSCopying, INSMutableCopying
    {
        // @property (readonly, nonatomic, strong) UIColor * _Nonnull emptyStarColor;
        [Export("emptyStarColor", ArgumentSemantic.Strong)]
        UIColor EmptyStarColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull filledStarColor;
        [Export("filledStarColor", ArgumentSemantic.Strong)]
        UIColor FilledStarColor { get; }

        // @property (readonly, assign, nonatomic) CGFloat preferredStarSize;
        [Export("preferredStarSize")]
        nfloat PreferredStarSize { get; }

        // +(instancetype _Nonnull)appearanceWithEmptyStarColor:(UIColor * _Nonnull)emptyStarColor filledStarColor:(UIColor * _Nonnull)filledStarColor starSize:(CGFloat)starSize;
        [Static]
        [Export("appearanceWithEmptyStarColor:filledStarColor:starSize:")]
        YMARatingAppearance AppearanceWithEmptyStarColor(UIColor emptyStarColor, UIColor filledStarColor, nfloat starSize);
    }

    // @interface YMAMutableRatingAppearance : YMARatingAppearance
    [BaseType(typeof(YMARatingAppearance))]
    interface YMAMutableRatingAppearance
    {
        // @property (nonatomic, strong) UIColor * _Nonnull emptyStarColor;
        [Export("emptyStarColor", ArgumentSemantic.Strong)]
        UIColor EmptyStarColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull filledStarColor;
        [Export("filledStarColor", ArgumentSemantic.Strong)]
        UIColor FilledStarColor { get; set; }

        // @property (assign, nonatomic) CGFloat preferredStarSize;
        [Export("preferredStarSize")]
        nfloat PreferredStarSize { get; set; }
    }

    // @interface YMAImageAppearance : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMAImageAppearance : INSCopying, INSMutableCopying
    {
        // @property (readonly, nonatomic, strong) YMASizeConstraint * _Nonnull widthConstraint;
        [Export("widthConstraint", ArgumentSemantic.Strong)]
        YMASizeConstraint WidthConstraint { get; }

        // +(instancetype _Nonnull)appearanceWithWidthConstraint:(YMASizeConstraint * _Nonnull)widthConstraint;
        [Static]
        [Export("appearanceWithWidthConstraint:")]
        YMAImageAppearance AppearanceWithWidthConstraint(YMASizeConstraint widthConstraint);
    }

    // @interface YMAMutableImageAppearance : YMAImageAppearance
    [BaseType(typeof(YMAImageAppearance))]
    interface YMAMutableImageAppearance
    {
        // @property (nonatomic, strong) YMASizeConstraint * _Nonnull widthConstraint;
        [Export("widthConstraint", ArgumentSemantic.Strong)]
        YMASizeConstraint WidthConstraint { get; set; }
    }

    // @interface YMASizeConstraint : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface YMASizeConstraint : INSCopying, INSMutableCopying
    {
        // @property (readonly, assign, nonatomic) YMASizeConstraintType type;
        [Export("type", ArgumentSemantic.Assign)]
        YMASizeConstraintType Type { get; }

        // @property (readonly, assign, nonatomic) CGFloat value;
        [Export("value")]
        nfloat Value { get; }

        // +(instancetype _Nonnull)constraintWithType:(YMASizeConstraintType)type value:(CGFloat)value;
        [Static]
        [Export("constraintWithType:value:")]
        YMASizeConstraint ConstraintWithType(YMASizeConstraintType type, nfloat value);
    }

    // @interface YMAMutableSizeConstraint : YMASizeConstraint
    [BaseType(typeof(YMASizeConstraint))]
    interface YMAMutableSizeConstraint
    {
        // @property (assign, nonatomic) YMASizeConstraintType type;
        [Export("type", ArgumentSemantic.Assign)]
        YMASizeConstraintType Type { get; set; }

        // @property (assign, nonatomic) CGFloat value;
        [Export("value")]
        nfloat Value { get; set; }
    }

    // @interface YMANativeAdImage : NSObject
    [BaseType(typeof(NSObject))]
    interface YMANativeAdImage
    {
        // @property (readonly, assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nullable imageValue;
        [NullAllowed, Export("imageValue", ArgumentSemantic.Strong)]
        UIImage ImageValue { get; }
    }

    // @interface YMANativeAdAssets : NSObject
    [BaseType(typeof(NSObject))]
    interface YMANativeAdAssets
    {
        // @property (copy, nonatomic) NSString * _Nullable age;
        [NullAllowed, Export("age")]
        string Age { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable body;
        [NullAllowed, Export("body")]
        string Body { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable callToAction;
        [NullAllowed, Export("callToAction")]
        string CallToAction { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable domain;
        [NullAllowed, Export("domain")]
        string Domain { get; set; }

        // @property (nonatomic, strong) YMANativeAdImage * _Nullable favicon;
        [NullAllowed, Export("favicon", ArgumentSemantic.Strong)]
        YMANativeAdImage Favicon { get; set; }

        // @property (assign, nonatomic) BOOL feedbackAvailable;
        [Export("feedbackAvailable")]
        bool FeedbackAvailable { get; set; }

        // @property (nonatomic, strong) YMANativeAdImage * _Nullable icon;
        [NullAllowed, Export("icon", ArgumentSemantic.Strong)]
        YMANativeAdImage Icon { get; set; }

        // @property (nonatomic, strong) YMANativeAdImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        YMANativeAdImage Image { get; set; }

        // @property (nonatomic, strong) YMANativeAdMedia * _Nullable media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        YMANativeAdMedia Media { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable price;
        [NullAllowed, Export("price")]
        string Price { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable rating;
        [NullAllowed, Export("rating", ArgumentSemantic.Strong)]
        NSNumber Rating { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable reviewCount;
        [NullAllowed, Export("reviewCount")]
        string ReviewCount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sponsored;
        [NullAllowed, Export("sponsored")]
        string Sponsored { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable warning;
        [NullAllowed, Export("warning")]
        string Warning { get; set; }
    }

    // @interface YMANativeMediaView : UIView
    [BaseType(typeof(UIView))]
    interface YMANativeMediaView
    {
    }
}
