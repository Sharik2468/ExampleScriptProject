using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 20; // Урон от пули
    public float lifeTime = 3f; // Время жизни пули

    void Start()
    {
        Destroy(gameObject, lifeTime); // Удаление пули через 3 сек
    }

    void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();

        if (health != null) // Если у объекта есть здоровье
        {
            health.TakeDamage(damage); // Наносим урон
        }

        Destroy(gameObject); // Удаляем пулю при столкновении
    }
}
