#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlBinaryWriter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.Markup.XamlBinaryWriterErrorInformation Write( global::System.Collections.Generic.IList<global::Windows.Storage.Streams.IRandomAccessStream> inputStreams,  global::System.Collections.Generic.IList<global::Windows.Storage.Streams.IRandomAccessStream> outputStreams,  global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xamlMetadataProvider)
		{
			throw new global::System.NotImplementedException("The member XamlBinaryWriterErrorInformation XamlBinaryWriter.Write(IList<IRandomAccessStream> inputStreams, IList<IRandomAccessStream> outputStreams, IXamlMetadataProvider xamlMetadataProvider) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=XamlBinaryWriterErrorInformation%20XamlBinaryWriter.Write%28IList%3CIRandomAccessStream%3E%20inputStreams%2C%20IList%3CIRandomAccessStream%3E%20outputStreams%2C%20IXamlMetadataProvider%20xamlMetadataProvider%29");
		}
		#endif
	}
}
