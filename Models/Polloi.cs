using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibrary.Models;
using ClientLibrary.Models.Actions;
using ClientLibrary.Models.Results;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientLibrary.Models
{
    public class Polloi : IInteractive
    {
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public Player Player { get; set; }
        public Position CurrentPosition { get; set; }
        public List<BodyPart> BodyParts { get; set; }

        public async Task<PolloiResult> MoveTo(Position newPosition)
        {
            return await ServerConnection.GetConnection().InvokeAsync<PolloiResult>(PolloiActions.MoveTo, Uid, newPosition);
        }

        public async Task<PolloiResult> MeleeAttack(IInteractive objectToAttack)
        {
            return await ServerConnection.GetConnection().InvokeAsync<PolloiResult>(PolloiActions.MeleeAttack, Uid, objectToAttack.Uid);
        }

        public async Task<PolloiResult> RangedAttack(IInteractive objectToAttack)
        {
            return await ServerConnection.GetConnection().InvokeAsync<PolloiResult>(PolloiActions.RangedAttack, Uid, objectToAttack.Uid);
        }
    }

}