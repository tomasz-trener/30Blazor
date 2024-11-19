using Shop.Shared;
using Shop.Shared.Auth;

namespace Shop.API.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> LoginAsync(string email, string password);

        Task<ServiceResponse<int>> RegisterAsync(User user, string password);

        Task<ServiceResponse<bool>> ChangePasswordAsync(int userId, string newPassword);

        Task<bool> UserExists(string email);
    }
}
