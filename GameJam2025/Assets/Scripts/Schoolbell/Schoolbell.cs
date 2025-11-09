using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schoolbell : MonoBehaviour
{
    public float minAngle = -20f;
    public float maxAngle = 20f;
    public float speed = 50.0f; //speed of rocking motion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        float angle = Mathf.Lerp(minAngle, maxAngle, time);
        transform.rotation = Quaternion.Euler(angle, 0, 0);
    }
}
