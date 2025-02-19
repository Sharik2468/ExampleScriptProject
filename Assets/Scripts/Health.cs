using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // ������������ ��������
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " ������� ����: " + damage + ". ������� ��������: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " �����!");
        Destroy(gameObject); // ������� ������ (���� ��� �����)
    }
}
