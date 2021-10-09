using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandToDisappearPlatform : MonoBehaviour
{
    private Rigidbody2D RB;
    Vector2 startPos;
    public bool respawn = true;

    void Start()
    {
        
        RB = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
        
    }
}
