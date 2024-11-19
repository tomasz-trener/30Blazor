using Shop.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<bool>> ChangePassword(string newPassword)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/changePassword", newPassword);
            var content = await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return content;
        }

        public async Task<ServiceResponse<string>> Login(UserLoginDto userLoginDto)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/login", userLoginDto);
            var content =  await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
            return content;
        }

        public async Task<ServiceResponse<int>> Register(UserRegisterDto userRegisterDto)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/register", userRegisterDto);
            var content = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            return content;
        }
    }
}
