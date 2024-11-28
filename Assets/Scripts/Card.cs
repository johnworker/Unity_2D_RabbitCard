using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;  // 卡牌名稱
    public int attack;       // 攻擊值
    public int health;       // 血量值
    public Sprite image;     // 卡牌圖片

    public void Setup(string name, int atk, int hp, Sprite img)
    {
        cardName = name;
        attack = atk;
        health = hp;
        image = img;

        // 更新 UI
        transform.Find("Image").GetComponent<UnityEngine.UI.Image>().sprite = img;
        transform.Find("Text").GetComponent<UnityEngine.UI.Text>().text = $"{name}\nATK:{atk}\nHP:{hp}";
    }
}
