using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Максимальное здоровье
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " получил урон: " + damage + ". Текущее здоровье: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " погиб!");
        Destroy(gameObject); // Удаляем объект (враг или игрок)
    }
}
