using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChatServer.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message) // method client will call to send message 
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessage", "Server", "A new user has joined the chat!"); 
            
            await base.OnConnectedAsync();
        }
    }
}
