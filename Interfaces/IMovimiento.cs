using InventoryAPI_UI.Enums;
using InventoryAPI_UI.Models.MovimientoModel;
using InventoryAPI_UI.Models.Pagination;
using Refit;

namespace InventoryAPI_UI.Interfaces;

public interface IMovimiento
{
    [Get("/api/movimientosStock")]
    Task<PagedResponse<MovimientoResponseDto>> GetAllMovimientoAsync(
        [Query] DateTimeOffset? fechaDesde = null,
        [Query] DateTimeOffset? fechaHasta = null,
        [Query] TipoMovimiento? tipo = null,
        [Query] int? productoId = null,
        [Query] string? orderBy = null,
        [Query] string? order = null,
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10);

    [Post("/api/movimientosStock")]
    Task<MovimientoResponseDto> CreateMovimientoAsync([Body] CreateMovimientoDto createMovimientoDto);

    [Get("/api/movimientosStock/{id}")]
    Task<MovimientoResponseDto> GetMovimientoByIdAsync(int id);

}