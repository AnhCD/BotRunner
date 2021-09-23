using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandToDisappearPlatform : MonoBehaviour
{
    private Rigidbody2D RB;
    public float timeToDisappear = 1;
    public float currentTime;
    public bool isCountdowning;

    void Start()
    {
        
        RB = GetComponent<Rigidbody2D>();
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (timeToDisappear > 0)
        {
            timeToDisappear -= Time.deltaTime;
        }
        else
        {
            timeToDisappear = 0;
            isCountdowning = false;
            if (collision.gameObject.tag == "Player")
            {
                gameObject.SetActive(false);
            }
        }
        
    }
}
