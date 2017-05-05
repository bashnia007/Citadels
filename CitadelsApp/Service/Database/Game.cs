using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Database
{
    public class Game
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public List<User> Players { get; set; }
        public bool IsAvaivable { get; set; }
        public int PlayersCount { get; set; }
    }
}
