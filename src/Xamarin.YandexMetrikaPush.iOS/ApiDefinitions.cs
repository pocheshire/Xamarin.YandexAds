
using Foundation;
using ObjCRuntime;
using UserNotifications;

namespace Xamarin.YandexMetrikaPush.iOS
{
    // @protocol YMPUserNotificationCenterDelegate <UNUserNotificationCenterDelegate>
//    [iOS(10, 0)]
    [Protocol, Model]
    interface YMPUserNotificationCenterDelegate : IUNUserNotificationCenterDelegate
    {
        // @required @property (assign, nonatomic) UNNotificationPresentationOptions presentationOptions;
        [Abstract]
        [Export("presentationOptions", ArgumentSemantic.Assign)]
        UNNotificationPresentationOptions PresentationOptions { get; set; }

        [Wrap("WeakNextDelegate"), Abstract]
        [NullAllowed]
        UNUserNotificationCenterDelegate NextDelegate { get; set; }

        // @required @property (nonatomic, weak) id<UNUserNotificationCenterDelegate> _Nullable nextDelegate;
        [Abstract]
        [NullAllowed, Export("nextDelegate", ArgumentSemantic.Weak)]
        NSObject WeakNextDelegate { get; set; }
    }

    interface IYMPUserNotificationCenterDelegate {}

    // @protocol YMPUserNotificationCenterHandling <NSObject>
//    [iOS(10, 0)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface YMPUserNotificationCenterHandling
    {
        // @required -(void)userNotificationCenterWillPresentNotification:(UNNotification * _Nonnull)notification;
        [Abstract]
        [Export("userNotificationCenterWillPresentNotification:")]
        void UserNotificationCenterWillPresentNotification(UNNotification notification);

        // @required -(void)userNotificationCenterDidReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response;
        [Abstract]
        [Export("userNotificationCenterDidReceiveNotificationResponse:")]
        void UserNotificationCenterDidReceiveNotificationResponse(UNNotificationResponse response);

        // @required -(void)userNotificationCenterOpenSettingsForNotification:(UNNotification * _Nullable)notification __attribute__((availability(ios, introduced=12.0)));
//        [iOS(12, 0)]
        [Abstract]
        [Export("userNotificationCenterOpenSettingsForNotification:")]
        void UserNotificationCenterOpenSettingsForNotification([NullAllowed] UNNotification notification);
    }

    // @interface YMPYandexMetricaPush : NSObject
    [BaseType(typeof(NSObject))]
    interface YMPYandexMetricaPush
    {
        // +(id<YMPUserNotificationCenterDelegate> _Nonnull)userNotificationCenterDelegate __attribute__((availability(ios, introduced=10.0)));
//        [iOS(10, 0)]
        [Static]
        [Export("userNotificationCenterDelegate")]
        IYMPUserNotificationCenterDelegate UserNotificationCenterDelegate { get; }

        // +(id<YMPUserNotificationCenterHandling> _Nonnull)userNotificationCenterHandler __attribute__((availability(ios, introduced=10.0)));
//        [iOS(10, 0)]
        [Static]
        [Export("userNotificationCenterHandler")]
        YMPUserNotificationCenterHandling UserNotificationCenterHandler { get; }

        // +(void)handleDidReceiveNotificationRequest:(UNNotificationRequest * _Nonnull)request __attribute__((availability(ios, introduced=10.0)));
//        [iOS(10, 0)]
        [Static]
        [Export("handleDidReceiveNotificationRequest:")]
        void HandleDidReceiveNotificationRequest(UNNotificationRequest request);

        // +(void)setDeviceTokenFromData:(NSData * _Nullable)data;
        [Static]
        [Export("setDeviceTokenFromData:")]
        void SetDeviceTokenFromData([NullAllowed] NSData data);

        // +(void)setDeviceTokenFromData:(NSData * _Nullable)data pushEnvironment:(YMPYandexMetricaPushEnvironment)pushEnvironment;
        [Static]
        [Export("setDeviceTokenFromData:pushEnvironment:")]
        void SetDeviceTokenFromData([NullAllowed] NSData data, YMPYandexMetricaPushEnvironment pushEnvironment);

        // +(void)handleApplicationDidFinishLaunchingWithOptions:(NSDictionary * _Nullable)launchOptions;
        [Static]
        [Export("handleApplicationDidFinishLaunchingWithOptions:")]
        void HandleApplicationDidFinishLaunchingWithOptions([NullAllowed] NSDictionary launchOptions);

        // +(void)handleRemoteNotification:(NSDictionary * _Nonnull)userInfo;
        [Static]
        [Export("handleRemoteNotification:")]
        void HandleRemoteNotification(NSDictionary userInfo);

        // +(NSString * _Nullable)userDataForNotification:(NSDictionary * _Nonnull)userInfo;
        [Static]
        [Export("userDataForNotification:")]
        [return: NullAllowed]
        string UserDataForNotification(NSDictionary userInfo);

        // +(BOOL)isNotificationRelatedToSDK:(NSDictionary * _Nonnull)userInfo;
        [Static]
        [Export("isNotificationRelatedToSDK:")]
        bool IsNotificationRelatedToSDK(NSDictionary userInfo);

        // +(void)setExtensionAppGroup:(NSString * _Nonnull)appGroup;
        [Static]
        [Export("setExtensionAppGroup:")]
        void SetExtensionAppGroup(string appGroup);
    }
}

