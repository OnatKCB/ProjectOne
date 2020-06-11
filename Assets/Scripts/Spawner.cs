using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnDelay = 5000f;
    public GameObject[] selectedObject;
    private float nextTimeToSpawn;
    int randomInt;
    public Transform spawnPos;

    void SpawnRandom() 
    {
        randomInt = Random.Range(0, selectedObject.Length);
        Instantiate(selectedObject[randomInt], spawnPos.position, spawnPos.rotation);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (nextTimeToSpawn <= Time.time)
        {
            SpawnRandom();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }
}
