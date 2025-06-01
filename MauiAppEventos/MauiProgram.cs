using MauiAppEventos;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Eventos;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
            });

        return builder.Build();
    }
}
