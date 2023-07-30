using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    public int AnimalIndex;
    public float SpawnRangeX = 20;
    public float SpawnPosZ = 20;
    public float StartDelay = 2;
    public float SpawnInterval = 2.0f;


    void Start()
    {
        //Repeatatively call the RandomSpawnAnimals after interval
        InvokeRepeating("RandomSpawnAnimals",StartDelay,SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    //RandomlySpawnAnimals
    void RandomSpawnAnimals()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        AnimalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[AnimalIndex], SpawnPos, animalPrefabs[AnimalIndex].transform.rotation);
    }
}
