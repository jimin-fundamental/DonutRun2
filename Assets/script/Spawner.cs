using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject frypan;
    float TimeBetweenSpawn;
    float SpawnTime;

    void Update()
    {
        RandomTime();
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }

    }

    void Spawn()
    {
        Instantiate(frypan, transform.position, transform.rotation);
    }

    void RandomTime()
    {
        TimeBetweenSpawn = Random.Range(3, 7);
    }
}
