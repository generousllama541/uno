#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxAction 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong ChangeNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong EmailMailboxAction.ChangeNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ulong%20EmailMailboxAction.ChangeNumber");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailMailboxActionKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxActionKind EmailMailboxAction.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=EmailMailboxActionKind%20EmailMailboxAction.Kind");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxAction.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxAction.ChangeNumber.get
	}
}
