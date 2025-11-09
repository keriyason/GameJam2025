using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    
    public GameObject highlighterPrefab;
    public Transform spawnPoint;
    public float spawnInterval;

    private int spawnCount = 0;
    private const int maxSpawns = 3;

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
        InvokeRepeating("SpawnHighlighter", 30f, 3);
    }

    void SpawnHighlighter()
    {
        if (spawnCount >= maxSpawns)
        {
            CancelInvoke("SpawnHighlighter");
            return;
        }

        Instantiate(highlighterPrefab, spawnPoint.position, Quaternion.identity);
        
    }
}
