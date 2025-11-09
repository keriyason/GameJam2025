using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S2 : MonoBehaviour
{
    public string StartingScene = "Starting Screen";

    public void StartingScreen()
    {
        SceneManager.LoadScene("Starting Screen");
    }
}
