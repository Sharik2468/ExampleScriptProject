using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.Play();
        }
    }
}
