using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite disable;
    public bool isRespawned;
    public Vector3 respawnPoint;
    public LevelManager gameLevelManager;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        respawnPoint = transform.position;
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            gameLevelManager.Respawn();
        }
        
    }
}
