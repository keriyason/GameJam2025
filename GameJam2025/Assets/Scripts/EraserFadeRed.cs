using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserFadeRed : MonoBehaviour
{
    public float fadeDuration = 2f;
    private SpriteRenderer sr;
    private bool playerTouched = false;
    private bool isFading = false;
    private EraserManager progressManager;


    private bool pressedA = false;
    private bool pressedD = false;
   

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        progressManager = FindObjectOfType<EraserManager>();
        progressManager?.RegisterErasable();

    }

    void Update()
    {
        if (!playerTouched || isFading) return;

        // Check for required key presses with logs
        if (Input.GetKeyDown(KeyCode.A))
        {
            pressedA = true;
            Debug.Log("Input detected: A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pressedD = true;
            Debug.Log("Input detected: D");
        }
        if (pressedA && pressedD)
        {
            Debug.Log("All required inputs received. Starting fade...");
            StartCoroutine(FadeOut());
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !playerTouched)
        {
            Debug.Log("Player touched sprite — waiting for input.");
            playerTouched = true;
        }
    }

    private IEnumerator FadeOut()
    {
        Debug.Log("Fade coroutine started.");
        isFading = true;
        float elapsed = 0f;
        Color originalColor = sr.color;

        while (elapsed < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            sr.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            Debug.Log($"Fading... alpha: {alpha:F2}");
            elapsed += Time.deltaTime;
            yield return null;
        }

        sr.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
        Debug.Log("Fade complete. Destroying object.");
        progressManager?.ReportErased();
        Destroy(gameObject);
    }
}