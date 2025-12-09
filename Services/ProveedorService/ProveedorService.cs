using InventoryAPI_UI.Interfaces;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProveedorModel;

namespace InventoryAPI_UI.Services.ProveedorService;

public class ProveedorService : IProveedorService
{
    private readonly IProveedor _api;

    public ProveedorService(IProveedor api)
    {
        _api = api;
    }

    public async Task<ProveedorResponseDto> AddProveedorAsync(CreateProveedorDto createProveedorDto)
    {
        return await _api.CreateProveedorAsync(createProveedorDto);
    }

    public async Task DeleteProveedorAsync(int id)
    {
        await _api.DeleteProveedorAsync(id);
    }

    public async Task<PagedResponse<ProveedorResponseDto>> GetAllProveedoresAsync(int pageNumber, int pageSize)
    {
        var result = await _api.GetAllProveedoresAsync(pageNumber: pageNumber, pageSize: pageSize);
        return result;
    }

    public async Task<ProveedorResponseDto> GetProveedorByIdAsync(int id)
    {
        return await _api.GetProveedorByIdAsync(id);
    }

    public async Task<ProveedorResponseDto> UpdateProveedorAsync(int id, UpdateProveedorDto updateProveedorDto)
    {
        return await _api.UpdateProveedorAsync(id, updateProveedorDto);
    }
}
