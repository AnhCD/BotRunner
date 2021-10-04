using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingPlatforms : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 startPos;
    public float scrollSpeed = 2f;
    public float boundY = 6f;

    public bool speedPlatformLeft, speedPlatformRight, isBreakable, isSpike, isPlatform;

    private Animator anim;

    void Awake()
    {
        if (isBreakable)
        {
            anim = GetComponent<Animator>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 temp = transform.position;
        temp.y += scrollSpeed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= boundY)
        {
            gameObject.SetActive(false);
        }
    }

    void BreakableDeactivate()
    {
        Invoke("DeactivateGameObject", .3f);
    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            if(isBreakable)
            {
                anim.Play("break");
            }
        }
    }

    // void OnCollisionStay2D(Collision2D target)
    // {
    //     if (target.gameObject.tag == "Player")
    //     {
    //         if (speedPlatformLeft)
    //         {
    //             target.gameObject.GetComponent<Movement>().PlatformScroll(-1f);
    //         }
    //         if (speedPlatformRight)
    //         {
    //             target.gameObject.GetComponent<Movement>().PlatformScroll(1f);
    //         }
    //     }
    // }
}
