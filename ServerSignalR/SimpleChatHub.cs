using Microsoft.AspNetCore.SignalR;

namespace ServerSignalR
{
    public class SimpleChatHub : Hub
    {
        public async Task Send(string username, string message)
        {
            await this.Clients.All.SendAsync("Receive", username, message);
        }
    }
}
