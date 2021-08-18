using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Domain
{
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }

        public int Id { get; set; }
        public int Round { get; set; }
        public DateTimeOffset? StartTime { get; set; }

        // 聯合外鍵 (m:n)
        public List<GamePlayer> GamePlayers { get; set; }
    }

}
