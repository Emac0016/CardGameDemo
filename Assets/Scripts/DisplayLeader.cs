using Assets.CardTypes;
using Assets.Classes;
using Assets.Enum;
using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLeader : MonoBehaviour
{
    public LeaderCard lcOnDisplay = new LeaderCard();
    public int displayId;

    // Card Class Properties
    public int id;
    public CardType cardType;
    public string cardName;
    public string cardDescription;
    public int toughness;
    public Sprite cardImage;
    public Ability ability;

    // Card Type Unity Properties
    // CardBase
    public Text nameText;
    public Text descriptionText;
    public Image image;

    //Leader
    public Text lifeText;
    public Text abilityNameText;
    public Text abilityDescriptionText;




    // Start is called before the first frame update
    void Start()
    {
        lcOnDisplay = CardDatabase.Deck.DeckLeader;
    }

    // Update is called once per frame
    void Update()
    {
        id = lcOnDisplay.ID;
        cardType = lcOnDisplay.Type;
        cardName = lcOnDisplay.Name;
        cardDescription = lcOnDisplay.CardDescription;
        toughness = lcOnDisplay.Health;
        ability = lcOnDisplay.Ability;
        cardImage = lcOnDisplay.CardImage;

        nameText.text = " " + cardName;
        descriptionText.text = " " + cardDescription;
        lifeText.text = " " + toughness;
        abilityNameText.text = " " + ability.AbilityName;
        abilityDescriptionText.text = " " + ability.AbilityDescription;
        image.sprite = cardImage;
    }
}
