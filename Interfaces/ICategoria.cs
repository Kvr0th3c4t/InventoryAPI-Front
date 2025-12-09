using InventoryAPI_UI.Models.CategoriaModel;
using InventoryAPI_UI.Models.Pagination;
using Refit;

namespace InventoryAPI_UI.Interfaces;

public interface ICategoria
{
    [Get("/api/categoria")]
    Task<PagedResponse<CategoriaResponseDto>> GetAllCategoriasAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/categoria/{id}")]
    Task<CategoriaResponseDto> GetCategoriaByIdAsync(int id);

    [Post("/api/categoria")]
    Task<CategoriaResponseDto> CreateCategoriaAsync([Body] CreateCategoriaDto createCategoriaDto);

    [Put("/api/categoria/{id}")]
    Task<CategoriaResponseDto> UpdateCategoriaAsync(int id, [Body] UpdateCategoriaDto updateCategoriaDto);

    [Delete("/api/categoria/{id}")]
    Task DeleteCategoriaAsync(int id);
}