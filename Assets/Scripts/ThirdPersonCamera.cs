using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // ����� (�����, ������ ������� ��������� ������)
    public float mouseSensitivity = 100f; // ���������������� ����
    public float distanceFromTarget = 3f; // ��������� �� ���������

    public float minYAngle = -20f; // ����������� ���� ������� ������
    public float maxYAngle = 60f;  // ������������ ���� ������� ������

    private float yaw = 0f; // ���� �������� �� �����������
    private float pitch = 0f; // ���� �������� �� ���������

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // ��������� ������ � ������ ������
    }

    void LateUpdate()
    {
        // �������� ���� � ����
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // ������������ ���� ������� ������
        pitch = Mathf.Clamp(pitch, minYAngle, maxYAngle);

        // ��������� ������� � �������� ������
        Vector3 direction = new Vector3(0, 0, -distanceFromTarget);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        transform.position = target.position + rotation * direction;

        // ���������� ������ �� ������
        transform.LookAt(target);
    }
}
