using Microsoft.Extensions.DependencyInjection;

namespace ManuHub.Blazor.Toast;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorToast(this IServiceCollection services, Action<ToastOptions>? configure = null)
    {
        var options = new ToastOptions();
        configure?.Invoke(options);

        services.AddSingleton(options); // Register options for injection

        services.AddScoped<IToastService>(_ => new ToastService
        {
            MaxToasts = options.MaxToasts,
            Position = options.Position
        });

        return services;
    }
}