using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int totalLogs = 7; // จำนวนไม้ทั้งหมด
    private int logsFell = 0; // นับจำนวนไม้ที่ตกแล้ว

    public GameObject gameOverUI; // ตัวแปรเก็บ UI

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void LogFell()
    {
        logsFell++; 

        if (logsFell >= totalLogs) // ถ้าไม้ทั้งหมดตก
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverUI.SetActive(true); // แสดง UI จบเกม
        Time.timeScale = 0f;
    }

    public void RestartGame() // ฟังก์ชัน Restart
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");

    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");

    }
}
