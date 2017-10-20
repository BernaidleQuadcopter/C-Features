using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);

    }
    void Spawn()
    {
        //Randomize position
        Vector3 rand = Random.insideUnitSphere * spawnRadius;
        rand.z = 0;
        Vector3 position = transform.position + rand;
        int randomIndex = Random.Range(0, asteroidPrefabs.Length);
        GameObject randAsteroid = asteroidPrefabs[randomIndex];
        GameObject clone = Instantiate(randAsteroid);
        clone.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
