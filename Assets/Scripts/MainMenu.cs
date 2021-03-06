using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string playGameLevel;
    public string questionLevel;
    public string recordsLevel;

    public void PlayGame()
    {
        SceneManager.LoadScene(playGameLevel);
    }

    public void OpenRecords()
    {
        SceneManager.LoadScene(recordsLevel);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(questionLevel);
    }
}
