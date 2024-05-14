using Assets.CardTypes;
using Assets.Classes;
using Assets.Enum;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DisplayResource : MonoBehaviour
{
    public ResourceCard rcOnDisplay = new ResourceCard();
    public int displayId;

    // Card Class Properties
    public int id;
    public CardType cardType;
    public ResourceConsumption consumptionType;
    public string resourcesAvailable; 
    public ResourceType cardName;
    public Sprite cardImage;

    // Card Type Unity Properties
    // CardBase
    public Text nameText;
    public Image image;

    //Resource Cards
    public Text resourceAvailableText;
    public Text consumptionText;

    // Start is called before the first frame update
    void Start()
    {
        rcOnDisplay = CardDatabase.Deck.UtilityCards.ResourceCards.FirstOrDefault(rc => rc.ID == displayId);
    }

    // Update is called once per frame
    void Update()
    {
        id = rcOnDisplay.ID;
        cardType = rcOnDisplay.Type;
        cardName = rcOnDisplay.CardResourceType;
        resourcesAvailable = rcOnDisplay.ResourcesAvailable;
        cardImage = rcOnDisplay.CardImage;

        nameText.text = " " + cardName;
        resourceAvailableText.text = " " + resourcesAvailable;
        consumptionText.text = " " + consumptionType;
        image.sprite = cardImage;
    }
}
