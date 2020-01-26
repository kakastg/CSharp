using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ProjectWeb.Hubs
{
    [HubName("AutorskiHub")]
    public class ChatHub  : Hub
    {
        private static int uczestnicy;
      
        [HubMethodName("wyslijZNick")]
        public void Wyslij(String tresc, String nick)
        {
            Clients.All.wyswietlWiadomosc(tresc, nick);
        }
        public override Task OnConnected()
        {
            Clients.All.online(++uczestnicy);
            return base.OnConnected();
        }
    }
}