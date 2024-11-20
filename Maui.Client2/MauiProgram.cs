
using Maui.Client.ViewModels;
using Microsoft.Extensions.Logging;
using Shop.Shared.Configuration;
using Shop.Shared.Services.ProductsService;

namespace Maui.Client2
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
            ConfigureAppServices(services, appSettings);
            ConfigureHttpClients(services, appSettings);
            ConfigureViewModels(services);
            ConfigureViews(services);
        }

        private static void ConfigureAppServices(IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton<IProductService, ProductService>();
        }

        private static void ConfigureViews(IServiceCollection services)
        {
            services.AddSingleton<MainPage>();
        }

        private static void ConfigureViewModels(IServiceCollection services)
        {
            services.AddSingleton<ProductViewModel>();
        }

        private static void ConfigureHttpClients(IServiceCollection services, AppSettings appSettings)
        {
            var uriBuilder = new UriBuilder(appSettings.BaseApiUrl)
            {
                Path = appSettings.ProductEndpoint.BaseUrl
            };

            services.AddHttpClient<IProductService, ProductService>(client => client.BaseAddress = uriBuilder.Uri);
        }



        private static AppSettings ConfigureAppSettings(IServiceCollection services)
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
            services.Configure<AppSettings>(options =>
            {
                options.BaseApiUrl = appSettingsSection.BaseApiUrl;
                options.ProductEndpoint = appSettingsSection.ProductEndpoint;
            });

            return appSettingsSection;


        }
    }
}
