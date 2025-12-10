using System.Net.Http.Headers;
using Blazored.SessionStorage;

namespace InventoryAPI.UI.Services;

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly ISessionStorageService _sessionStorage;

    public AuthHeaderHandler(ISessionStorageService sessionStorage)
    {
        _sessionStorage = sessionStorage;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        // Obtener token del session storage
        var token = await _sessionStorage.GetItemAsync<string>("authToken", cancellationToken);

        // Si existe, agregarlo al header Authorization
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}