using Assets.CardTypes;
using Assets.Classes;
using Assets.Enum;
using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySpell : MonoBehaviour
{
    public SpellCard scOnDisplay = new SpellCard();
    public int displayId;

    // Card Class Properties
    public int id;
    public CardType cardType;
    public CardType targetCardType;
    public string cardName;
    public SummonCost cost;
    public string cardDescription;
    public int uses;
    public int healthHealed;
    public int damageDealt;
    public int strengthBuff;
    public int toughnessBuff;
    public Sprite cardImage;

    // Card Type Unity Properties
    // CardBase
    public Text nameText;
    public Text costText;
    public Text descriptionText;
    public Image image;

  
    //Spell
    public Text toughnessBuffText;
    public Text strengthBuffText;
    public Text targetCardTypeText;
    public Text usesleftText;

    // Start is called before the first frame update
    void Start()
    {
        scOnDisplay = CardDatabase.Deck.UtilityCards.SpellCards.FirstOrDefault(sc => sc.ID == displayId);
    }

    // Update is called once per frame
    void Update()
    {
        id = scOnDisplay.ID;
        cardType = scOnDisplay.Type;
        cardName = scOnDisplay.Name;
        cost = scOnDisplay.SummonCost;
        cardDescription = scOnDisplay.CardDescription;
        strengthBuff = scOnDisplay.DamageDealt;
        toughnessBuff = scOnDisplay.HealthHealed;
        targetCardType = scOnDisplay.TargetCardType;
        uses = scOnDisplay.UsesLeft;
        cardImage = scOnDisplay.CardImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost.CostAmount + " " + cost.CostResource;
        descriptionText.text = " " + cardDescription;
        strengthBuffText.text = " +" + strengthBuff + " strength";
        toughnessBuffText.text = " +" + toughnessBuff + " toughness";
        targetCardTypeText.text = " " + targetCardType;
        usesleftText.text = " " + uses + " uses left";
        image.sprite = cardImage;
    }
}
