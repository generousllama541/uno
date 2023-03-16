#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CoreWebView2WebResourceResponse
	{
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int StatusCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CoreWebView2WebResourceResponse.StatusCode is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse", "int CoreWebView2WebResourceResponse.StatusCode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ReasonPhrase
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2WebResourceResponse.ReasonPhrase is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse", "string CoreWebView2WebResourceResponse.ReasonPhrase");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IRandomAccessStream Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStream CoreWebView2WebResourceResponse.Content is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse", "IRandomAccessStream CoreWebView2WebResourceResponse.Content");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders Headers
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2HttpResponseHeaders CoreWebView2WebResourceResponse.Headers is not implemented in Uno.");
			}
		}
#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.Content.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.Content.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.Headers.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.StatusCode.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.StatusCode.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.ReasonPhrase.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse.ReasonPhrase.set
	}
}
