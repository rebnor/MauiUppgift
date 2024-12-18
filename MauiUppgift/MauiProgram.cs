using CommunityToolkit.Maui;
using MauiUppgift.Services;
using MauiUppgift.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiUppgift
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<DogService>();
            builder.Services.AddSingleton<DogViewModel>();
            builder.Services.AddSingleton<DogPage>();

            builder.Services.AddSingleton<DetailPage>();
            builder.Services.AddSingleton<DetailViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
