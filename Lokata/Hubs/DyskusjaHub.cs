using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace DyskusjaSR.Hubs
{
    [HubName("AutorskiHub")]
    public class DyskusjaHub : Hub
    {
        private static int uczestnicy;
        [HubMethodName("wyslijZNickiem")]
        public void Wyslij(string tresc, string nick)
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