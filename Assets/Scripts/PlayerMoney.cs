using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int playerMoney;

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (playerMoney >= moneyToRemove)
        {
            playerMoney -= moneyToRemove;
            return true;
        }
        else
        {
            return false;
        }
    }
}