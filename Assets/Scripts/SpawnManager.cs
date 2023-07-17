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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        if (Input.GetKeyDown(KeyCode.S))
        {
            AnimalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[AnimalIndex], SpawnPos, animalPrefabs[AnimalIndex].transform.rotation);

        }

    }
}
