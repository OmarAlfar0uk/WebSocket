using Microsoft.AspNetCore.SignalR;
using WebSocket.Contexts;
using WebSocket.Models;

namespace WebSocket.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ILogger<ChatHub> _logger;
        private readonly ChatDbContext _context;

        public async Task Send(string user, string message)
        {
            await Clients.Others.SendAsync("RecieveMessage", user, message);

            Message msg = new Message()
            {
                MessageText = message,
                UserName = user
            };

            _context.Messages.Add(msg);

            await _context.SaveChangesAsync();
        }

        public async Task JoinGroup(string groupName, string userName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            await Clients.OthersInGroup(groupName).SendAsync("NewMemberJoin", userName, groupName);

            _logger.LogInformation(Context.ConnectionId);
        }

        public async Task SendMessageToGroup(string groupName, string sender, string message)
        {
            await Clients.Group(groupName).SendAsync("RecieveMessageFromGroup", sender, message);

            Message msg = new Message()
            {
                MessageText = message,
                UserName = sender
            };

            _context.Messages.Add(msg);

            await _context.SaveChangesAsync();
        }
    }
}