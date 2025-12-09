using InventoryAPI_UI.Interfaces.Stats;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;

namespace InventoryAPI_UI.Services.StatsService.ProductoStatsService;

public class ProductoStatsService : IProductoStatsService
{
    private readonly IProductoStats _api;

    public ProductoStatsService(IProductoStats api)
    {
        _api = api;
    }

    public async Task<PagedResponse<DistribucionCategoriaDto>> GetDistribucionPorCategoria(int? pageNumber, int? pageSize = 10)
    {
        return await _api.GetDistribucionPorCategoria(
            pageNumber: pageNumber ?? 1,
            pageSize: pageSize ?? 10);
    }

    public async Task<PagedResponse<DistribucionProveedorDto>> GetDistribucionPorProveedor(int? pageNumber, int? pageSize)
    {
        return await _api.GetDistribucionPorProveedor(
            pageNumber: pageNumber ?? 1,
            pageSize: pageSize ?? 10);
    }

    public async Task<decimal> GetPrecioMasAlto()
    {
        return await _api.GetPrecioMasAlto();
    }

    public async Task<decimal> GetPrecioMasBajo()
    {
        return await _api.GetPrecioMasBajo();
    }

    public async Task<decimal> GetPrecioPromedio()
    {
        return await _api.GetPrecioPromedio();
    }

    public async Task<int> GetProductosBajoStock()
    {
        return await _api.GetProductosBajoStock();
    }

    public async Task<int> GetProductosSinStock()
    {
        return await _api.GetProductosSinStock();
    }

    public async Task<int> GetProductosUltimos30Ddias()
    {
        return await _api.GetProductosUltimos30Ddias();
    }

    public async Task<List<ProductoResponseDto>> GetTop5ProductosMasStock()
    {
        return await _api.GetTop5ProductosMasStock();
    }

    public async Task<List<ProductoResponseDto>> GetTop5ProductosMasValiosos()
    {
        return await _api.GetTop5ProductosMasValiosos();
    }

    public async Task<List<ProductoResponseDto>> GetTop5ProductosMenorStock()
    {
        return await _api.GetTop5ProductosMenorStock();
    }

    public async Task<int> GetTotalProductos()
    {
        return await _api.GetTotalProductos();
    }

    public async Task<decimal> GetTotalValorInventario()
    {
        return await _api.GetTotalValorInventario();
    }
}