using InventoryAPI_UI.Enums;

namespace InventoryAPI_UI.Models.MovimientoModel;

public class UpdateMovimientoDto
{
    public int? ProveedorId { get; set; }
    public TipoMovimiento? Tipo { get; set; }
    public int? Cantidad { get; set; }
    public string? Razon { get; set; }
}

