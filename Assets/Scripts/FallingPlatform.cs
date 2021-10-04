using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D rb;

    Vector2 startPos;
    public bool respawns = true;
    public float spawnDelay = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Player"))
        {
            Invoke("Fall", spawnDelay);
        }
    }
    void Fall()
    {
        rb.isKinematic = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "FallDetector" && respawns)
        {
            rb.isKinematic = true;
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = startPos;
        }
    }
}
