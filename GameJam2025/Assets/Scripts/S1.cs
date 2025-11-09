using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Erase: MonoBehaviour
{
    public string StartingScene = "SampleScene";

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
