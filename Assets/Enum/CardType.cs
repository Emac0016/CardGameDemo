using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Enum
{
    public enum CardType
    {
        Resource, //Cards that can either be used infintely or spent to play other cards
        Creature, // Summoned to attack the General
        Weapon, // Can be wielded by creatures to buff their stats
        Spell, // Temporarily buffs creatures attack power and or health
        Leader // The backbone of a deck, attempt to destroy the leader
    }
}
