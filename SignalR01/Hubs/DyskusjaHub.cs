using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR01.Hubs
{
    [HubName("AutorskiHub")]
    public class DyskusjaHub : Hub
    {
        [HubMethodName("wyslijBezNicka")]
        public void Wyslij(String tresc)
        {
            Clients.All.wyswietlWiadomosc(tresc);
        }
        [HubMethodName("wyslijZNick")]
        public void Wyslij(String tresc, String nick)
        {
            Clients.All.wyswietlWiadomosc(tresc, nick);
        }

    }
}