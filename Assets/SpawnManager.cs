using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] platformPrefabs;

    private float startDelay = 0f;
    private float spawnInterval = 1.325f;

    private float spawnPosZ = 27f;

    void Start()
    {
    
        InvokeRepeating("SpawnPlatforms", startDelay, spawnInterval);

    }
    

    void SpawnPlatforms()
    {
    
        int platformIndex = Random.Range(0, platformPrefabs.Length);

        Vector3 spawnPos = new Vector3(0, 0, spawnPosZ);
        Instantiate(platformPrefabs[platformIndex], spawnPos, platformPrefabs[platformIndex].transform.rotation);

    }

}
