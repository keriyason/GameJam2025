using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;

    void FixedUpdate()
    {
        // Handle movement input one direction at a time
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, -3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, -3, -3);
            rb.AddForce(-transform.right * speed, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 3, -3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
    }
}

