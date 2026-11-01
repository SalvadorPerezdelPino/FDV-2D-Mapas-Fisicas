using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementPhysics : MonoBehaviour
{
    // Declarar la velocidad de tipo float
    public float speed = 1.0f;
   
    // Declarar la variable que representará al SpriteRenderer para controlar el 'flip'
    public SpriteRenderer spriteRenderer;

    public InputActionReference moveAction;
    public Rigidbody2D rb;

    private Vector2 direction;


    void Start()
    {
        moveAction.action.Enable();
    }

    void FixedUpdate()
    {

        direction = moveAction.action.ReadValue<Vector2>();
        
        rb.AddForce(direction.normalized * speed * Time.fixedTime, ForceMode2D.Force);
       
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
