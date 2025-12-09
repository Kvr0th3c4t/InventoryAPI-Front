using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;

namespace InventoryAPI_UI.Services.ProductoService;

public interface IProductoService
{
    Task<PagedResponse<ProductoResponseDto>> GetAllProductosAsync(
        int? pageNumber,
        int? pageSize,
        string? search = null,
        int? categoriaId = null,
        int? proveedorId = null,
        decimal? precioMin = null,
        decimal? precioMax = null,
        bool? stockBajo = null,
        string? orderBy = null,
        string? order = null
    );
    Task<ProductoResponseDto> GetProductoByIdAsync(int id);
    Task<ProductoResponseDto> AddProductoAsync(CreateProductoDto createProductoDto);
    Task<ProductoResponseDto> UpdateProductoAsync(int id, UpdateProductoDto updateProductoDto);
    Task DeleteProductoAsync(int id);
}