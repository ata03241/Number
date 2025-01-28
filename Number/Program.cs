using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Number;
using Number.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<Numberver>();
builder.Services.AddSingleton<Historybookcs>();


var NumberapiKey = builder.Configuration["NumverifyApiKey"];
builder.Services.AddSingleton(new NumverifyService(NumberapiKey));

var ExchangeKey = builder.Configuration["ExchangeApiKey"];
builder.Services.AddSingleton(new Exchangeservice(ExchangeKey));


await builder.Build().RunAsync();
