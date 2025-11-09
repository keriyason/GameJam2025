using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class ImageTransitions : MonoBehaviour
{
    [SerializeField] private GameObject scene2;
    [SerializeField] private GameObject scene3;
    [SerializeField] private GameObject scene4;
    [SerializeField] private GameObject scene5;

    float delayTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(DelayCoroutine(delayTime));
        //delay
        Invoke("CustSetActive", 5f);

        StartCoroutine(DelayCoroutine(delayTime));
        //delay
        scene3.SetActive(true);

        StartCoroutine(DelayCoroutine(delayTime));
        //delay
        scene4.SetActive(true);

        StartCoroutine(DelayCoroutine(delayTime));
        //delay
        scene5.SetActive(true);
    }
    IEnumerator DelayCoroutine(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void CustSetActive(GameObject scene)
    {
        scene.SetActive(true);
    }
}
