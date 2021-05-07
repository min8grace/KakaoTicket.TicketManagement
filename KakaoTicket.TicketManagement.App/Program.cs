using KakaoTicket.TicketManagement.App.Contracts;
using KakaoTicket.TicketManagement.App.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("https://localhost:44306"));

            builder.Services.AddScoped<IEventDataService, EventDataService>();
            builder.Services.AddScoped<ICategoryDataService, CategoryDataService>();
            builder.Services.AddScoped<IOrderDataService, OrderDataService>();

            await builder.Build().RunAsync();
        }
    }
}
