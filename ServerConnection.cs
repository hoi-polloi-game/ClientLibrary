using System;
using ClientLibrary.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientLibrary
{
    public class ServerConnection
    {
        internal HubConnection connection { get; set; }
        private Action<Game> TickAction { get; set; } = new Action<Game>((game) => throw new Exception("Missing Tick Action!"));

        public ServerConnection(string serverUrl)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl(serverUrl)
                .Build();

            connection.StartAsync();
        }

        public void SetTickAction(Action<Game> tickAction){
            if(tickAction == null) throw new Exception("Tick Action Required!");
            TickAction = tickAction;
            connection.On("Tick", TickAction);
        }

    }
}