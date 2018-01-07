using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibrary.Models.Actions;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientLibrary.Models
{
    public class Spawn :IInteractive
    {
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public Position CurrentPosition { get; set; }

        public void SpawnPolloi(List<BodyPart> bodyParts){
            ServerConnection.GetConnection().InvokeAsync(SpawnActions.SpawnPolloi, Uid, bodyParts);
        }
    }
}
