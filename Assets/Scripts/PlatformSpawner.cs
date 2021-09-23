using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject normalPlatform;
    public GameObject spikePlatform;
    public GameObject landToDisappearPlatform;

    public float platformSpawnTimer = 2f;
    private float currentPlatformSpawnTimer;
    private int platformSpawnCount;
    public float minX = -2f, maxX = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        currentPlatformSpawnTimer = platformSpawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatform();
    }

    void SpawnPlatform()
    {
        currentPlatformSpawnTimer += Time.deltaTime;
    }
}
