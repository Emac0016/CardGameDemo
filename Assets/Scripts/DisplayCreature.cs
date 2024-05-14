using Assets.Classes;
using Assets.Enum;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCreature : MonoBehaviour
{
    public CreatureCard ccOnDisplay = new CreatureCard();
    public int displayId;

    // Card Class Properties
    public int id;
    public CardType cardType;
    public string cardName;
    public SummonCost cost;
    public string cardDescription;
    public int toughness;
    public int strength;
    public Sprite cardImage;

    // Card Type Unity Properties
    // CardBase
    public Text nameText;
    public Text costText;
    public Text descriptionText;
    public Image image;

    //Creature
    public Text toughnessText;
    public Text strengthText;

    // Start is called before the first frame update
    void Start()
    {
        ccOnDisplay = CardDatabase.Deck.CreatureCards.FirstOrDefault(cc => cc.ID == displayId);
    }

    // Update is called once per frame
    void Update()
    {
        id = ccOnDisplay.ID;
        cardType = ccOnDisplay.Type;
        cardName = ccOnDisplay.Name;
        cost = ccOnDisplay.SummonCost;
        toughness = ccOnDisplay.Health;
        strength = ccOnDisplay.Strength;
        cardDescription = ccOnDisplay.CardDescription;
        cardImage = ccOnDisplay.CardImage;


        nameText.text = " " + cardName;
        costText.text = " " + cost.CostAmount + " " + cost.CostResource;
        descriptionText.text = " " + cardDescription;
        toughnessText.text = " " + toughness;
        strengthText.text = " " + strength;
        image.sprite = cardImage;
    }
}
