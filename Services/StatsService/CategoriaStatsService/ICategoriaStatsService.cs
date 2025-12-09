using InventoryAPI_UI.Models.CategoriaModel;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;

namespace InventoryAPI_UI.Services.StatsService.CategoriaStatsService;

public interface ICategoriaStatsService
{
    Task<int> GetTotalCategoriasAsync();
    Task<PagedResponse<DistribucionCategoriaDto>> GetDistribucionProductosPorCategoriaAsync(
        int? pageNumber,
        int? pageSize
    );
    Task<CategoriaResponseDto> GetCategoriaConMasProductosAsync();
    Task<CategoriaResponseDto> GetCategoriaConMayorValorAsync();
}