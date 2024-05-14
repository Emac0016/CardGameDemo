using Assets.CardTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Classes
{
    public class UtilityCards
    {
        public List<WeaponCard> WeaponCards { get; set; }
        public List<SpellCard> SpellCards { get; set; }
        public List<ResourceCard> ResourceCards { get; set; }

        public UtilityCards()
        {

        }

        public UtilityCards(List<WeaponCard> weaponCards, List<SpellCard> spellCards, List<ResourceCard> resources)
        {
            WeaponCards = weaponCards;
            SpellCards = spellCards;
            ResourceCards = resources;
        }
    }
}
