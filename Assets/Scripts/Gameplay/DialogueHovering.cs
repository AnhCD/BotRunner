using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHovering : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(true);
        }
    }

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         gameObject.SetActive(false);
    //     }
    // }
}
