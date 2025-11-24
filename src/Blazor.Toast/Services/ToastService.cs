namespace ManuHub.Blazor.Toast;

public class ToastService : IToastService
{
    public event Action<ToastMessage>? OnShow;
    public ToastPosition Position { get; set; } = ToastPosition.BottomRight;
    public int? MaxToasts { get; set; } = null;

    private readonly Queue<ToastMessage> _toastQueue = new();

    public void ShowToast(string message, ToastLevel level, int duration = 5000)
    {
        var toast = new ToastMessage
        {
            Id = Guid.NewGuid(), // Ensure a unique ID for each toast
            Message = message,
            Level = level,
            Duration = duration
        };

        // Only add to the queue if we haven't exceeded the max count
        if (MaxToasts.HasValue && _toastQueue.Count >= MaxToasts.Value)
        {
            _toastQueue.Dequeue(); // Remove the oldest toast to make room for a new one
        }

        _toastQueue.Enqueue(toast);
        TryDispatchNext();
    }

    public void TryDispatchNext()
    {
        OnShow?.Invoke(new ToastMessage { Id= Guid.Empty }); // dummy call to trigger UI state update
    }

    public bool TryDequeue(out ToastMessage? toast)
    {
        if (_toastQueue.Count > 0)
        {
            toast = _toastQueue.Dequeue();
            return true;
        }

        toast = null;
        return false;
    }

    public void Info(string message, int duration = 5000) => ShowToast(message, ToastLevel.Info, duration);
    public void Success(string message, int duration = 5000) => ShowToast(message, ToastLevel.Success, duration);
    public void Warning(string message, int duration = 5000) => ShowToast(message, ToastLevel.Warning, duration);
    public void Error(string message, int duration = 5000) => ShowToast(message, ToastLevel.Error, duration);
}
