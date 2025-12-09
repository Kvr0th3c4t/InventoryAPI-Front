using InventoryAPI_UI.Models.Pagination;
using InventoryAPI_UI.Models.ProductoModel;
using InventoryAPI_UI.Models.StatsModels.ProductosStatsModel;

namespace InventoryAPI_UI.Services.StatsService.ProductoStatsService;

public interface IProductoStatsService
{
   Task<int> GetTotalProductos();

   Task<int> GetProductosBajoStock();

   Task<int> GetProductosSinStock();

   Task<decimal> GetTotalValorInventario();

   Task<decimal> GetPrecioPromedio();

   Task<decimal> GetPrecioMasAlto();

   Task<decimal> GetPrecioMasBajo();

   Task<int> GetProductosUltimos30Ddias();

   Task<PagedResponse<DistribucionCategoriaDto>> GetDistribucionPorCategoria(
      int? pageNumber = null,
      int? pageSize = null
   );

   Task<PagedResponse<DistribucionProveedorDto>> GetDistribucionPorProveedor(
      int? pageNumber = null,
      int? pageSize = null
   );

   Task<List<ProductoResponseDto>> GetTop5ProductosMasValiosos();

   Task<List<ProductoResponseDto>> GetTop5ProductosMasStock();

   Task<List<ProductoResponseDto>> GetTop5ProductosMenorStock();

}