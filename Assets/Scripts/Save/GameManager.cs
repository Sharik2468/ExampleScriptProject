using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerDataSO playerData; // ���������� ������ � Inspector

    void Start()
    {
        Debug.Log("�����: " + playerData.playerName);
    }
}
