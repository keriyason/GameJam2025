using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // 3D collision uses Collider, not Collider2D
    {
        Debug.Log($"Trigger entered by: {other.name} with tag: {other.tag}");

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected — destroying sprite.");
            Destroy(gameObject); // Deletes this sprite GameObject
        }
    }
}
