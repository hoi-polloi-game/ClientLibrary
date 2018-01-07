using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibrary.Models
{
    public class Spawn :IInteractive
    {
        public string Name { get; set; }
        public Guid Uid { get; set; }
        public Position CurrentPosition { get; set; }
    }
}
