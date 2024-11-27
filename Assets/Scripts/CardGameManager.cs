using UnityEngine;
using UnityEngine.UI;

public class CardGameManager : MonoBehaviour
{
    public GameObject cardPrefab; // 卡牌預置體
    public Transform cardParent; // 卡牌父物件
    public Sprite[] cardSprites; // 卡牌圖像集
    public Button drawButton; // 抽卡按鈕

    void Start()
    {
        drawButton.onClick.AddListener(DrawCard); // 綁定按鈕事件
    }

    void DrawCard()
    {
        // 隨機選擇一張卡牌
        int randomIndex = Random.Range(0, cardSprites.Length);
        Sprite selectedSprite = cardSprites[randomIndex];

        // 創建卡牌實例
        GameObject newCard = Instantiate(cardPrefab, cardParent);
        newCard.GetComponent<SpriteRenderer>().sprite = selectedSprite;

        // 調整卡牌位置（可根據需求排列）
        newCard.transform.position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0);
    }
}
