using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to a 3D object with the tag "Sprite"
        if (other.attachedRigidbody != null && other.attachedRigidbody.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Delete this 2D sprite GameObject
            Debug.Log($"{gameObject.name} was deleted after collision with a 3D object tagged 'Sprite'");
        }
    }
}

