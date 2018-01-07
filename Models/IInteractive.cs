using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibrary.Models
{
    public interface IInteractive
    {
        string Name { get; set; }
        Guid Uid { get; set; }
        Position CurrentPosition { get; set; }
    }
}
