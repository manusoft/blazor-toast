namespace ManuHub.Blazor.Toast;

public interface IToastService
{
    event Action<ToastMessage> OnShow;
    ToastPosition Position { get; set; }
    int? MaxToasts { get; set; }
    void ShowToast(string message, ToastLevel level, int duration = 5000);
    void Info(string message, int duration = 5000);
    void Success(string message, int duration = 5000);
    void Warning(string message, int duration = 5000);
    void Error(string message, int duration = 5000);

    bool TryDequeue(out ToastMessage? toast);
    void TryDispatchNext();
}


