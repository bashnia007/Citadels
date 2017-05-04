using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLIbrary
{
    public class Game
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public bool IsAvaivable { get; set; }
        public int MaxPlayersCount { get; set; }
    }
}
