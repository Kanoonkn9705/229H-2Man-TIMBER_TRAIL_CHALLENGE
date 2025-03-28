using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public GameObject gameWinUI;

    private void OnTriggerEnter(Collider other)
    {
        GameWin();
    }

    void GameWin()
    {
        gameWinUI.SetActive(true); // แสดง UI จบเกม
        Time.timeScale = 0f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;

    }
}
