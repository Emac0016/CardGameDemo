using Assets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.CardTypes
{
    public class ResourceCard : CardBase
    {

        public ResourceType CardResourceType { get; set; }
        public string ResourcesAvailable { get; set; }
        public ResourceConsumption ConsumptionType { get; set; }

        public ResourceCard()
        {

        }

        public ResourceCard(int iD, CardType cardType, ResourceType resourceType, ResourceConsumption consumptionType, string resourcesAvailable, Sprite cardImage)
        {
            ID = iD;
            Type = cardType;
            CardResourceType = resourceType;
            ResourcesAvailable = resourcesAvailable;
            ConsumptionType = consumptionType;
            CardImage = cardImage;
        }

    }
}
