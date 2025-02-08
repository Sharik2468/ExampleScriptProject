using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public float updatedTimeScale = 0.5f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = Time.timeScale == 1f ? updatedTimeScale : 1f;
        }
    }
}
