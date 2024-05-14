using Assets.Classes;
using Assets.Enum;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWeapon : MonoBehaviour
{
    public WeaponCard wcOnDisplay = new WeaponCard();
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

    //Weapon
    public Text toughnessAddText;
    public Text strengthAddText;

    // Start is called before the first frame update
    void Start()
    {
        wcOnDisplay = CardDatabase.Deck.UtilityCards.WeaponCards.FirstOrDefault(wc => wc.ID == displayId);
    }

    // Update is called once per frame
    void Update()
    {
        id = wcOnDisplay.ID;
        cardType = wcOnDisplay.Type;
        cardName = wcOnDisplay.Name;
        cost = wcOnDisplay.SummonCost;
        toughness = wcOnDisplay.ArmorBuff;
        strength = wcOnDisplay.AttackBuff;
        cardDescription = wcOnDisplay.CardDescription;
        cardImage = wcOnDisplay.CardImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost.CostAmount + " " + cost.CostResource;
        descriptionText.text = " " + cardDescription;
        toughnessAddText.text = " +" + toughness + " toughness";
        strengthAddText.text = " +" + strength + " strength";
        descriptionText.text = " " + cardDescription;
        image.sprite = cardImage;
    }
}
