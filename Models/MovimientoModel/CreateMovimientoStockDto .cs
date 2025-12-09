using InventoryAPI_UI.Enums;

namespace InventoryAPI_UI.Models.MovimientoModel;

public class CreateMovimientoStockDto
{
    public int ProductoId { get; set; }
    public int? ProveedorId { get; set; }
    public TipoMovimiento Tipo { get; set; }
    public int Cantidad { get; set; }
    public string? Razon { get; set; }
}

