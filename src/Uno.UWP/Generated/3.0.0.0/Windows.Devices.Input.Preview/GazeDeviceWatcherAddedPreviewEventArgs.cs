#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input.Preview
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GazeDeviceWatcherAddedPreviewEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Input.Preview.GazeDevicePreview Device
		{
			get
			{
				throw new global::System.NotImplementedException("The member GazeDevicePreview GazeDeviceWatcherAddedPreviewEventArgs.Device is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=GazeDevicePreview%20GazeDeviceWatcherAddedPreviewEventArgs.Device");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.Preview.GazeDeviceWatcherAddedPreviewEventArgs.Device.get
	}
}
