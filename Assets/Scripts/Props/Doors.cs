using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    private Movement player;
    public SpriteRenderer SR;
    public Sprite doorOpen;

    public bool doorOpened, waitingToOpen;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitingToOpen)
        {
            if(Vector3.Distance(player.followingKey.transform.position, transform.position) < .1f)
            {
                waitingToOpen = false;

                doorOpened = true;

                SR.sprite = doorOpen;

                player.followingKey.gameObject.SetActive(false);
                player.followingKey = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(player.followingKey != null)
            {
                player.followingKey.followTarget = transform;
            }
        }
    }
}
