﻿using BlazorWasmApp0;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
if (!builder.RootComponents.Any())
{
    builder.RootComponents.Add<App>("app");
    builder.RootComponents.Add<HeadOutlet>("head::after");
}

await builder.Build().RunAsync();
