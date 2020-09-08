using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MEnambahkan komponen Rigidbody2D dan BoxCOllider2D
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Destroyer : MonoBehaviour
{
    // Memusnahkan object ketika bersentuhan
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
    }
}
