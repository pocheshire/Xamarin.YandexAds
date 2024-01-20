using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Xamarin.YandexAds.iOS
{
    [Native]
    public enum YMAIconResourceType : ulong
    {
        Unknown,
        Static,
        IFrame,
        Html
    }

    [Native]
    public enum YMAIconHorizontalPosition : ulong
    {
        Left,
        Right,
        LeftOffset
    }

    [Native]
    public enum YMAIconVerticalPosition : ulong
    {
        Top,
        Bottom,
        TopOffset
    }

    [Native]
    public enum YMADeviceType : ulong
    {
        None = 0,
        Hardware = 1 << 0,
        Simulator = 1 << 1
    }

    [Native]
    public enum YMADeliveryMethod : ulong
    {
        Unknown,
        Streaming,
        Progressive
    }

    [Native]
    public enum YMAVMAPErrorCode : ulong
    {
        YMAVMAPErrorCodeInvalidXMLResponse
    }

    [Native]
    public enum YMABlockType : ulong
    {
        Unknown,
        Preroll,
        Midroll,
        Postroll,
        Pauseroll,
        Overlayroll
    }

    [Native]
    public enum YMAVASTAdType : ulong
    {
        Unknown,
        InLine,
        Wrapper
    }

    [Native]
    public enum YMAAdErrorCode : ulong
    {
        EmptyBlockID,
        InvalidBannerSize,
        InvalidUUID,
        NoSuchBlockID,
        NoFill,
        BadServerResponse,
        BannerSizeMismatch,
        AdTypeMismatch,
        ServiceTemporarilyNotAvailable,
        InterstitialHasAlreadyBeenPresented,
        InterstitialOrientationMismatch,
        MetricaNotStarted,
        RewardedHasAlreadyBeenPresented
    }

    [Native]
    public enum YMAVASTErrorCode : ulong
    {
        NoAdsInVASTResponse,
        InvalidXMLResponse,
        CannotBuildRequest
    }

    [Native]
    public enum YMANativeErrorCode : ulong
    {
        NoViewForAsset,
        InvalidViewForBinding,
        InvalidBinder,
        AdTypeMismatch
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct YMAHorizontalOffset
    {
        public nfloat left;

        public nfloat right;
    }

    [Native]
    public enum YMASizeConstraintType : ulong
    {
        Fixed,
        FixedBannerRatio,
        PreferredBannerRatio
    }
}
