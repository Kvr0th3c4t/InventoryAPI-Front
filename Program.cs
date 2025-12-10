using System.Text.Json;
using Blazored.SessionStorage;
using InventoryAPI.UI.Services;
using InventoryAPI_UI;
using InventoryAPI_UI.Interfaces;
using InventoryAPI_UI.Interfaces.Stats;
using InventoryAPI_UI.Services.CategoriaService;
using InventoryAPI_UI.Services.MovimientoService;
using InventoryAPI_UI.Services.ProductoService;
using InventoryAPI_UI.Services.ProveedorService;
using InventoryAPI_UI.Services.StatsService.CategoriaStatsService;
using InventoryAPI_UI.Services.StatsService.MovimientoStatsService;
using InventoryAPI_UI.Services.StatsService.ProductoStatsService;
using InventoryAPI_UI.Services.StatsService.ProveedorStatsService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseURl = builder.Configuration["BaseAPI"] ?? "http://localhost:5142/";

builder.Services.AddBlazoredSessionStorage();

builder.Services.AddScoped<CustomAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(
    provider => provider.GetRequiredService<CustomAuthStateProvider>());

builder.Services.AddAuthorizationCore();

builder.Services.AddTransient<AuthHeaderHandler>();


// AuthService (sin handler porque login no necesita token)
builder.Services.AddRefitClient<IAuthService>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl));

// Servicios protegidos (con AuthHeaderHandler)
builder.Services.AddRefitClient<IProducto>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<ICategoria>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<IProveedor>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<IMovimiento>(new RefitSettings
{
    ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    })
})
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<IProductoStats>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<ICategoriaStats>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<IMoviminetosStats>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddRefitClient<IProveedorStats>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(baseURl))
    .AddHttpMessageHandler<AuthHeaderHandler>();

builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IProveedorService, ProveedorService>();
builder.Services.AddScoped<IMovimientoService, MovimientoService>();
builder.Services.AddScoped<IProductoStatsService, ProductoStatsService>();
builder.Services.AddScoped<IMovimientosStatsService, MovimientosStatsService>();
builder.Services.AddScoped<IProveedorStatsService, ProveedorStatsService>();
builder.Services.AddScoped<ICategoriaStatsService, CategoriaStatsService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();