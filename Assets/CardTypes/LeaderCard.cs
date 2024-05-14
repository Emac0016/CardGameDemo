using Assets.Enum;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts
{
    public class LeaderCard : CardBase
    {
        public int Health { get; set; }
        public Ability Ability { get; set; }
        public int Armor { get; set; }
        public int MarkedDamage { get; set; }

        public LeaderCard()
        {

        }

        public LeaderCard(int iD, CardType type, string name, string cardDescription, int health, Ability ability, int markedDamage, Sprite cardImage)
        {
            ID = iD;
            Type = type;
            Name = name;
            CardDescription = cardDescription;
            Health = health;
            Ability = ability;
            MarkedDamage = markedDamage;
            CardImage = cardImage;
        }
    }
}
