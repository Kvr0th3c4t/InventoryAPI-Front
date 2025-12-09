using InventoryAPI_UI.Enums;
using InventoryAPI_UI.Interfaces;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.MovimientoModel;

namespace InventoryAPI_UI.Services.MovimientoService;

public interface IMovimientoService
{
    Task<PagedResponse<MovimientoResponseDto>> GetAllMovimientosAsync(DateTimeOffset? fechaDesde, DateTimeOffset? fechaHasta, TipoMovimiento? tipo, int? productoId, string orderBy, string order, int pageNumber, int pageSize);
    Task<MovimientoResponseDto> GetMovimientoByIdAsync(int id);
    Task<MovimientoResponseDto> AddMovimientoAsync(CreateMovimientoStockDto createMovimientoDto);
}

