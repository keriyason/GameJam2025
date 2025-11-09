using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S1: MonoBehaviour
{
    public string nextSceneName = "S2"; // Change to your actual scene name

    void Start()
    {
        // Start the delayed transition
        Invoke("LoadNextScene", 4f);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("S2");
    }
}
