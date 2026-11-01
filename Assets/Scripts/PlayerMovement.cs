using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Declarar la velocidad de tipo float
    public float speed = 1.0f;
   
    // Declarar la variable que representará al SpriteRenderer para controlar el 'flip'
    public SpriteRenderer spriteRenderer;

    public InputActionReference moveAction;

    private Vector2 direction;


    void Start()
    {
        moveAction.action.Enable();
    }

    void Update()
    {

        direction = moveAction.action.ReadValue<Vector2>();
        transform.Translate(direction.normalized * speed * Time.deltaTime);
       
        if (direction.x > 0)
        {
            spriteRenderer.flipX = false;
        } 
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        
    }
}
