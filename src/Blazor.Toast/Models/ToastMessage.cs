namespace ManuHub.Blazor.Toast;

public class ToastMessage
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Message { get; set; } = string.Empty;
    public ToastLevel Level { get; set; }
    public int Duration { get; set; } = 5000; // in milliseconds   
}
