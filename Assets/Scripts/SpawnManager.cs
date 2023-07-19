using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    public int AnimalIndex;
    private float SpawnRangeX = 20;
    private float SpawnPosZ = 20;
    private float StartDelay = 2;
    private float SpawnInterval = 1.5f;


    void Start()
    {
        InvokeRepeating("RandomSpawnAnimals",StartDelay,SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void RandomSpawnAnimals()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        AnimalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[AnimalIndex], SpawnPos, animalPrefabs[AnimalIndex].transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
