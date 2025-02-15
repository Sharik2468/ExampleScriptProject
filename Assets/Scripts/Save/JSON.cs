using System.IO;
using UnityEngine;

public class JSON : MonoBehaviour
{
    [System.Serializable] // Позволяет сериализовать объект в JSON
    public class PlayerData
    {
        public string playerName;
        public int score;
        public float health;
    }

    private string path;

    void Start()
    {
        path = Application.persistentDataPath + "/save.json";
    }

    public void SaveData(PlayerData data)
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);
    }

    public PlayerData LoadData()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<PlayerData>(json);
        }
        return new PlayerData(); // Если файла нет, возвращаем пустые данные
    }

}
