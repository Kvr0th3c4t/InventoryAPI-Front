using InventoryAPI_UI.Interfaces;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;

namespace InventoryAPI_UI.Services.ProductoService;

public class ProductoService : IProductoService
{
    private readonly IProducto _api;

    public ProductoService(IProducto api)
    {
        _api = api;
    }

    public async Task<PagedResponse<ProductoResponseDto>> GetAllProductosAsync(int? pageNumber = null, int? pageSize = null, string? search = null, int? categoriaId = null, int? proveedorId = null, decimal? precioMin = null, decimal? precioMax = null, bool? stockBajo = null, string? orderBy = null, string? order = null)
    {
        var result = await _api.GetAllProductosAsync(
            pageNumber: pageNumber ?? 1,
            pageSize: pageSize ?? 10,
            search: search,
            categoriaId: categoriaId,
            proveedorId: proveedorId,
            precioMin: precioMin,
            precioMax: precioMax,
            stockBajo: stockBajo,
            orderBy: orderBy,
            order: order
        );
        return result;
    }

    public async Task<ProductoResponseDto> GetProductoByIdAsync(int id)
    {
        return await _api.GetProductoByIdAsync(id);
    }

    public async Task<ProductoResponseDto> AddProductoAsync(CreateProductoDto createProductoDto)
    {
        return await _api.CreateProductoAsync(createProductoDto);
    }

    public async Task<ProductoResponseDto> UpdateProductoAsync(int id, UpdateProductoDto updateProductoDto)
    {
        return await _api.UpdateProductoAsync(id, updateProductoDto);
    }

    public async Task DeleteProductoAsync(int id)
    {
        await _api.DeleteProductoAsync(id);
    }

}