#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppointmentStoreChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Appointments.AppointmentStoreChangedDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member AppointmentStoreChangedDeferral AppointmentStoreChangedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AppointmentStoreChangedDeferral%20AppointmentStoreChangedEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
