using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���������� ������
        PlayerPrefs.SetInt("HighScore", 100);
        PlayerPrefs.SetFloat("Volume", 0.8f);
        PlayerPrefs.SetString("PlayerName", "Alex");
        PlayerPrefs.Save(); // ��������� ���������

        //�������� ������
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        float volume = PlayerPrefs.GetFloat("Volume", 1.0f);
        string playerName = PlayerPrefs.GetString("PlayerName", "Unknown");

        //�������� ������
        PlayerPrefs.DeleteKey("HighScore"); // ������� ���� ��������
        PlayerPrefs.DeleteAll(); // ������� ��� ����������� ������


    }
}
