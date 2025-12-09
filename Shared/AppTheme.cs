using MudBlazor;

namespace InventoryAPI_UI.Shared;

public static class AppTheme
{
    public static MudTheme Theme = new()
    {
        PaletteLight = new PaletteLight()
        {
            // Colores principales de tu paleta
            Primary = "#4c96f6",
            Secondary = "#86b5f4",
            Tertiary = "#274060",

            // Backgrounds
            Background = "#f5f5f5",
            Surface = "#ffffff",
            DrawerBackground = "#274060",
            AppbarBackground = "#274060",

            // Textos
            TextPrimary = "#1e1e1e",
            TextSecondary = "#566887",
            DrawerText = "#b2c2d1",
            DrawerIcon = "#b2c2d1",
            AppbarText = "#ffffff",

            // Estados
            Success = "#4caf50",
            Info = "#4c96f6",
            Warning = "#ff9800",
            Error = "#f44336",

            // Otros
            Divider = "#e0e0e0",
            LinesDefault = "#e0e0e0",
        },

        LayoutProperties = new LayoutProperties()
        {
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "260px",
            AppbarHeight = "64px",
            DefaultBorderRadius = "4px",
        }
    };
}