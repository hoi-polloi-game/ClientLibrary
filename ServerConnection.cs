using System;
using ClientLibrary.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientLibrary
{
    public class ServerConnection
    {
        private static HubConnection connection;

        internal static HubConnection GetConnection()
        {
            if (connection != null)
                return connection;
            else
                throw new Exception("Missing ServerConnection Connection!");
        }

        private Action<Game> TickAction { get; set; } = new Action<Game>((game) =>
            throw new Exception("Missing Tick Action!"));

        public ServerConnection(string serverUrl)
        {
            connection = new HubConnectionBuilder()
                .WithUrl(serverUrl)
                .Build();

            connection.StartAsync();
        }

        public void SetTickAction(Action<Game> tickAction)
        {
            if (tickAction == null) throw new Exception("Tick Action Required!");
            TickAction = tickAction;
            GetConnection().On("Tick", TickAction);
        }

    }
}