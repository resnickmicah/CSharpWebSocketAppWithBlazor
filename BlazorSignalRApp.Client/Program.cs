using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using BlazorSignalRApp.Hubs;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSignalR();

builder.Services.AddResponseCompression(opts =>
{
   opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
       [ "application/octet-stream" ]);
});

app.UseResponseCompression();
app.MapHub<ChatHub>("/chathub");

await builder.Build().RunAsync();
