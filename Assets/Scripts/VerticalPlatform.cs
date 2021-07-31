using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitTime;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            waitTime = 0f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            if(waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = 0f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        if (Input.GetButton("Jump"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
