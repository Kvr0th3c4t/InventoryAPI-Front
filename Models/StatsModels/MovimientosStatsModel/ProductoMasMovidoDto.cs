namespace InventoryAPI_UI.Models.StatsModels.MovimientosStatModel;

public class ProductoMasMovidoDto
{
    public int ProductoId { get; set; }
    public string NombreProducto { get; set; } = string.Empty;
    public int TotalMovimientos { get; set; }
}