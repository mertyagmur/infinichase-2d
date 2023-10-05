using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] itemPrefabs;
    public int fuelCounter;
    public int healthCounter;

    void Start(){
        
        for (int i = 0; i <= 4; i++){
            int randItem = Random.Range(0, itemPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(itemPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            fuelCounter += 1;
        }    
        for (int i = 0; i <= 4; i++){
            int randItem = Random.Range(0, itemPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(itemPrefabs[1], spawnPoints[randSpawnPoint].position, transform.rotation);
            healthCounter += 1;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if (fuelCounter < 5) {
            int randItem = Random.Range(0, itemPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(itemPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            fuelCounter += 1;
        }

        if (healthCounter < 5) {
            int randItem = Random.Range(0, itemPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(itemPrefabs[1], spawnPoints[randSpawnPoint].position, transform.rotation);
            fuelCounter += 1;
        }
    }
}
