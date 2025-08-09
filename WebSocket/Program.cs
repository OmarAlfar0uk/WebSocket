
using Microsoft.EntityFrameworkCore;
using WebSocket.Contexts;
using WebSocket.Hubs;

namespace WebSocket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ChatDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ChatConnection"));
            });
            builder.Services.AddSignalR();

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapHub<ChatHub>("/chat");
            });

            app.Run();
        }
    }
}
