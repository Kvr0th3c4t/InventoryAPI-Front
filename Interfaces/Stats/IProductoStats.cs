using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;
using Refit;

namespace InventoryAPI_UI.Interfaces.Stats;

public interface IProductoStats
{
    [Get("/api/productoStat/total-productos")]
    Task<int> GetTotalProductos();

    [Get("/api/productoStat/productos-stock-bajo")]
    Task<int> GetProductosBajoStock();

    [Get("/api/productoStat/productos-sin-stock")]
    Task<int> GetProductosSinStock();

    [Get("/api/productoStat/valor-total-inventario")]
    Task<decimal> GetTotalValorInventario();

    [Get("/api/productoStat/precio-promedio")]
    Task<decimal> GetPrecioPromedio();

    [Get("/api/productoStat/precio-mas-alto")]
    Task<decimal> GetPrecioMasAlto();

    [Get("/api/productoStat/precio-mas-bajo")]
    Task<decimal> GetPrecioMasBajo();

    [Get("/api/productoStat/productos-ultimos-30-dias")]
    Task<int> GetProductosUltimos30Ddias();

    [Get("/api/productoStat/distribucion-por-categoria")]
    Task<PagedResponse<DistribucionCategoriaDto>> GetDistribucionPorCategoria(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/productoStat/distribucion-por-proveedor")]
    Task<PagedResponse<DistribucionProveedorDto>> GetDistribucionPorProveedor(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/productoStat/top5-productos-mas-valiosos")]
    Task<List<ProductoResponseDto>> GetTop5ProductosMasValiosos();

    [Get("/api/productoStat/top5-productos-mas-stock")]
    Task<List<ProductoResponseDto>> GetTop5ProductosMasStock();

    [Get("/api/productoStat/top5-productos-menos-stock")]
    Task<List<ProductoResponseDto>> GetTop5ProductosMenorStock();

}