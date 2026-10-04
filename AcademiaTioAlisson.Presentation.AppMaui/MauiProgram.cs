// Alisson Assis
using AcademiaTioAlisson.Presentation.AppMaui.Configuration;
using AcademiaTioAlisson.Presentation.AppMaui.ViewModels;
using AcademiaTioAlisson.Presentation.AppMaui.Views;
using Microsoft.Extensions.Logging;

namespace AcademiaTioAlisson.Presentation.AppMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Configuração dos repositórios e serviços
        ConfigurationHelper.ConfigureServices(builder.Services);

        // Registo de ViewModels
        builder.Services.AddTransient<DashboardListViewModel>();
        builder.Services.AddTransient<LogradouroListViewModel>();
        builder.Services.AddTransient<LogradouroViewModel>();

        // Registo de Views
        builder.Services.AddTransient<DashboardListPage>();
        builder.Services.AddTransient<LogradouroListPage>();
        builder.Services.AddTransient<LogradouroPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}