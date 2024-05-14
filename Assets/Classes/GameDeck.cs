using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Classes
{
    public class GameDeck
    {
        public LeaderCard DeckLeader { get; set; }
        public UtilityCards UtilityCards { get; set; }
        public List<CreatureCard> CreatureCards { get; set; }
    }
}
