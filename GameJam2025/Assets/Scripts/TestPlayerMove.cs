using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMovement : MonoBehaviour

{
    public float speed;
    public Rigidbody rb;

    private KeyCode lastKeyPressed;

    public Transform p1targetObject;
    public Transform p2targetObject;

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
        if (lastKeyPressed == KeyCode.D && Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(0, 3, -3);
            //rb.AddForce(transform.right * speed, ForceMode.Impulse);
            transform.RotateAround(p1targetObject.position, Vector3.up, speed * Time.deltaTime);
        }
        else if (lastKeyPressed == KeyCode.A && Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0, -3, 3);
            //rb.AddForce(-transform.right * speed, ForceMode.Impulse);
            transform.RotateAround(p1targetObject.position, Vector3.down, speed * Time.deltaTime);
        }
        else if (lastKeyPressed == KeyCode.RightArrow && Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate(0, -3, -3);
            //rb.AddForce(transform.right * speed, ForceMode.Impulse);
            transform.RotateAround(p2targetObject.position, Vector3.up, speed * Time.deltaTime);
        }
        else if (lastKeyPressed == KeyCode.LeftArrow && Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(0, 3, 3);
            //rb.AddForce(-transform.right * speed, ForceMode.Impulse);
            transform.RotateAround(p2targetObject.position, Vector3.down, speed * Time.deltaTime);
        }
    }
}



