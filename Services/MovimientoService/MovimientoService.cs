using InventoryAPI_UI.Enums;
using InventoryAPI_UI.Interfaces;
using InventoryAPI_UI.Models.MovimientoModel;
using InventoryAPI_UI.Models.Pagination;

namespace InventoryAPI_UI.Services.MovimientoService;

public class MovimientoService : IMovimientoService
{
    private readonly IMovimiento _api;
    public MovimientoService(IMovimiento api)
    {
        _api = api;
    }

    public async Task<MovimientoResponseDto> AddMovimientoAsync(CreateMovimientoStockDto createMovimientoDto)
    {
        return await _api.CreateMovimientoAsync(createMovimientoDto);
    }

    public async Task<PagedResponse<MovimientoResponseDto>> GetAllMovimientosAsync(DateTimeOffset? fechaDesde, DateTimeOffset? fechaHasta, TipoMovimiento? tipo, int? productoId, string orderBy, string order, int pageNumber, int pageSize)
    {
        var result = await _api.GetAllMovimientoAsync(
            fechaDesde: fechaDesde,
            fechaHasta: fechaHasta,
            tipo: tipo,
            productoId: productoId,
            orderBy: orderBy,
            order: order,
            pageNumber: pageNumber,
            pageSize: pageSize
        );
        return result;
    }

    public async Task<MovimientoResponseDto> GetMovimientoByIdAsync(int id)
    {
        return await _api.GetMovimientoByIdAsync(id);
    }
}

