using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Erase: MonoBehaviour
{
    [SerializeField] string scene;

    public void StartGame()
    {
        SceneManager.LoadScene(scene);
    }
}
