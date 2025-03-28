using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
