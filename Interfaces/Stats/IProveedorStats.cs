using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProveedorModel;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;
using InventoryAPI_UI.Models.StatsModels.ProveedoresStatsDto;
using Refit;

namespace InventoryAPI_UI.Interfaces.Stats;

public interface IProveedorStats
{
    [Get("/api/proveedorStat/total-proveedores")]
    Task<int> GetTotalProveedoresAsync();

    [Get("/api/proveedorStat/productos-por-proveedor")]
    Task<PagedResponse<DistribucionProveedorDto>> GetProductosPorProveedorAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/proveedorStat/proveedor-mas-activo")]
    Task<ProveedorResponseDto?> GetProveedorMasActivoAsync();

    [Get("/api/proveedorStat/valor-inventario-por-proveedor")]
    Task<PagedResponse<DistribucionValorProveedorDto>> GetValorInventarioPorProveedorAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );


}