using Microsoft.AspNetCore.SignalR;

namespace RealtimeChatApp.Hubs;
// public interface IChatClient
// {
//     Task ReceiveMessage(string user, string message);
// }
//
// public class ChatHub : Hub<IChatClient>
// {
//     public async Task SendMessage(string user, string message) =>
//         await Clients.All.ReceiveMessage(user, message);
// }
public class ChatHub : Hub
{
    public async Task NewMessage(long username, string message) =>
        await Clients.All.SendAsync("messageReceived", username, message);
}