using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EraserManager : MonoBehaviour
{
    public Slider progressSlider; //Slider Attachment
    public int totalErasables = 25; //Total of Erased
    private int erasedCount = 0;
    public string winSceneName = "WinScene"; //Win Scene Transition

    void Start()
    {
        progressSlider.minValue = 0f;
        progressSlider.maxValue = 1f;
        progressSlider.value = 0f;
    }

    public void RegisterErasable()
    {
        totalErasables++;
    }

    public void ReportErased()
    {
        erasedCount++;
        float progress = (float)erasedCount / totalErasables;
        progressSlider.value = progress;
        Debug.Log($"Erased {erasedCount}/{totalErasables} — {progress * 100f:F1}%");

        if (erasedCount >= totalErasables)
        {
            Debug.Log("All items erased. Loading win scene...");
            SceneManager.LoadScene("WinScene");
        }

    }
}

