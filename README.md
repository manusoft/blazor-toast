![Static Badge](https://img.shields.io/badge/ManuHub.Blazor.Toast-red) ![NuGet Version](https://img.shields.io/nuget/v/ManuHub.Blazor.Toast) ![NuGet Downloads](https://img.shields.io/nuget/dt/ManuHub.Blazor.Toast) ![.NET](https://img.shields.io/badge/.NET-8%20%7C%209%20%7C%2010-blueviolet)

# ManuHub.Blazor.Toast

**ManuHub.Blazor.Toast** is a Blazor conponent for displaying multiple toast notifications with **Bootstrap-based styles** and **Tailwind Styles** and **Default** styles with **customizable options** and **positions**.
Without javaScript for default, it provides a simple and elegant way to show notifications in your Blazor applications. Other styles are also available, including **Bootstrap** and **Tailwind CSS**. Automatically includes the required CSS and JS files from CDN, you can set it the configurations in the `Program.cs` file.

## ✨ Features
- ✅ Easy to use
- ✅ Bootstrap 5.3.3 compatible
- ✅ Fully customizable
- ✅ Multiple toast types (Success, Error, Warning, Info)
- ✅ Multiple toast positions (Top, Bottom, Left, Right, Center)
- ✅ Multiple styles (Tailwind, Bootstrap, Default)
- ✅ Animations
- ✅ Hover pause
- ✅ Close buttons
- ✅ Queue + timeouts
- ✅ Per-toast duration & max toasts
- ✅ Compatible with Blazor Server, WebAssembly (WASM), and Hybrid apps

## 🎨 Toast Styles 
- **Bootstrap**: Uses Bootstrap 5.3.3 styles for a modern look.
- **Tailwind**: Uses Tailwind CSS for a clean and minimalistic design.
- **Default**: A simple and classic modern design without any framework dependencies.

## ⚛️ Toast Options
- **ToastStyle**: The style of the toast (Bootstrap, Tailwind, Default).
- **Position**: The position of the toast on the screen (Top, Bottom, Left, Right, Center).
- **MaxToasts**: The maximum number of toasts that can be displayed at once.
- **ShowCloseButton**: Whether to show a close button on the toast.
- **IncludeCDN**: Whether to include Bootstrap/Tailwind CSS and JS from CDN.


## 📦 Installation

Install the NuGet package:
```sh
 dotnet add package ManuHub.Blazor.Toast
```

## 🛠 Setup

### 1️⃣ Register the Service
In `Program.cs`, add the toast service:
```csharp
using ManuHub.Blazor.Toast;

builder.Services.AddBlazorToast();
```

`Toast options` can be configured globally in `Program.cs`:

```csharp
builder.Services.AddBlazorToast(options =>
{
    options.MaxToasts = 5; // Maximum number of toasts to show at once
    options.Position = ToastPosition.TopRight; // Default position for all toasts
    options.ToastStyle = ToastStyle.Bootstrap; // Default style for all toasts 
    options.ShowCloseButton = true; // Show close button on toasts
    options.IncludeCDN = true; // Use CDN for Bootstrap/Tailwind CSS and JS
});
```

### 2 Import the Namespace
In `_Imports.razor`, add:
```razor
@using ManuHub.Blazor.Toast
@inject IToastService ToastService
```

### 3 Add the Toast Component
In `MainLayout.razor`, include the `<ToastHost/>` component:
```razor
<ToastHost />
```

## 🚀 Usage

### ✅ Show Toast in a Component
In `Home.razor`, use the `ToastService` to trigger notifications:

```razor
@page "/"

<PageTitle>Home</PageTitle>

<h1>Hello, world!</h1>

<button class="btn btn-primary" @onclick="ShowToast">Show Toast</button>
<button class="btn btn-danger" @onclick="ShowInfoToast">Show Info Toast</button>
<button class="btn btn-success" @onclick="ShowSuccessToast">Show Success Toast</button>
<button class="btn btn-warning" @onclick="ShowWarningToast">Show Warning Toast</button>
<button class="btn btn-info" @onclick="ShowErrorToast">Show Error Toast</button>>

@code{
    public void ShowToast()
    {
        ToastService.ShowToast("Sample Notification.", ToastLevel.Info, 5000);
    }

    public async Task ShowInfoToast()
    {
        ToastService.Info("Sample Notification."); // Default duration is 5000ms
    }

    public async Task ShowSuccessToast()
    {
        ToastService.Success("Sample Notification.",7000);
    }

    public async Task ShowWarningToast()
    {
        ToastService.Warning("Sample Notification.",4000);
    }

    public async Task ShowErrorToast()
    {
        ToastService.Error("Sample Notification.",6000);
    }
}
```

## 🎨 Customization

### Toast Level
Configure the toast level to change the color and icon of the toast:

```csharp
ToastLevel.Success  // Green Success Toast
ToastLevel.Error    // Red Error Toast
ToastLevel.Warning  // Yellow Warning Toast
ToastLevel.Info     // Blue Info Toast
```

### Toast Positions
Configure the toast position to change where the toast appears on the screen:

```csharp
ToastPosition.BottomLeft    // Bottom Left
ToastPosition.BottomRight   // Bottom Right
ToastPosition.BottomCenter  // Bottom Center
ToastPosition.TopLeft       // Top Left
ToastPosition.TopRight      // Top Right
ToastPosition.TopCenter     // Top Center
```

## 📜 License
[MIT License](LICENSE.txt)

## ✨ Contributions
Feel free to submit issues or pull requests to improve the package!


