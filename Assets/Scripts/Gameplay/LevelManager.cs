using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float respawnDelay; // Respawn delay
    public Gem gem;
    // Start is called before the first frame update
    void Start()
    {
        gem = FindObjectOfType<Gem>();//Looks in Script for PlayerController
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Respawn()
    {
        StartCoroutine(RespawnCoroutine()); //Respawn
    }
    public IEnumerator RespawnCoroutine()
    {
        gem.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay); //yield return new WaitForSeconds(3); 
        gem.transform.position = gem.respawnPoint;  //Respawn
        gem.gameObject.SetActive(true);
    }
}
