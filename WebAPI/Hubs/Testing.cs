using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebAPI.Hubs
{
    public class Testing : Hub
    {
        public void Send(string message)
        {
            Clients.All.newMessage(message);
        }

        public override Task OnConnected()
        {
            Debug.WriteLine(Context.ConnectionId);
            return base.OnConnected();
        }
    }
}