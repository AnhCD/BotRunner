using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform1 : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 startPos;

    public bool respawns = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.isKinematic = false;
        }
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
