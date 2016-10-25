using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace S00155398SignalRChatEx2016
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            Hello();
            return base.OnConnected();
        }
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

    }
}