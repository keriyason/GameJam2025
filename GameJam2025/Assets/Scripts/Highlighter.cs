using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    
    [SerializeField] public GameObject highlighterPrefab;
    [SerializeField] public Transform spawnPoint;
    [SerializeField] private float spawnInterval;

    private int spawnCount;
    

    /*
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DropHighlighter());
    }


    IEnumerator DropHighlighter()
    {
        yield return new WaitForSeconds(spawnInterval);
        Instantiate(highlighterPrefab, spawnPoint.position, Quaternion.identity);
    }
    */

    private void Start()
    {
        spawnCount = 0;
        InvokeRepeating("SpawnHighlighter", spawnInterval, spawnInterval);
    }

    private void Update()
    {
        if (spawnCount == 3)
        {
            CancelInvoke();
        }
    }

    void SpawnHighlighter()
    {
        if(spawnPoint != null)
        {
            spawnCount++;

            Instantiate(highlighterPrefab, spawnPoint.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("bleh");
        }
        
    }
}
