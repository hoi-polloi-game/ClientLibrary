using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibrary.Models;
using ClientLibrary.Models.Actions;
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

        public void MoveTo(Position newPosition)
        {
            ServerConnection.GetConnection().InvokeAsync(PolloiActions.MoveTo, Uid, newPosition);
        }

        public void MeleeAttack(IInteractive objectToAttack)
        {
            ServerConnection.GetConnection().InvokeAsync(PolloiActions.MeleeAttack, Uid, objectToAttack.Uid);
        }

        public void RangedAttack(IInteractive objectToAttack)
        {
            ServerConnection.GetConnection().InvokeAsync(PolloiActions.RangedAttack, Uid, objectToAttack.Uid);
        }
    }

}