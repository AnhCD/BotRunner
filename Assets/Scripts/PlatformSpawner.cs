using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject normalPlatform;
    public GameObject spikePlatform;
    // public GameObject[] scrollingPlatform;
    public GameObject landToDisappearPlatform;

    public float platformSpawnTimer = 1.8f;
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
        if(currentPlatformSpawnTimer >= platformSpawnTimer)
        {
            platformSpawnCount++;

            Vector3 temp = transform.position;
            temp.x = Random.Range(minX, maxX);

            GameObject newPlatform = null;

            if (platformSpawnCount < 2)
            {
                newPlatform = Instantiate(normalPlatform, temp, Quaternion.identity);
            }
            // else if (platformSpawnCount == 2)
            // {
            //     if (Random.Range(0, 2) > 0)
            //     {
            //         newPlatform = Instantiate(normalPlatform, temp, Quaternion.identity);
            //     }
            //     else
            //     {
            //         newPlatform = Instantiate(
            //             scrollingPlatform[Random.Range(0, scrollingPlatform.Length)],
            //             temp, 
            //             Quaternion.identity);
            //     }
            // }
            else if (platformSpawnCount == 2)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(normalPlatform, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(
                        spikePlatform,
                        temp, 
                        Quaternion.identity);
                }
            }
            else if (platformSpawnCount == 3)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(normalPlatform, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(
                        landToDisappearPlatform,
                        temp, 
                        Quaternion.identity);
                }
                platformSpawnCount = 0;
            }

            newPlatform.transform.parent = transform;
            currentPlatformSpawnTimer = 0f;
        } // spawn platform
    }
}
