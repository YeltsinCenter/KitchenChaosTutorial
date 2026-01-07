using UnityEngine;

public class GameInput : MonoBehaviour
{

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector3 GetMovementVectorNormalized()
    {
        // Задаем вектор в состоянии покоя
        Vector3 inputVector3 = playerInputActions.Player.Movement.ReadValue<Vector3>();

        // Нормализуем вектор
        inputVector3 = inputVector3.normalized;

        return inputVector3;
    }

    public Vector3 GetMovementVector()
    {
        // Задаем вектор в состоянии покоя
        Vector3 inputVector3 = playerInputActions.Player.Movement.ReadValue<Vector3>();

        return inputVector3;
    }
}
