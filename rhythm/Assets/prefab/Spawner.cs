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
        var values = new[] {-3, 0, 3 };
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(notesPrefab, new Vector3(values[Random.Range(0,3)], 5, 0), Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
