using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPositionZ = 22;
    private float spawnRangeX = 20;
    private float spawnPositionXLeft = -27;
    private float spawnPositionXRight = 27;
    private float spawnBoundZ = 15.0f;

    private float startDelay = 2;
    private float spawnInterval = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimalTop() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoint = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], spawnPoint, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnAnimalLeft()
    {
        Vector3 spawnRotation = new Vector3(0, -90, 0);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoint = new Vector3(spawnPositionXLeft, 0, Random.Range(0, spawnBoundZ));
        Instantiate(animalPrefabs[animalIndex], spawnPoint, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(spawnRotation));
    }

    void SpawnAnimalRight()
    {
        Vector3 spawnRotation = new Vector3(0, 90, 0);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoint = new Vector3(spawnPositionXRight, 0, Random.Range(0, spawnBoundZ));
        Instantiate(animalPrefabs[animalIndex], spawnPoint, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(spawnRotation));
    }
}
