using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Drawing;
using System.Security.Claims;
using System.Text.Json;

namespace BlazorWebassembly.Client.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        ILocalStorageService _localStorageService;
        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string authToken = await _localStorageService.GetItemAsync<string>("authToken");

            var identity = new ClaimsIdentity();
            if (!string.IsNullOrEmpty(authToken))
            {
                try
                {
                    //parsowanie tokenu 
                    identity = new ClaimsIdentity(ParseClaimsFromJwt(authToken), "jwt");
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private IEnumerable<Claim>? ParseClaimsFromJWT(string authToken)
        {
            var payload = authToken.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            var claims = keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string payload)
        {
            switch (payload.Length % 4)
            {
                case 2: payload += "=="; break;
                case 3: payload += "="; break;
            }
            return Convert.FromBase64String(payload);
        }
    }
}
