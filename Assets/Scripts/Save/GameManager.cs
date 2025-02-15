using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerDataSO playerData; // Перетащить объект в Inspector

    void Start()
    {
        Debug.Log("Игрок: " + playerData.playerName);
    }
}
