using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibrary.Models;

namespace ClientLibrary.Models
{
    public class Polloi : IInteractive
    {
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public Player Player { get; set; }
        public Position CurrentPosition { get; set; }
    }

}
