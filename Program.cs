using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace PiTopLightServer
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var ledService = new LEDService();
            var app = WebApplication.Create(args);

            app.MapGet("/green", async http =>
            {
                ledService.ToggleGreen();
                await http.Response.WriteJsonAsync(new { success = true });
            });
            app.MapGet("/amber", async http =>
            {
                ledService.ToggleGold();
                await http.Response.WriteJsonAsync(new { success = true });
            });
            app.MapGet("/red", async http =>
            {
                ledService.ToggleRed();
                await http.Response.WriteJsonAsync(new { success = true });
            });

            await app.RunAsync();
        }
    }
}
