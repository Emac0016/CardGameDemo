using Assets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Classes
{
    public class WeaponCard : CardBase
    {
        public int AttackBuff { get; set; }
        public int ArmorBuff { get; set; }

        public WeaponCard()
        {

        }

        public WeaponCard(int iD, CardType type, string name, SummonCost summonCost, string cardDescription, int attackBuff, int armorBuff, Sprite cardImage)
        {
            ID = iD;
            Type = type;
            Name = name;
            SummonCost = summonCost;
            CardDescription = cardDescription;
            AttackBuff = attackBuff;
            ArmorBuff = armorBuff;
            CardImage = cardImage;
        }
    }
}
