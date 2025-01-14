﻿using System;
using System.Collections.Generic;

namespace EFCoreDemo.Domain
{
    public class Player
    {
        public Player()
        {
            GamePlayers = new List<GamePlayer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }


        // 聯合外鍵 (m:n)
        public List<GamePlayer> GamePlayers { get; set; }


        // (1:1)
        public int ResumeId { get; set; }

        public Resume Resume { get; set; }
    }
}
