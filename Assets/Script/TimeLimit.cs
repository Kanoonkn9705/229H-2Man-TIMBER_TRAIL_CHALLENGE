using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 200f;
    public Text countDownText;
    public GameObject gameOverUI;

    void Start()
    {
        Time.timeScale = 1f;
        currentTime = startingTime;        
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = "Remaining Time:" + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            GameOver();
        }
    }
    void GameOver()
    {
        gameOverUI.SetActive(true); // แสดง UI จบเกม
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;  // ตั้งค่าให้เกมกลับมาทำงานปกติ
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  // โหลดฉากปัจจุบันใหม่
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
