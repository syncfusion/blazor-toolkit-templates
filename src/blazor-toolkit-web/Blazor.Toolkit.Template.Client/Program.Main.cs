using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
namespace Blazor.Toolkit.Template.Client;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        await builder.Build().RunAsync();
    }
}
