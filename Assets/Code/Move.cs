using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Autor: Jose Armando Gutierrez Rodriguez
 * Fecha: 03/10/2024
 * Prototype 2
 * **/

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -21 ) 
        {
            Destroy(gameObject);
        } else if(transform.position.x > 23)
        {
            Destroy(gameObject);
        } 

        transform.Translate(Vector3.forward*20*Time.deltaTime);
    }
}
