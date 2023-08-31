using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CompletedLevel : MonoBehaviour
{
    public float currentlevel;
    ScoreManager scoremanager;
    Timer timer;
    void Start()
    {
        scoremanager = FindObjectOfType<ScoreManager>();
        currentlevel = SceneManager.GetActiveScene().buildIndex;
        timer = FindObjectOfType<Timer>();
    }
    
    public void nextlevel()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 5 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }
    public void restart()
    {
        scoremanager.restartscore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
