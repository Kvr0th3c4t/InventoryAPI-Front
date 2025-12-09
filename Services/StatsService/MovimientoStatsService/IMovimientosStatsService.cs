using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using InventoryAPI_UI.Models.StatsModels.MovimientosStatModel;

namespace InventoryAPI_UI.Services.StatsService.MovimientoStatsService;

public interface IMovimientosStatsService
{
    Task<int> GetTotalMovimientosUltimos30DiasAsync();

    Task<EntradasVsSalidasDto> GetEntradasVsSalidasUltimos30DiasAsync();

    Task<PagedResponse<MovimientoPorDiaDto>> GetMovimientosPorDiaAsync(
        int? pageNumber,
        int? pageSize
    );

    Task<List<ProductoMasMovidoDto>> GetProductosMasMovidosAsync();

    Task<PagedResponse<TipoMovimientoDto>> GetTipoMovimientosAsync(
       int? pageNumber,
       int? pageSize
    );

    Task<PagedResponse<MovimientoPorProveedorDto>> GetMovimientosPorProveedorAsync(
       int? pageNumber,
       int? pageSize
    );
    Task<ProductoResponseDto?> GetProductoConMasAjustesAsync();
}