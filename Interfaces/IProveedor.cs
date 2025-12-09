using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProveedorModel;
using Refit;

namespace InventoryAPI_UI.Interfaces;

public interface IProveedor
{
    [Get("/api/proveedor")]
    Task<PagedResponse<ProveedorResponseDto>> GetAllProveedoresAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/proveedor/{id}")]
    Task<ProveedorResponseDto> GetProveedorByIdAsync(int id);

    [Post("/api/proveedor")]
    Task<ProveedorResponseDto> CreateProveedorAsync([Body] CreateProveedorDto createProveedorDto);

    [Put("/api/proveedor/{id}")]
    Task<ProveedorResponseDto> UpdateProveedorAsync(int id, [Body] UpdateProveedorDto updateProveedorDto);

    [Delete("/api/proveedor/{id}")]
    Task DeleteProveedorAsync(int id);
}
