using E_Commerce_Models;

namespace E_Commerce_Client.Service.IService
{
    public interface IAuthenticationService
    {
        public Task<RegisterResponseDTO> RegisterUser(RegisterRequestDTO requestDTO);
        public Task<LoginResponseDTO> LoginUser(LoginRequestDTO requestDTO);
        Task Logout();
    }
}
