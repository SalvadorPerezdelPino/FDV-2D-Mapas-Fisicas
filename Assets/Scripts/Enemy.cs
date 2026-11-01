using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private Vector2 direction;
    public float speed = 1.0f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = player.transform.position - transform.position;
        rb.AddForce(direction.normalized * speed * Time.fixedTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("La mascota rabiosa ha atacado! Pierdes puntos!");
        }
    }
}
