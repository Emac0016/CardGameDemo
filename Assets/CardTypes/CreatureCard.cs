using Assets.Enum;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Assets.Classes
{
    public class CreatureCard : CardBase
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int MarkedDamage { get; set; }
        [AllowNull]
        public Ability AddedAbility { get; set; }

        public CreatureCard()
        {

        }

        public CreatureCard(int iD, CardType cardType, string name, SummonCost summonCost, string cardDescription, int health, int strength, int markedDamage, Sprite cardImage)
        {
            ID = iD;
            Type = cardType;
            Name = name;
            SummonCost = summonCost;
            CardDescription = cardDescription;
            Health = health;
            Strength = strength;
            MarkedDamage = markedDamage;
            CardImage = cardImage;
        }
    }
}
