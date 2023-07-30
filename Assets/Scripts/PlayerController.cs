using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float VerticalInput;
    public float Speed = 10.0f;
    public float xRange = 20.0f;
    public float zRange = 5.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Player should never leave the screen at the left side of the screen
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Player should never leave the screen at the right side of the screen
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //////////////////////////////////////////////////////////////////       
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        //Player should never leave the screen at the top side of the screen
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }




        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Lauch the Projectile of the Pizza
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);

        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * Speed);


        //transform.position = new Vector3(transform.position.x,transform.position.y,10f);
    }
}
