using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject main;       // Het object dat je wilt spawnen
    public float spawnInterval1 = 5f;       // Interval tussen spawns
    private float lastSpawnTime1;           // Tijd van de laatste spawn

    public float spawnInterval2 = 15f;       // Interval tussen spawns
    private float lastSpawnTime2;           // Tijd van de laatste spawn
    public GameObject giant;       // Het object dat je wilt spawnen

    void Update()
    {
        if (Time.time >= lastSpawnTime1 + spawnInterval1)
        {
            SpawnObject1();
            lastSpawnTime1 = Time.time;
        }

        if (Time.time >= lastSpawnTime2 + spawnInterval2)
        {
            SpawnObject2();
            lastSpawnTime2 = Time.time;
        }
    }

    void SpawnObject1()
    {
        if (main != null)
        {
            Instantiate(main, transform.position, transform.rotation);
        }
        else
        {
            Debug.LogWarning("Object to spawn is not set.");
        }
    }

    void SpawnObject2()
    {
        if (giant != null)
        {
            Instantiate(giant, transform.position, transform.rotation);
        }
        else
        {
            Debug.LogWarning("Object to spawn is not set.");
        }
    }
}
