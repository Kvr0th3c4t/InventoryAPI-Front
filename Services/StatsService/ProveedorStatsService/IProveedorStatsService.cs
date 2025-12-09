using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProveedorModel;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;
using InventoryAPI_UI.Models.StatsModels.ProveedoresStatsDto;

namespace InventoryAPI_UI.Services.StatsService.ProveedorStatsService;

public interface IProveedorStatsService
{
    Task<int> GetTotalProveedoresAsync();

    Task<PagedResponse<DistribucionProveedorDto>> GetProductosPorProveedorAsync(
        int? pageNumber,
        int? pageSize
        );

    Task<ProveedorResponseDto?> GetProveedorMasActivoAsync();

    Task<PagedResponse<DistribucionValorProveedorDto>> GetValorInventarioPorProveedorAsync(
        int? pageNumber,
        int? pageSize
        );
}