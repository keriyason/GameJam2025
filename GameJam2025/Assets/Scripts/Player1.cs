using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, -3);
            rb.AddForce(transform.right * speed, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 3);
            rb.AddForce(-transform.right * speed, ForceMode.Impulse);
        }
        
    }
}
