using CarListingMAUI.APP.Services;
using CarListingMAUI.APP.ViewModels;

namespace CarListingMAUI.APP
{
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

            #region Ioc

            builder.Services.AddSingleton<ShowCarListViewModel>();
            builder.Services.AddSingleton<CarService>();
            builder.Services.AddSingleton<MainPage>();
            

            #endregion
            return builder.Build();
        }
    }
}