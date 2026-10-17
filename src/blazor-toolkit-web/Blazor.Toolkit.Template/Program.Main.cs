#if (UseWebAssembly && IncludeSampleContent)
using Blazor.Toolkit.Template.Client.Pages;
#endif
using Blazor.Toolkit.Template.Components;
using Syncfusion.Blazor.Toolkit;
using static Microsoft.AspNetCore.Components.Web.RenderMode;

namespace Blazor.Toolkit.Template;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add Syncfusion Blazor Toolkit services
        builder.Services.AddSyncfusionBlazorToolkit();

        // Add services to the container.
#if (!UseServer && !UseWebAssembly)
        builder.Services.AddRazorComponents();
#else
        builder.Services.AddRazorComponents()
#if (UseServer && UseWebAssembly)
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();
#elif (UseServer)
            .AddInteractiveServerComponents();
#elif (UseWebAssembly)
            .AddInteractiveWebAssemblyComponents();
#endif
#endif

        var app = builder.Build();

        // Configure the HTTP request pipeline.
#if (UseWebAssembly)
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
#else
        if (!app.Environment.IsDevelopment())
#endif
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
#if (HasHttpsProfile)
        app.UseHttpsRedirection();
#endif

        app.UseAntiforgery();

        app.MapStaticAssets();

#if (UseServer && UseWebAssembly)
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddInteractiveWebAssemblyRenderMode();
#elif (UseServer)
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();
#elif (UseWebAssembly)
        app.MapRazorComponents<App>()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Blazor.Toolkit.Template.Client._Imports).Assembly);
#else
        app.MapRazorComponents<App>();
#endif

        app.Run();
    }
}
