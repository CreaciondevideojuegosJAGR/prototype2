using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/**
 * Autor: Jose Armando Gutierrez Rodriguez
 * Fecha: 03/10/2024
 * Prototype 2
 * **/

public class DetectaColicion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
