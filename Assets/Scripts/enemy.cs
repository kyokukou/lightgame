using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float speed = 5.0f;
    private Rigidbody2D RB;
    private Vector2 movement;
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
       
    }
    private void FixedUpdate()
    {
        chase(movement);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BULLET")
        {
            Destroy(gameObject);
            print("TRUE");
        }

    }
    private void chase(Vector2 direction)
    {
        RB.MovePosition((Vector2)transform.position + (movement * speed * Time.deltaTime));
    }
}
