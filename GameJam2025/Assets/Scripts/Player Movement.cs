using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public float speed = 5f;
public Rigidbody rb;

private KeyCode lastKeyPressed;

void Update()
{
    // Track the most recent key press
    if (Input.GetKeyDown(KeyCode.D)) lastKeyPressed = KeyCode.D;
    else if (Input.GetKeyDown(KeyCode.A)) lastKeyPressed = KeyCode.A;
    else if (Input.GetKeyDown(KeyCode.RightArrow)) lastKeyPressed = KeyCode.RightArrow;
    else if (Input.GetKeyDown(KeyCode.LeftArrow)) lastKeyPressed = KeyCode.LeftArrow;
}

void FixedUpdate()
{
        if (lastKeyPressed==KeyCode.D && Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, -3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        else if (lastKeyPressed == KeyCode.A && Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 3);
            rb.AddForce(-transform.right * speed, ForceMode.Impulse);
        }
        else if (lastKeyPressed == KeyCode.RightArrow && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, -3, -3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        else if (lastKeyPressed == KeyCode.LeftArrow && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 3, 3);
            rb.AddForce(-transform.right * speed, ForceMode.Impulse);
        }
    }
}



