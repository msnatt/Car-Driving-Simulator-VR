using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CompletedLevel : MonoBehaviour
{
    public float currentlevel;
    void Start()
    {
        currentlevel = SceneManager.GetActiveScene().buildIndex;
    }
    
    public void nextlevel()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 4)
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
