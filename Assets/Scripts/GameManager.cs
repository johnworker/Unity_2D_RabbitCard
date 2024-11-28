using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPlayerTurn = true;

    public void EndTurn()
    {
        isPlayerTurn = !isPlayerTurn;
        Debug.Log(isPlayerTurn ? "玩家回合" : "敵人回合");
    }
}
