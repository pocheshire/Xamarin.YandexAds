using ObjCRuntime;

namespace Xamarin.YandexMetrika.iOS
{
    [Native]
    public enum YMMYandexMetricaEventErrorCode : long
    {
        InitializationError = 1000,
        InvalidName = 1001,
        JsonSerializationError = 1002,
        InvalidRevenueInfo = 1003,
        EmptyUserProfile = 1004,
        NoCrashLibrary = 1005
    }

    [Native]
    public enum YMMGenderType : ulong
    {
        Male,
        Female,
        Other
    }
}
