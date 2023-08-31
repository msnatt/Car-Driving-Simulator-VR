using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class UICompleted : MonoBehaviour
{
    public GameObject CompletedUI;
    public GameObject CheckpointUI;
    public GameObject FontPanel;
    public GameObject BackPanel;
    public TMP_Text TimeText;
    [SerializeField] private GameObject NextButtons;
    [HideInInspector] public float CountTimeinCompleted;
    [HideInInspector] public bool isUIcompletedActive;
    [HideInInspector] public float currenttimeUI = 0;
    CheckCompleted checkCompleted;
    RectTransform rectTransfrom;
    [SerializeField] GameObject UITimerCanvas;
    public GameObject vehicle;
    ScoreManager scoremanager;
    [SerializeField] TMP_Text scorelevelText;
    

    void Start()
    {

        scoremanager = FindObjectOfType<ScoreManager>();

        checkCompleted = CheckCompleted.Instance;
        rectTransfrom = CheckpointUI.GetComponent<RectTransform>();

        TimeText.fontSize = 100;
        isUIcompletedActive = false;
        checkCompleted.GOUIcanActive = false;
        
    }
    void checkTimeinDestination()
    {
        if (checkCompleted.timerindestination > 0 )
        {
            
            NextButtons.SetActive(true);
            Debug.Log("Show UI Next");
        }
        else
        {
            NextButtons.SetActive(false);
            Debug.Log("Show UI please restart");
        }
    }
    void Update()
    {
        //rectTransfrom = CheckpointUI.GetComponent<RectTransform>();
        CountTimeinCompleted -= 1;

        if (checkCompleted.GOUIcanActive && checkCompleted.checkdetectF && checkCompleted.checkdetectB && !isUIcompletedActive)
        {
            isUIcompletedActive = true;
            CompletedUI.SetActive(true);
            UITimerCanvas.GetComponent<Timer>().TimeActive = false;
            vehicle.GetComponent<VehicleControl>().activeControl = false;
            CountTimeinCompleted = 120;
            checkTimeinDestination();
            Debug.Log("Show UI");
        }
        
        

        if (TimeText.fontSize > 50 && isUIcompletedActive && CountTimeinCompleted <= 0)
        {
            //TimeText.text = Math.Round(UITimerCanvas.GetComponent<Timer>().CurrentTime,1).ToString();
            TimeText.fontSize = TimeText.fontSize - 0.75f;
        }
        else if (TimeText.fontSize > 50 && isUIcompletedActive && CountTimeinCompleted > 100)
        {
            TimeText.text = Math.Round(UnityEngine.Random.Range(0f,10f),0).ToString();
        }
        else if (TimeText.fontSize > 50 && isUIcompletedActive && CountTimeinCompleted <= 750)
        {
            TimeText.text = Math.Round(UITimerCanvas.GetComponent<Timer>().CurrentTime,1).ToString();
        }
        else
        {
            scorelevelText.text = scoremanager.Getlevelscore().ToString();
        }

        if (rectTransfrom.localPosition.y < 1.40f)
        {
            CheckpointUI.GetComponent<RectTransform>().localPosition = new Vector3(rectTransfrom.localPosition.x, rectTransfrom.localPosition.y + 0.001f, rectTransfrom.localPosition.z);
        }


        if (checkCompleted.checkdetectF)
        {
            FontPanel.GetComponent<Image>().color = Color.green;
        }
        else
        {
            FontPanel.GetComponent<Image>().color = Color.red;
        }
        if (checkCompleted.checkdetectB)
        {
            BackPanel.GetComponent<Image>().color = Color.green;
        }
        else
        {
            BackPanel.GetComponent<Image>().color = Color.red;
        }
    }

}
