using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerbound = -10f;

    public GameObject Player;
    public GameObject[] AnimalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //If an  object  goes past the Player View, remove that gameobject
    //       if (transform.position.z > topBound)
    //       {
    //           Destroy(gameObject);
    //       }else if (transform.position.z < lowerbound)
    //       {
    //           Debug.Log("Game Over !");
    //           Destroy(gameObject);
    //       }
    //   }


    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Game Over"); 
        Destroy(Player);

    }

}
