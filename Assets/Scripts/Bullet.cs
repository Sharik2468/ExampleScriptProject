using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 20; // ���� �� ����
    public float lifeTime = 3f; // ����� ����� ����

    void Start()
    {
        Destroy(gameObject, lifeTime); // �������� ���� ����� 3 ���
    }

    void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();

        if (health != null) // ���� � ������� ���� ��������
        {
            health.TakeDamage(damage); // ������� ����
        }

        Destroy(gameObject); // ������� ���� ��� ������������
    }
}
