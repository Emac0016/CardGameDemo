using Assets.Classes;
using Assets.Enum;
using UnityEngine;
[System.Serializable]

public class CardBase
{
    public int ID { get; set; }
    public CardType Type { get; set; }
    public string Name { get; set; }
    public SummonCost SummonCost { get; set; }
    public string CardDescription { get; set; }
    public Sprite CardImage { get; set; }


    public CardBase()
    {

    }

    public CardBase(int iD, CardType type, string name, SummonCost summonCost, string cardDescription, Sprite cardImage)
    {
        ID = iD;
        Type = type;
        Name = name;
        SummonCost = summonCost;
        CardDescription = cardDescription;
        CardImage = cardImage;
    }
}
