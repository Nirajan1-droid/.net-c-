//using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.SignalR;
using WebApplication2.Models;//for Hub not using core it allows bidirectional communication


namespace WebApplication2.Hubs
{ //for bidirectional communication we are creating the hub file. for real time communication


    public class ChatHub :Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        //public async Task JoinChat(UserConnection connection)
        //{
        //    await Clients.All.SendAsync(method: "Recieved Message", 
        //        arg1: "admin", arg2: $"{connection.UserName} has joined");

        //}
        //public async Task JoinSpecificChatRoom(UserConnection connection)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, 
        //        groupName: connection.chatRoom);
        //    await Clients.Group(connection.chatRoom).
        //        SendAsync(method: "recieveMessage", arg1: "admin", 
        //        arg2: $"{connection.UserName} has joined ${connection.chatRoom}");
        //}
    }
}
