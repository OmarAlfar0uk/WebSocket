using Microsoft.EntityFrameworkCore;
using WebSocket.Models;

namespace WebSocket.Contexts
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options)
            : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
    }
}
