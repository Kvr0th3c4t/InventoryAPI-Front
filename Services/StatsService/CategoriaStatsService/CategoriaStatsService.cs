using InventoryAPI_UI.Interfaces.Stats;
using InventoryAPI_UI.Models.CategoriaModel;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;

namespace InventoryAPI_UI.Services.StatsService.CategoriaStatsService;

public class CategoriaStatsService : ICategoriaStatsService
{
    private readonly ICategoriaStats _api;

    public CategoriaStatsService(ICategoriaStats api)
    {
        _api = api;
    }

    public async Task<CategoriaResponseDto> GetCategoriaConMasProductosAsync()
    {
        return await _api.GetCategoriaConMasProductosAsync();
    }

    public async Task<CategoriaResponseDto> GetCategoriaConMayorValorAsync()
    {
        return await _api.GetCategoriaConMayorValorAsync();
    }

    public async Task<PagedResponse<DistribucionCategoriaDto>> GetDistribucionProductosPorCategoriaAsync(int? pageNumber, int? pageSize)
    {
        return await _api.GetDistribucionProductosPorCategoriaAsync(pageNumber: pageNumber ?? 1, pageSize: pageSize ?? 10);
    }

    public async Task<int> GetTotalCategoriasAsync()
    {
        return await _api.GetTotalCategoriasAsync();
    }
}