using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseStaticFiles();
        app.UseWebSockets();
        app.UseSignalR();

    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSignalR(options => 
        {
            options.Hubs.EnableDetailedErrors = true;
        });
    }
}