using System;
using System.Collections.Generic;

namespace BotChallenge.BLL.Models
{
    public class Player
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public Game Game { get; set; }
        public bool IsReady { get; set; } = false;
        public HashSet<string> ConnectionIds { get; set; }
        public string[] BotsCode { get; set; }
        public int BotsCount { get; set; }
    }
}
