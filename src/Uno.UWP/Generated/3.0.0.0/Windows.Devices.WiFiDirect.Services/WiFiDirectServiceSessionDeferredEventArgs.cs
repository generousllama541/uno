#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect.Services
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiDirectServiceSessionDeferredEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer DeferredSessionInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer WiFiDirectServiceSessionDeferredEventArgs.DeferredSessionInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IBuffer%20WiFiDirectServiceSessionDeferredEventArgs.DeferredSessionInfo");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs.DeferredSessionInfo.get
	}
}
