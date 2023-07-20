using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public  float Speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //It moves a GameObject forward or 1 unity * 1sec * Speed
        transform.Translate(Vector3.forward*Time.deltaTime*Speed);
    }
}
