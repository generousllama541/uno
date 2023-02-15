#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.UserProfile
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AssignedAccessSettings 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AssignedAccessSettings.IsEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AssignedAccessSettings.IsEnabled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsSingleAppKioskMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AssignedAccessSettings.IsSingleAppKioskMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AssignedAccessSettings.IsSingleAppKioskMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User AssignedAccessSettings.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20AssignedAccessSettings.User");
			}
		}
		#endif
		// Forced skipping of method Windows.System.UserProfile.AssignedAccessSettings.IsEnabled.get
		// Forced skipping of method Windows.System.UserProfile.AssignedAccessSettings.IsSingleAppKioskMode.get
		// Forced skipping of method Windows.System.UserProfile.AssignedAccessSettings.User.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.UserProfile.AssignedAccessSettings GetDefault()
		{
			throw new global::System.NotImplementedException("The member AssignedAccessSettings AssignedAccessSettings.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AssignedAccessSettings%20AssignedAccessSettings.GetDefault%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.UserProfile.AssignedAccessSettings GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member AssignedAccessSettings AssignedAccessSettings.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AssignedAccessSettings%20AssignedAccessSettings.GetForUser%28User%20user%29");
		}
		#endif
	}
}
