using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public GameObject cardPrefab;  // 卡牌預製物
    public Transform playerHand;  // 玩家手牌區域
    public Transform enemyHand;   // 敵人手牌區域

    void Start()
    {
        // 示例卡牌數據
        List<CardData> deck = new List<CardData>
        {
            new CardData("Warrior", 5, 10, null),
            new CardData("Mage", 7, 5, null),
            new CardData("Archer", 4, 6, null)
        };

        // 生成玩家卡牌
        foreach (var card in deck)
        {
            CreateCard(card, playerHand);
        }

        // 生成敵人卡牌
        foreach (var card in deck)
        {
            CreateCard(card, enemyHand);
        }
    }

    void CreateCard(CardData cardData, Transform hand)
    {
        GameObject card = Instantiate(cardPrefab, hand);
        card.GetComponent<Card>().Setup(cardData.name, cardData.attack, cardData.health, cardData.image);
    }
}

[System.Serializable]
public class CardData
{
    public string name;
    public int attack;
    public int health;
    public Sprite image;

    public CardData(string name, int attack, int health, Sprite image)
    {
        this.name = name;
        this.attack = attack;
        this.health = health;
        this.image = image;
    }
}
