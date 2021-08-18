using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Domain
{
    public class GamePlayer
    {
        public int PlayerId { get; set; }

        public int GameId { get; set; }

        // 聯合外鍵 (m:n)
        public Game Game { get; set; }

        public Player Player { get; set; }
    }
}
