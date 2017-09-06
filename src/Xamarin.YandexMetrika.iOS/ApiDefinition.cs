using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace Xamarin.YandexMetrika.iOS
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull kYMMYandexMetricaErrorDomain;
        [Field("kYMMYandexMetricaErrorDomain", "__Internal")]
        NSString kYMMYandexMetricaErrorDomain { get; }
    }

    // @interface YMMYandexMetrica : NSObject
    [BaseType(typeof(NSObject))]
    interface YMMYandexMetrica
    {
        // +(void)activateWithApiKey:(NSString * _Nonnull)apiKey;
        [Static]
        [Export("activateWithApiKey:")]
        void ActivateWithApiKey(string apiKey);

        // +(void)activateWithConfiguration:(YMMYandexMetricaConfiguration * _Nonnull)configuration;
        [Static]
        [Export("activateWithConfiguration:")]
        void ActivateWithConfiguration(YMMYandexMetricaConfiguration configuration);

        // +(void)reportEvent:(NSString * _Nonnull)message onFailure:(void (^ _Nullable)(NSError * _Nonnull))onFailure;
        [Static]
        [Export("reportEvent:onFailure:")]
        void ReportEvent(string message, [NullAllowed] Action<NSError> onFailure);

        // +(void)reportEvent:(NSString * _Nonnull)message parameters:(NSDictionary * _Nullable)params onFailure:(void (^ _Nullable)(NSError * _Nonnull))onFailure;
        [Static]
        [Export("reportEvent:parameters:onFailure:")]
        void ReportEvent(string message, [NullAllowed] NSDictionary @params, [NullAllowed] Action<NSError> onFailure);

        // +(void)reportError:(NSString * _Nonnull)message exception:(NSException * _Nullable)exception onFailure:(void (^ _Nullable)(NSError * _Nonnull))onFailure;
        [Static]
        [Export("reportError:exception:onFailure:")]
        void ReportError(string message, [NullAllowed] NSException exception, [NullAllowed] Action<NSError> onFailure);

        // +(void)setTrackLocationEnabled:(BOOL)enabled;
        [Static]
        [Export("setTrackLocationEnabled:")]
        void SetTrackLocationEnabled(bool enabled);

        // +(void)setLocation:(CLLocation * _Nullable)location;
        [Static]
        [Export("setLocation:")]
        void SetLocation([NullAllowed] CLLocation location);

        // +(void)setSessionTimeout:(NSUInteger)sessionTimeoutSeconds;
        [Static]
        [Export("setSessionTimeout:")]
        void SetSessionTimeout(nuint sessionTimeoutSeconds);

        // +(void)setReportCrashesEnabled:(BOOL)enabled;
        [Static]
        [Export("setReportCrashesEnabled:")]
        void SetReportCrashesEnabled(bool enabled);

        // +(void)setCustomAppVersion:(NSString * _Nonnull)appVersion;
        [Static]
        [Export("setCustomAppVersion:")]
        void SetCustomAppVersion(string appVersion);

        // +(void)setLoggingEnabled:(BOOL)isEnabled;
        [Static]
        [Export("setLoggingEnabled:")]
        void SetLoggingEnabled(bool isEnabled);

        // +(void)setEnvironmentValue:(NSString * _Nullable)value forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("setEnvironmentValue:forKey:")]
        void SetEnvironmentValue([NullAllowed] string value, string key);

        // +(NSString * _Nonnull)libraryVersion;
        [Static]
        [Export("libraryVersion")]
        //[Verify(MethodToProperty)]
        string LibraryVersion { get; }

        // +(BOOL)enableTrackingWithURLScheme:(NSURL * _Nonnull)urlScheme __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(ios_app_extension, unavailable)));
        [Deprecated(PlatformName.iOS, 9, 0)]
        [Static]
        [Export("enableTrackingWithURLScheme:")]
        bool EnableTrackingWithURLScheme(NSUrl urlScheme);

        // +(BOOL)handleOpenURL:(NSURL * _Nonnull)url;
        [Static]
        [Export("handleOpenURL:")]
        bool HandleOpenURL(NSUrl url);

        // +(id<YMMYandexMetricaReporting> _Nullable)reporterForApiKey:(NSString * _Nonnull)apiKey;
        [Static]
        [Export("reporterForApiKey:")]
        [return: NullAllowed]
        YMMYandexMetricaReporting ReporterForApiKey(string apiKey);

        // +(void)reportReferralUrl:(NSURL * _Nonnull)url;
        [Static]
        [Export("reportReferralUrl:")]
        void ReportReferralUrl(NSUrl url);
    }

    // @interface YMMYandexMetricaDeprecatedOrUnavailable (YMMYandexMetrica)
    [Category]
    [BaseType(typeof(YMMYandexMetrica))]
    interface YMMYandexMetrica_YMMYandexMetricaDeprecatedOrUnavailable
    {
    }

    // @interface YMMYandexMetricaConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMMYandexMetricaConfiguration
    {
        // -(instancetype _Nullable)initWithApiKey:(NSString * _Nonnull)apiKey;
        [Export("initWithApiKey:")]
        IntPtr Constructor(string apiKey);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull apiKey;
        [Export("apiKey")]
        string ApiKey { get; }

        // @property (assign, nonatomic) BOOL handleFirstActivationAsUpdateEnabled;
        [Export("handleFirstActivationAsUpdateEnabled")]
        bool HandleFirstActivationAsUpdateEnabled { get; set; }

        // @property (assign, nonatomic) BOOL trackLocationEnabled;
        [Export("trackLocationEnabled")]
        bool TrackLocationEnabled { get; set; }

        // @property (nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; set; }

        // @property (assign, nonatomic) NSUInteger sessionTimeout;
        [Export("sessionTimeout")]
        nuint SessionTimeout { get; set; }

        // @property (assign, nonatomic) BOOL reportCrashesEnabled;
        [Export("reportCrashesEnabled")]
        bool ReportCrashesEnabled { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable customAppVersion;
        [NullAllowed, Export("customAppVersion")]
        string CustomAppVersion { get; set; }

        // @property (assign, nonatomic) BOOL loggingEnabled;
        [Export("loggingEnabled")]
        bool LoggingEnabled { get; set; }

        // @property (copy, nonatomic) YMMYandexMetricaPreloadInfo * _Nullable preloadInfo;
        [NullAllowed, Export("preloadInfo", ArgumentSemantic.Copy)]
        YMMYandexMetricaPreloadInfo PreloadInfo { get; set; }
    }

    // @protocol YMMYandexMetricaReporting <NSObject>
    [BaseType(typeof(NSObject))]
    [Model]
    interface YMMYandexMetricaReporting
    {
        // @required -(void)reportEvent:(NSString * _Nonnull)name onFailure:(void (^ _Nullable)(NSError * _Nonnull))onFailure;
        [Abstract]
        [Export("reportEvent:onFailure:")]
        void ReportEvent(string name, [NullAllowed] Action<NSError> onFailure);

        // @required -(void)reportEvent:(NSString * _Nonnull)name parameters:(NSDictionary * _Nullable)params onFailure:(void (^ _Nullable)(NSError * _Nonnull))onFailure;
        [Abstract]
        [Export("reportEvent:parameters:onFailure:")]
        void ReportEvent(string name, [NullAllowed] NSDictionary @params, [NullAllowed] Action<NSError> onFailure);

        // @required -(void)reportError:(NSString * _Nonnull)name exception:(NSException * _Nullable)exception onFailure:(void (^ _Nullable)(NSError * _Nonnull))onFailure;
        [Abstract]
        [Export("reportError:exception:onFailure:")]
        void ReportError(string name, [NullAllowed] NSException exception, [NullAllowed] Action<NSError> onFailure);

        // @required -(void)resumeSession;
        [Abstract]
        [Export("resumeSession")]
        void ResumeSession();

        // @required -(void)pauseSession;
        [Abstract]
        [Export("pauseSession")]
        void PauseSession();
    }

    // @interface YMMYandexMetricaPreloadInfo : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface YMMYandexMetricaPreloadInfo : INSCopying
    {
        // -(instancetype _Nullable)initWithTrackingIdentifier:(NSString * _Nonnull)trackingID;
        [Export("initWithTrackingIdentifier:")]
        IntPtr Constructor(string trackingID);

        // -(void)setAdditionalInfo:(NSString * _Nonnull)info forKey:(NSString * _Nonnull)key;
        [Export("setAdditionalInfo:forKey:")]
        void SetAdditionalInfo(string info, string key);
    }

}
