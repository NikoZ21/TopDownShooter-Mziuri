using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float spawnRateDefault = 3f;
    private float spawnRate = 0;

    void Update()
    {
        spawnRate -= Time.deltaTime;

        if(spawnRate <= 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            spawnRate = spawnRateDefault;
        }
    }
}
