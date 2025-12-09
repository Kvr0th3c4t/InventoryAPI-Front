namespace InventoryAPI_UI.Models.StatsModels.MovimientosStatModel;

public class MovimientoPorDiaDto
{
    public DateTimeOffset Fecha { get; set; }
    public int TotalMovimientos { get; set; }
}