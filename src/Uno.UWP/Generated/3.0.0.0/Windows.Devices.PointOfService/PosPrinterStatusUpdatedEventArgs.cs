#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PosPrinterStatusUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.PointOfService.PosPrinterStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member PosPrinterStatus PosPrinterStatusUpdatedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PosPrinterStatus%20PosPrinterStatusUpdatedEventArgs.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.PosPrinterStatusUpdatedEventArgs.Status.get
	}
}
