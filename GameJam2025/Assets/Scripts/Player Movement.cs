using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;


    void FixedUpdate()
    {

        //get key W A S D

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 3, -3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, -3, 3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, -3, -3);
            rb.AddForce(-transform.right * speed, ForceMode.Impulse);
        }
        


    }



}
