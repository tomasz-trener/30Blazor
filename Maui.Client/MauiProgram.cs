using Microsoft.Extensions.Logging;
using Shop.Shared.Configuration;

namespace Maui.Client
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            ConfigureServices(builder.Services);
            return builder.Build();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var appSettings = ConfigureAppSettings(services);

        }

        private static void ConfigureAppSettings(IServiceCollection services)
        {
            var appSettingsSection = new AppSettings()
            {
                BaseApiUrl = "https://supershopblazor-h6b6agdgbeewdzgm.northeurope-01.azurewebsites.net",
                ProductEndpoint = new ProductEndpoint()
                {
                    BaseUrl = "api/product/",
                    GetProducts = "",
                    CreateProduct = "",
                    UpdateProduct = "",
                }
            };

        }
    }
}
