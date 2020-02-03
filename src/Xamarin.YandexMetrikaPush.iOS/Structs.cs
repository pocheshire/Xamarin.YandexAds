using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Xamarin.YandexMetrikaPush.iOS
{
	[Native]
	public enum YMPYandexMetricaPushEnvironment : ulong
	{
		Production,
		Development
	}
}

