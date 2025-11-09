using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class ImageTransitions : MonoBehaviour
{
    /*
    [SerializeField] private GameObject scene2;
    [SerializeField] private GameObject scene3;
    [SerializeField] private GameObject scene4;
    [SerializeField] private GameObject scene5;
    */
    [SerializeField] private List<GameObject> scenes;

    GameObject currentscene;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        currentscene = scenes[index];

        //StartCoroutine(DelayScene(delayTime));
        //delay
        InvokeRepeating("S2SetActive", 5f, 4);
        //scene2.SetActive(true);

        //StartCoroutine(DelayScene(delayTime));
        //delay
        //scene3.SetActive(true);

        //StartCoroutine(DelayScene(delayTime));
        //delay
        //scene4.SetActive(true);

        //StartCoroutine(DelayScene(delayTime));
        //delay
        //scene5.SetActive(true);
    }
    /*
    IEnumerator DelayScene(float delayTime)
    {
        Debug.Log("starting timer");
        yield return new WaitForSeconds(delayTime);
        Debug.Log("finished");

    }
    */
    // Update is called once per frame
    void Update()
    {
        if (currentscene.activeInHierarchy && index < scenes.Count - 1)
        {
            index++;
            currentscene = scenes[index];
        }
    }
    
    void S2SetActive()
    {
        currentscene.SetActive(true);
    }
}
