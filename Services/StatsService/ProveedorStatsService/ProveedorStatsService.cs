using InventoryAPI_UI.Interfaces.Stats;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProveedorModel;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;
using InventoryAPI_UI.Models.StatsModels.ProveedoresStatsDto;

namespace InventoryAPI_UI.Services.StatsService.ProveedorStatsService;

public class ProveedorStatsService : IProveedorStatsService
{

    private readonly IProveedorStats _api;

    public ProveedorStatsService(IProveedorStats api)
    {
        _api = api;
    }
    public async Task<PagedResponse<DistribucionProveedorDto>> GetProductosPorProveedorAsync(int? pageNumber, int? pageSize)
    {
        return await _api.GetProductosPorProveedorAsync(pageNumber: pageNumber ?? 1, pageSize: pageSize ?? 10);
    }

    public Task<ProveedorResponseDto?> GetProveedorMasActivoAsync()
    {
        return _api.GetProveedorMasActivoAsync();
    }

    public Task<int> GetTotalProveedoresAsync()
    {
        return _api.GetTotalProveedoresAsync();
    }

    public async Task<PagedResponse<DistribucionValorProveedorDto>> GetValorInventarioPorProveedorAsync(int? pageNumber, int? pageSize)
    {
        return await _api.GetValorInventarioPorProveedorAsync(pageNumber: pageNumber ?? 1,
        pageSize: pageSize ?? 10);
    }
}