using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private GameInput gameInput;

    private bool isWalking;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 movementVector3 = gameInput.GetMovementVectorNormalized();

        isWalking = movementVector3 != Vector3.zero;

                // Задаем GO движение
        transform.position += movementVector3 * Time.deltaTime * moveSpeed;

        transform.forward = Vector3.Slerp(transform.forward, movementVector3, Time.deltaTime * rotationSpeed);
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
