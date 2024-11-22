using Blazored.LocalStorage;
using BlazorWebassembly.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shop.Shared.Configuration;
using Shop.Shared.Services.AuthService;
using Shop.Shared.Services.ProductsService;

namespace BlazorWebassembly.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");



            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddAuthorizationCore();

            //Microsoft.AspNetCore.Components.Authorization
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            //  builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();
            
            var uriBuilder = new UriBuilder(appSettingsSection.BaseApiUrl)
            {
                Path = appSettingsSection.ProductEndpoint.BaseUrl
            };

            builder.Services.Configure<AppSettings>(appSettings); // wstrzykniecie konfiguracji do serwis�w 

            //Microsoft.Extensions.Http
            //builder.Services.AddHttpClient<IProductService, ProductService>
            //    (Client => Client.BaseAddress = uriBuilder.Uri);
            //
            //builder.Services.AddHttpClient<IAuthService,  AuthService>(Client => Client.BaseAddress = uriBuilder.Uri);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = uriBuilder.Uri });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IAuthService, AuthService>();


            await builder.Build().RunAsync();
        }
    }
}
