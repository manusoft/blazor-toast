namespace ManuHub.Blazor.Toast;

public class ToastOptions
{
    /// <summary>
    /// Maximum number of toasts shown concurrently. Null means unlimited.
    /// </summary>
    public int? MaxToasts { get; set; } = null;

    /// <summary>
    /// Default toast position.
    /// </summary>
    public ToastPosition Position { get; set; } = ToastPosition.BottomRight;

    /// <summary>
    /// Default toast style.
    /// </summary>
    public ToastStyle ToastStyle { get; set; } = ToastStyle.Default;

    /// <summary>
    /// Gets or sets a value indicating whether the close button is displayed.
    /// </summary>
    public bool ShowCloseButton { get; set; } = true;

    /// <summary>
    /// Automatically includes the CDN for Bootstrap and Tailwind CSS stylesheets and JS.
    /// If you set this to false, you need to include the css and js files yourself for Bootstrap and Tailwind.
    /// </summary>
    public bool IncludeCDN { get; set; } = false;
}
