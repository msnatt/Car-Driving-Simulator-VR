using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool TimeActive = false;
    public float StartTime;
    public float CurrentTime;
    protected float countTime;
    protected float countStartTime;
    public TMP_Text textMashProUI;
    public TMP_Text textStartMashProUI;
    public bool isGameOver = false;
    void Start()
    {
        TimeActive = true;
        countTime = StartTime + 7;
        CurrentTime = -7;
    }


    void Update()
    {
        if (TimeActive)
        {
            CurrentTime += Time.deltaTime;
            countTime -= Time.deltaTime;
        }
        if (countTime > StartTime)
        {   
            textStartMashProUI.gameObject.SetActive(true);
            textStartMashProUI.text = "Will Start in";
            textMashProUI.text = Math.Round(countTime - StartTime,0).ToString();
        }

        if (countTime <= 30.0 && countTime >= 29.9)
        {
            textMashProUI.color = Color.red;
        }
        if (countTime <= 0 && !isGameOver)
        {
            textMashProUI.text = "Time Out";
            textMashProUI.color = Color.white;
            isGameOver = true;
            
        }
        if (countTime > 0 && countTime < StartTime)
        {
            textStartMashProUI.gameObject.SetActive(false);
            TimeSpan time = TimeSpan.FromSeconds(countTime);
            textMashProUI.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
            
        }

    }
}
