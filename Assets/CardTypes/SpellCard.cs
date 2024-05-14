using Assets.Classes;
using Assets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.CardTypes
{
    public class SpellCard : CardBase
    {
        public int UsesLeft { get; set; }
        public int DamageDealt { get; set; }
        public int HealthHealed { get; set; }
        public CardType TargetCardType { get; set; }

        public SpellCard()
        {

        }

        public SpellCard(int iD, CardType type, string name, SummonCost summonCost, string cardDescription, int usesLeft, int damageDealt, int healthHealed, CardType targetCardType, Sprite cardImage)
        {
            ID = iD;
            Type = type;
            Name = name;
            SummonCost = summonCost;
            CardDescription = cardDescription;
            UsesLeft = usesLeft;
            DamageDealt = damageDealt;
            HealthHealed = healthHealed;
            TargetCardType = targetCardType;
            CardImage = cardImage;
        }
    }
}
