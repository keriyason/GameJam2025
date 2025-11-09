using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public GameObject highlighterPrefab;
    public Transform spawnPoint;
    public float spawnInterval;

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

}
