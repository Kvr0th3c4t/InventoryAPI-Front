using InventoryAPI_UI.Interfaces;
using InventoryAPI_UI.Models.CategoriaModel;
using InventoryAPI_UI.Models.Pagination;

namespace InventoryAPI_UI.Services.CategoriaService;

public class CategoriaService : ICategoriaService
{
    private readonly ICategoria _api;

    public CategoriaService(ICategoria api)
    {
        _api = api;
    }

    public async Task<CategoriaResponseDto> AddCategoriaAsync(CreateCategoriaDto createCategoriaDto)
    {
        return await _api.CreateCategoriaAsync(createCategoriaDto);
    }

    public async Task DeleteCategoriaAsync(int id)
    {
        await _api.DeleteCategoriaAsync(id);
    }

    public async Task<PagedResponse<CategoriaResponseDto>> GetAllCategoriasAsync(int pageNumber,
        int pageSize)
    {
        var result = await _api.GetAllCategoriasAsync(pageNumber: pageNumber,
        pageSize: pageSize);
        return result;
    }

    public async Task<CategoriaResponseDto> GetCategoriaByIdAsync(int id)
    {
        return await _api.GetCategoriaByIdAsync(id);
    }

    public async Task<CategoriaResponseDto> UpdateCategoriaAsync(int id, UpdateCategoriaDto updateCategoriaDto)
    {
        return await _api.UpdateCategoriaAsync(id, updateCategoriaDto);
    }
}