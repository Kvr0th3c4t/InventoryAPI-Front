using InventoryAPI_UI.Models.CategoriaModel;
using InventoryAPI_UI.Models.Pagination;

namespace InventoryAPI_UI.Services.CategoriaService;

public interface ICategoriaService
{
    Task<PagedResponse<CategoriaResponseDto>> GetAllCategoriasAsync(
        int pageNumber,
        int pageSize
    );
    Task<CategoriaResponseDto> GetCategoriaByIdAsync(int id);
    Task<CategoriaResponseDto> AddCategoriaAsync(CreateCategoriaDto createCategoriaDto);
    Task<CategoriaResponseDto> UpdateCategoriaAsync(int id, UpdateCategoriaDto updateCategoriaDto);
    Task DeleteCategoriaAsync(int id);
}