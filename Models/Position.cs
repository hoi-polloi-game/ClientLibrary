using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibrary.Models
{
    public class Position
    {
        public Guid ZoneUid { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }

        public Position() { }
        public Position(int top, int left)
        {
            Top = top;
            Left = left;
        }
    }
}
