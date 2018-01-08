using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibrary.Models
{
    public class Game
    {
        public Player Player { get; set; }
        public List<Polloi> Polloii { get; set; }
        public List<Spawn> Spawns { get; set; }
        public List<EnemyPlayer> EnemyPlayers { get; set; }
        public Guid CurrentTick { get; set; }

        public Game()
        {
            Polloii = new List<Polloi>();
        }
    }
}