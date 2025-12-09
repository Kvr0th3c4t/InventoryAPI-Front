using InventoryAPI_UI.Interfaces.Stats;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using InventoryAPI_UI.Models.StatsModels.MovimientosStatModel;

namespace InventoryAPI_UI.Services.StatsService.MovimientoStatsService;

public class MovimientosStatsService : IMovimientosStatsService
{
    public readonly IMoviminetosStats _api;

    public MovimientosStatsService(IMoviminetosStats api)
    {
        _api = api;
    }
    public async Task<EntradasVsSalidasDto> GetEntradasVsSalidasUltimos30DiasAsync()
    {
        return await _api.GetEntradasVsSalidasUltimos30DiasAsync();
    }

    public async Task<PagedResponse<MovimientoPorDiaDto>> GetMovimientosPorDiaAsync(int? pageNumber, int? pageSize)
    {
        return await _api.GetMovimientosPorDiaAsync(pageNumber: pageNumber ?? 1, pageSize: pageSize ?? 10);
    }

    public async Task<PagedResponse<MovimientoPorProveedorDto>> GetMovimientosPorProveedorAsync(int? pageNumber, int? pageSize)
    {
        return await _api.GetMovimientosPorProveedorAsync(pageNumber: pageNumber ?? 1, pageSize: pageSize ?? 10);
    }

    public async Task<ProductoResponseDto?> GetProductoConMasAjustesAsync()
    {
        return await _api.GetProductoConMasAjustesAsync();
    }

    public async Task<List<ProductoMasMovidoDto>> GetProductosMasMovidosAsync()
    {
        return await _api.GetProductosMasMovidosAsync();
    }

    public async Task<PagedResponse<TipoMovimientoDto>> GetTipoMovimientosAsync(int? pageNumber, int? pageSize)
    {
        return await _api.GetTipoMovimientosAsync(pageNumber: pageNumber ?? 1, pageSize: pageSize ?? 10);
    }

    public async Task<int> GetTotalMovimientosUltimos30DiasAsync()
    {
        return await _api.GetTotalMovimientosUltimos30DiasAsync();
    }
}