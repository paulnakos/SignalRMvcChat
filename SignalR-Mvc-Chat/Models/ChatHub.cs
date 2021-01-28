using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR_Mvc_Chat.Models
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
            Clients.Others.alertMessage(message);
            Clients.User(name);
        }

        public void Announce (string message)
        {
            Clients.All.Announce(message);
        }
        
    }
}