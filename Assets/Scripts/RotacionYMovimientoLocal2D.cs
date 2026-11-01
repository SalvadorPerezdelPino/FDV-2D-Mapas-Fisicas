using UnityEngine;
using UnityEngine.InputSystem;

public class RotacionYMovimientoLocal2D : MonoBehaviour
{
    // Variables ajustables en el Inspector
    // Velocidad de traslación hacia adelante
    // Velocidad de rotación (grados por segundo)
    public float moveSpeed = 1.0f;
    public float rotationSpeed = 1.0f;
    public SpriteRenderer spriteRenderer;
    public InputActionReference moveAction;
    public InputActionReference rotateAction;
    private Vector2 moveDirection;
    private float rotateDirection;


    void Start()
    {
        moveAction.action.Enable();
        rotateAction.action.Enable();
    }

    void Update()
    {
        rotateDirection = rotateAction.action.ReadValue<float>();
        transform.Rotate(0, 0, rotateDirection * rotationSpeed * Time.deltaTime);
        
        moveDirection = new Vector2(moveAction.action.ReadValue<float>(), 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);

        if (moveDirection.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveDirection.x < 0)
        {
            spriteRenderer.flipX = true;
        }

    }
}
