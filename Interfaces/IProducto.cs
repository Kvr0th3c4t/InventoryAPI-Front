using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using Refit;

namespace InventoryAPI_UI.Interfaces;

public interface IProducto
{
    [Get("/api/productos")]
    Task<PagedResponse<ProductoResponseDto>> GetAllProductosAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10,
        [Query] string? search = null,
        [Query] int? categoriaId = null,
        [Query] int? proveedorId = null,
        [Query] decimal? precioMin = null,
        [Query] decimal? precioMax = null,
        [Query] bool? stockBajo = null,
        [Query] string? orderBy = null,
        [Query] string? order = null
    );

    [Get("/api/productos/{id}")]
    Task<ProductoResponseDto> GetProductoByIdAsync(int id);

    [Post("/api/productos")]
    Task<ProductoResponseDto> CreateProductoAsync([Body] CreateProductoDto createProductoDto);

    [Put("/api/productos/{id}")]
    Task<ProductoResponseDto> UpdateProductoAsync(int id, [Body] UpdateProductoDto updateProductoDto);

    [Delete("/api/productos/{id}")]
    Task DeleteProductoAsync(int id);
}