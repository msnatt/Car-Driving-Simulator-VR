using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class PauseMenu : MonoBehaviour
{
    public GameObject wristUI;
    Timer timer;
    [SerializeField] GameObject UITimerGameObject;

    public bool activeWristUI = false;
    void Start()
    {
        DisplayWristUI();
        timer = UITimerGameObject.GetComponent<Timer>();
    }


    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            DisplayWristUI();
        }
    }
    public void DisplayWristUI()
    {
        if (activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;
            //Time.timeScale = 1;
            //timer.TimeActive = true;
        }
        else if (!activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
            //Time.timeScale = 0;
            //timer.TimeActive = false;
            
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
