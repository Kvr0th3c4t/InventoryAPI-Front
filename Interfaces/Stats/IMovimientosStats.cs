using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using InventoryAPI_UI.Models.StatsModels.MovimientosStatModel;
using Refit;

namespace InventoryAPI_UI.Interfaces.Stats;

public interface IMoviminetosStats
{
    [Get("/api/movimientoStockStat/total-movimientos-ultimos-30-dias")]
    Task<int> GetTotalMovimientosUltimos30DiasAsync();

    [Get("/api/movimientoStockStat/entradas-vs-salidas-ultimos-30-dias")]
    Task<EntradasVsSalidasDto> GetEntradasVsSalidasUltimos30DiasAsync();

    [Get("/api/movimientoStockStat/movimientos-por-dia")]
    Task<PagedResponse<MovimientoPorDiaDto>> GetMovimientosPorDiaAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/movimientoStockStat/productos-mas-movidos")]
    Task<List<ProductoMasMovidoDto>> GetProductosMasMovidosAsync();

    [Get("/api/movimientoStockStat/tipo-movimientos")]
    Task<PagedResponse<TipoMovimientoDto>> GetTipoMovimientosAsync(
       [Query] int pageNumber = 1,
       [Query] int pageSize = 10
    );


    [Get("/api/movimientoStockStat/movimientos-por-proveedor")]
    Task<PagedResponse<MovimientoPorProveedorDto>> GetMovimientosPorProveedorAsync(
       [Query] int pageNumber = 1,
       [Query] int pageSize = 10
    );

    [Get("/api/movimientoStockStat/producto-con-mas-ajustes")]
    Task<ProductoResponseDto?> GetProductoConMasAjustesAsync();

}