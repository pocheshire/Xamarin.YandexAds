using System;

namespace Xamarin.YandexAds.iOS
{
    public enum YMAAdErrorCode : uint
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
        MetricaNotStarted
    }

    
    public enum YMANativeErrorCode : uint
    {
        NoViewForAsset,
        InvalidViewForBinding,
        InvalidBinder,
        AdTypeMismatch
    }

    //[StructLayout (LayoutKind.Sequential)]
    public struct YMAHorizontalOffset
    {
        public nfloat left;

        public nfloat right;
    }

    
    public enum YMASizeConstraintType : int
    {
        Fixed,
        FixedBannerRatio,
        PreferredBannerRatio
    }

    
    public enum YMABlockType : uint
    {
        Unknown,
        Preroll,
        Midroll,
        Postroll,
        Pauseroll,
        Overlayroll
    }

    
    public enum YMAVASTAdType : uint
    {
        Unknown,
        InLine,
        Wrapper
    }

    
    public enum YMADeliveryMethod : uint
    {
        Unknown,
        Streaming,
        Progressive
    }

    
    public enum YMAVASTErrorCode : uint
    {
        NoAdsInVASTResponse,
        InvalidXMLResponse,
        CannotBuildRequest
    }

    
    public enum YMAIconResourceType : uint
    {
        Unknown,
        Static,
        IFrame,
        Html
    }

    
    public enum YMAIconHorizontalPosition : uint
    {
        Left,
        Right,
        LeftOffset
    }

    
    public enum YMAIconVerticalPosition : uint
    {
        Top,
        Bottom,
        TopOffset
    }
}
