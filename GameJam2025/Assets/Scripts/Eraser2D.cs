using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Eraser2D : MonoBehaviour
{ 
 private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        Debug.Log("Player triggered 2D sprite — destroying it.");
        Destroy(gameObject);
    }
}
}
