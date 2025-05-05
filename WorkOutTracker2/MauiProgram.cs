using Microsoft.Extensions.Logging;
using WorkOutTracker2.ViewModels;

namespace WorkOutTracker2;

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

        //OTAN FTIAXNEIS SELIDA KAI VIEWMODEL TA GRAFEIS EDW OPWS TA ALLA
        builder.Services.AddTransient<WorkoutViewModel>();
        builder.Services.AddTransient<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
