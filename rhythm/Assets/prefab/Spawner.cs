using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1f;

    public GameObject notesPrefab;

    private float nextTimeToSpawn = 0f;




    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(notesPrefab, Vector3.up * 5, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
