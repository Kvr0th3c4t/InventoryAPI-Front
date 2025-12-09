using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProveedorModel;

namespace InventoryAPI_UI.Services.ProveedorService;

public interface IProveedorService
{
    Task<PagedResponse<ProveedorResponseDto>> GetAllProveedoresAsync(int pageNumber, int pageSize);
    Task<ProveedorResponseDto> GetProveedorByIdAsync(int id);
    Task<ProveedorResponseDto> AddProveedorAsync(CreateProveedorDto createProveedorDto);
    Task<ProveedorResponseDto> UpdateProveedorAsync(int id, UpdateProveedorDto updateProveedorDto);
    Task DeleteProveedorAsync(int id);
}