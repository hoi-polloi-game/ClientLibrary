using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibrary.Models.Actions;
using ClientLibrary.Models.Results;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientLibrary.Models
{
    public class Spawn :IInteractive
    {
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public Position CurrentPosition { get; set; }

        public async Task<SpawnResult> SpawnPolloi(List<BodyPart> bodyParts){
            return await ServerConnection.GetConnection().InvokeAsync<SpawnResult>(SpawnActions.SpawnPolloi, Uid, bodyParts);
        }
    }
}
