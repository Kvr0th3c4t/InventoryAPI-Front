using InventoryAPI.UI.Models.Auth;
using Refit;

namespace InventoryAPI.UI.Services;

public interface IAuthService
{
    [Post("/api/Auth/login")]
    Task<LoginResponseDto> LoginAsync([Body] LoginDto dto);

    [Post("/api/Auth/register")]
    Task<ApiResponse<object>> RegisterAsync([Body] RegisterDto dto);
}