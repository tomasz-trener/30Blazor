using Microsoft.EntityFrameworkCore;
using Shop.API.Models;
using Shop.Shared;
using Shop.Shared.Auth;

namespace Shop.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        public AuthService(DataContext context)
        {
            _context = context;
        }

        public Task<ServiceResponse<bool>> ChangePasswordAsync(int userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<string>> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<int>> RegisterAsync(User user, string password)
        {
            if (await UserExists(user.Email))
            {
                return new ServiceResponse<int>
                {
                    Success = false,
                    Message = "User already exists."
                };
            }

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int>
            {
                Success = true,
                Data = user.Id,
                Message = "User registered successfully."
            };
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                // generowanie losowej soli 
                passwordSalt = hmac.Key;
                // generowanie hasha 
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string email)
        {
            if(await _context.Users.AnyAsync(x => x.Email.ToLower().Equals(email.ToLower())))
                return true;
            
            return false;
        }
    }
}
