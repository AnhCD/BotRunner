using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideToMovePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2[] setPath;
    public int currentPathIndex;
    public float speed;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, setPath[currentPathIndex], speed * Time.deltaTime);
        if (transform.position.x == setPath[currentPathIndex].x && transform.position.y == setPath[currentPathIndex].y)
        {
            currentPathIndex++;
            //reach the last location in the list, go back to the first
            if (currentPathIndex >= setPath.Length)
            {
                currentPathIndex = 0;
                speed = 2;
            }
            else{
                speed = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            speed = 5;
        }
    }

    // void OnCollisionExit2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Player")
    //     {
    //         speed = 0;
    //     }
    // }
}
