using InventoryAPI_UI.Models.CategoriaModel;
using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;
using Refit;

namespace InventoryAPI_UI.Interfaces.Stats;

public interface ICategoriaStats
{
    [Get("/api/categoriaStat/total-categorias")]
    Task<int> GetTotalCategoriasAsync();

    [Get("/api/categoriaStat/distribucion-productos-por-categoria")]
    Task<PagedResponse<DistribucionCategoriaDto>> GetDistribucionProductosPorCategoriaAsync(
        [Query] int pageNumber = 1,
        [Query] int pageSize = 10
    );

    [Get("/api/categoriaStat/categoria-con-mas-productos")]
    Task<CategoriaResponseDto> GetCategoriaConMasProductosAsync();

    [Get("/api/categoriaStat/categoria-con-mayor-valor")]
    Task<CategoriaResponseDto> GetCategoriaConMayorValorAsync();

}