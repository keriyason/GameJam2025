using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolBellScale : MonoBehaviour
{
    public float minScale = 0.8f;
    public float maxScale = 1.2f;
    public float scaleSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BreathingEffect());
    }


    IEnumerator BreathingEffect()
    {
        while (true)
        {
            // Scale up
            yield return StartCoroutine(ScaleToTarget(maxScale));
            // Scale down
            yield return StartCoroutine(ScaleToTarget(minScale));
        }
    }

    IEnumerator ScaleToTarget(float target)
    {
        Vector3 startScale = transform.localScale;
        Vector3 endScale = new Vector3(target, target, target);
        float timeElapsed = 0f;

        while (timeElapsed < 1f)
        {
            transform.localScale = Vector3.Lerp(startScale, endScale, timeElapsed);
            timeElapsed += Time.deltaTime * scaleSpeed;
            yield return null;
        }
        transform.localScale = endScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
