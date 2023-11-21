using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab = new GameObject[3];

    private float spawnRangeX = 20.0f;
    private float spawnPositionZ = 20.0f;
    private float spawnStartDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // Determine spawn position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        // Determine which animal to spawn
        int animalIndex = Random.Range(0, animalPrefab.Length);

        // Spawn animal when s key is pressed
        Instantiate(animalPrefab[animalIndex], spawnPosition, animalPrefab[animalIndex].transform.rotation);
    }
}