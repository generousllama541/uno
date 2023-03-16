#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CoreWebView2HttpHeadersCollectionIterator : global::Windows.Foundation.Collections.IIterator<global::System.Collections.Generic.KeyValuePair<string, string>>
	{
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.KeyValuePair<string, string> Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member KeyValuePair<string, string> CoreWebView2HttpHeadersCollectionIterator.Current is not implemented in Uno.");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool HasCurrent
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2HttpHeadersCollectionIterator.HasCurrent is not implemented in Uno.");
			}
		}
#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator.Current.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator.HasCurrent.get
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool MoveNext()
		{
			throw new global::System.NotImplementedException("The member bool CoreWebView2HttpHeadersCollectionIterator.MoveNext() is not implemented in Uno.");
		}
#endif
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint GetMany(global::System.Collections.Generic.KeyValuePair<string, string>[] items)
		{
			throw new global::System.NotImplementedException("The member uint CoreWebView2HttpHeadersCollectionIterator.GetMany(KeyValuePair<string, string>[] items) is not implemented in Uno.");
		}
#endif
		// Processing: Windows.Foundation.Collections.IIterator<System.Collections.Generic.KeyValuePair<string, string>>
	}
}
