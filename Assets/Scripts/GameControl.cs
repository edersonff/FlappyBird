using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public GameObject startCanvas;
    public GameObject pauseCanvas;
    public GameObject gameoverCanvas;
    public static bool isGameOver = false;
    public static bool isStarted = false;
    public static bool isPaused = false;
    public static int score = 0;
    public static int highScore = 0;

    void Start()
    {
        LoadData();
    }

    public void Update()
    {
        if (isStarted)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    static public bool isRunning()
    {
        return isStarted && !isGameOver;
    }
    public void onPlay()
    {
        isStarted = true;

        startCanvas.SetActive(false);
    }
    public void onPause()
    {
        isPaused = true;

        pauseCanvas.SetActive(true);
    }
    public void onResume()
    {
        isPaused = false;

        pauseCanvas.SetActive(false);
    }
    public void onGameOver()
    {
        isGameOver = true;

        gameoverCanvas.SetActive(true);
    }

    public void onRestart()
    {
        SaveData();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SaveData()
    {
        if (score > highScore)
        {
            highScore = score;
        }

        isGameOver = false;
        isStarted = false;
        score = 0;

        PlayerPrefs.SetInt("highScore", highScore);
    }

    public void LoadData()
    {
        highScore = PlayerPrefs.GetInt("highScore");
    }
}
