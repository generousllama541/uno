﻿using System;
using System.Collections.Generic;
using Uno.Disposables;
using Uno.UI.Extensions;
using Uno.UI.Xaml.Core;
using Windows.Foundation;
using Windows.System;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls;

[ContentProperty(Name = nameof(Items))]
public partial class MenuFlyoutSubItem : MenuFlyoutItemBase, ISubMenuOwner
{
}
