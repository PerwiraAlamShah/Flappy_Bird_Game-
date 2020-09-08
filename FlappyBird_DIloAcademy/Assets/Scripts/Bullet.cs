using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Global variable
    public float speed = 15f;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = transform.right * speed;
    }

    // Ketika Peluru mengenai Pipe
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
