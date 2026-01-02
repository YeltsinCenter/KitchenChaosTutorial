using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float rotationSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        // Задаем вектор в состоянии покоя
        Vector3 inputVector3 = new Vector3(0, 0, 0);

        // Принимаем ввод игрока
        if (Input.GetKey(KeyCode.W))
        {
            inputVector3.z = +1;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            inputVector3.z = -1;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            inputVector3.x = +1;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            inputVector3.x = -1;
        }

        // Нормализуем вектор
        inputVector3 = inputVector3.normalized;

        // Задаем GO движение
        transform.position += inputVector3 * Time.deltaTime * moveSpeed;

        transform.forward = Vector3.Slerp(transform.forward, inputVector3, Time.deltaTime * rotationSpeed);
    }
}
