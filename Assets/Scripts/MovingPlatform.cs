using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector2[] setPath;
    public int currentPathIndex = 0;
    public float speed;

    void Start()
    {
        
    }

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
            }
        }
    }
}
