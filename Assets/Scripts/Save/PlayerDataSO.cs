using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Game Data/PlayerData")]
public class PlayerDataSO : ScriptableObject
{
    public string playerName;
    public int score;
    public float health;
}
