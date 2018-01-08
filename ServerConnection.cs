using System;
using System.Threading.Tasks;
using ClientLibrary.Models;
using ClientLibrary.Models.Actions;
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
            throw new Exception("Missing ServerConnection Connection!");
        }

        private Action<Game> TickAction { get; set; } = game =>
            throw new Exception("Missing Tick Action!");

        public ServerConnection(string serverUrl)
        {
            connection = new HubConnectionBuilder()
                .WithUrl(serverUrl)
                .Build();

            connection.StartAsync();
        }

        public async Task<Player> AddPlayer(string playerName)
        {
            return await connection.InvokeAsync<Player>(GameActions.AddPlayer, playerName);
        }

        public void SetTickAction(Action<Game> tickAction)
        {
            TickAction = tickAction ?? throw new Exception("Tick Action Required!");
            GetConnection().On("Tick", (Game game) =>
            {
                TickAction(game);
                GetConnection().InvokeAsync(GameActions.FinishedTick, game.CurrentTick);
            });
        }

    }
}