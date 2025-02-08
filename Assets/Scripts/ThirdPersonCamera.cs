using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // Игрок (точка, вокруг которой вращается камера)
    public float mouseSensitivity = 100f; // Чувствительность мыши
    public float distanceFromTarget = 3f; // Дистанция от персонажа

    public float minYAngle = -20f; // Минимальный угол наклона камеры
    public float maxYAngle = 60f;  // Максимальный угол наклона камеры

    private float yaw = 0f; // Угол поворота по горизонтали
    private float pitch = 0f; // Угол поворота по вертикали

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Блокируем курсор в центре экрана
    }

    void LateUpdate()
    {
        // Получаем ввод с мыши
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Ограничиваем угол наклона камеры
        pitch = Mathf.Clamp(pitch, minYAngle, maxYAngle);

        // Вычисляем позицию и вращение камеры
        Vector3 direction = new Vector3(0, 0, -distanceFromTarget);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        transform.position = target.position + rotation * direction;

        // Направляем камеру на игрока
        transform.LookAt(target);
    }
}
