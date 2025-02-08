using UnityEngine;

public class Collectables : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Предмет подобран!");
            Destroy(gameObject);
        }
    }
}
