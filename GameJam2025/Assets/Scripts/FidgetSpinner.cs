using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidgetSpinner : MonoBehaviour
{
    public float rotationSpeed = 70f;
    public Vector3 rotationAxis =Vector3.up; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }

    /*public float rotationSpeed = 50f; // Adjust this value in the Inspector to control speed
    public Vector3 rotationAxis = Vector3.up; // Choose the axis to rotate around (e.g., Vector3.right, Vector3.forward)

    void Update()
    {
        // Rotate the object around the specified axis at a given speed
        // Time.deltaTime ensures consistent rotation speed across different frame rates
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }*/
}
