using Assets.CardTypes;
using Assets.Classes;
using Assets.Enum;
using Assets.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CardDatabase : MonoBehaviour
{
    public static GameDeck Deck = new GameDeck();

    public static List<CreatureCard> creatures = new List<CreatureCard>();
    public static List<WeaponCard> weapons = new List<WeaponCard>();
    public static List<SpellCard> spells = new List<SpellCard>();
    public static List<ResourceCard> resources = new List<ResourceCard>();
    public static LeaderCard leader = new LeaderCard();

    void Awake()
    {

        //Load all the cards for a specific Deck
        //Creature cards = 0-100
        //Weapon cards = 101-200
        //Spell cards = 201-300
        //Leader cards = 301-400
        //Resource cards = 401-500
        creatures.Add(new CreatureCard(0, CardType.Creature, "Elf", new SummonCost(1, ResourceType.Vitality), "Elf creature", 1, 1, 0, Resources.Load<Sprite>("Flexing")));
        creatures.Add(new CreatureCard(1, CardType.Creature, "Dwarf", new SummonCost(1, ResourceType.Vitality), "Dwarf creature", 1, 3, 0, Resources.Load<Sprite>("Flexing")));
        creatures.Add(new CreatureCard(2, CardType.Creature, "Knight", new SummonCost(1, ResourceType.Vitality), "Knight creature", 2, 3, 0, Resources.Load<Sprite>("Flexing")));
        creatures.Add(new CreatureCard(4, CardType.Creature, "Wizard", new SummonCost(1, ResourceType.Vitality), "Wizard creature", 4, 1, 0, Resources.Load<Sprite>("Flexing")));
        weapons.Add(new WeaponCard(101, CardType.Weapon, "Blaster", new SummonCost(2, ResourceType.Vitality), "Weapon that adds 2 damage to attacking creatures power", 2, 0, Resources.Load<Sprite>("Utility")));
        weapons.Add(new WeaponCard(102, CardType.Weapon, "Shield", new SummonCost(1, ResourceType.Utility), "Weapon that adds 2 Health to target creature", 0, 2, Resources.Load<Sprite>("Utility")));
        weapons.Add(new WeaponCard(103, CardType.Weapon, "Sword", new SummonCost(3, ResourceType.Utility), "Weapon that adds 3 damage and 1 health to attacking creature", 2, 1, Resources.Load<Sprite>("Utility")));
        spells.Add(new SpellCard(201, CardType.Spell, "Plasma Blast", new SummonCost(3, ResourceType.Utility), "Spell that deals two damage to target creature", 3, 3, 0, CardType.Creature, Resources.Load<Sprite>("Utility")));
        spells.Add(new SpellCard(202, CardType.Spell, "Plasma Rock", new SummonCost(3, ResourceType.Utility), "Spell that deals five damage to target creature", 1, 5, 0, CardType.Creature, Resources.Load<Sprite>("Utility")));
        spells.Add(new SpellCard(203, CardType.Spell, "Earth Shield", new SummonCost(3, ResourceType.Utility), "Spell that heals four health of target creature", 2, 0, 4, CardType.Creature, Resources.Load<Sprite>("Utility")));
        resources.Add(new ResourceCard(401, CardType.Resource, ResourceType.Vitality, ResourceConsumption.Reusable, "Add 1 Vitality", Resources.Load<Sprite>("Utility")));
        resources.Add(new ResourceCard(402, CardType.Resource, ResourceType.Utility, ResourceConsumption.Reusable, "Add 1 Utility", Resources.Load<Sprite>("Utility")));
        resources.Add(new ResourceCard(403, CardType.Resource, ResourceType.Vitality, ResourceConsumption.Consumable, "Add 2 Vitality", Resources.Load<Sprite>("Utility")));
        resources.Add(new ResourceCard(404, CardType.Resource, ResourceType.Utility, ResourceConsumption.Consumable, "Add 2 Utility", Resources.Load<Sprite>("Utility")));
        leader = new LeaderCard(301, CardType.Leader, "Wheldon the Whimsicle", "A wizard who just enjoys being there", 35, new Ability("Wheldon's Whim", AbilityType.Phasing, "Mischief Creator"), 0, Resources.Load<Sprite>("Ethan"));

        Deck = new GameDeck()
        {
            DeckLeader = leader,
            UtilityCards = new UtilityCards
            {
                WeaponCards = weapons,
                SpellCards = spells,
                ResourceCards = resources
            },
            CreatureCards = creatures
        };

    }
}
