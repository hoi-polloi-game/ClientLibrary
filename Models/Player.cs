using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibrary.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Guid PlayerUid { get; set; }
        public string PlayerClientId { get; set; }
        public Guid LastFinishedTick { get; set; }
    }
}
