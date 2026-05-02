using FinancialManagement.Ui;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiBaseUrl = builder.Configuration["Api:BaseUrl"] 
                 ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");

var apiScope = builder.Configuration["Api:Scope"]
               ?? throw new InvalidOperationException("ApiScope is not configured.");

builder.Services.AddScoped<AuthorizationMessageHandler>();

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add(apiScope);
});

builder.Services.AddScoped(sp =>
{
    var handler = sp.GetRequiredService<AuthorizationMessageHandler>()
        .ConfigureHandler(
            authorizedUrls: [apiBaseUrl],
            scopes: [apiScope]);

    return new HttpClient(handler)
    {
        BaseAddress = new Uri(apiBaseUrl)
    };
});


await builder.Build().RunAsync();
