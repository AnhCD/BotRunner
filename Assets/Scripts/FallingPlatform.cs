using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D RB;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Player"))
        {
            Invoke("Fall", 1f);
            Destroy(gameObject, 2f);
        }
    }
    void Fall()
    {
        RB.isKinematic = false;
    }
}
