# Extensions for .NET iOS
![GitHub](https://img.shields.io/github/license/fedandburk/net-ios-extensions.svg)
![Nuget](https://img.shields.io/nuget/v/Fedandburk.iOS.Extensions.svg)
[![CI](https://github.com/fedandburk/net-ios-extensions/actions/workflows/ci.yml/badge.svg)](https://github.com/fedandburk/net-ios-extensions/actions/workflows/ci.yml)
[![CD](https://github.com/fedandburk/net-ios-extensions/actions/workflows/cd.yml/badge.svg)](https://github.com/fedandburk/net-ios-extensions/actions/workflows/cd.yml)
[![CodeFactor](https://www.codefactor.io/repository/github/fedandburk/net-ios-extensions/badge)](https://www.codefactor.io/repository/github/fedandburk/net-ios-extensions)

Extensions is a .NET library with common iOS extensions and helpers.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package Fedandburk.iOS.Extensions
```

## Usage
```cs
using Fedandburk.iOS.Extensions;
```

### Generic UITableViewSource
To easily bind items collection or a collection of collections, e.g. groups, the `TableViewSource` class can be used.

`TableViewSource` also supports:
- Live collections (including groups), e.g. collections that implement `INotifyCollectionChanged` interface
- Row animations customisation
- Animated row expanding
- Rows editing and removing
- Rows moving
- Rows selection with automatic deselection
- Accessory buttons handling
- Custom section footers and headers

```cs
@object.InvokeOnMainThreadIfNeeded(action); 
```

### NSObject Extensions
To perform an `Action` on the main UI thread with the current thread check:

```cs
@object.InvokeOnMainThreadIfNeeded(action); 
```

### UIApplication Extensions
To get the topmost presented `UIViewController`:

```cs
var topViewController = UIApplication.SharedApplication.GetTopViewController(); 
```

### UIColor Extensions
To convert a `UIColor` into a hexadecimal color:

```cs
var hex = UIColor.Red.ToHexColor();
```

To convert a `UIColor` into a `Color` color:

```cs
var hex = UIColor.Red.ToColor();
```

### Color Extensions
To convert a `Color` into a `UIColor` color:

```cs
var hex = Color.Red.ToColor();
```
