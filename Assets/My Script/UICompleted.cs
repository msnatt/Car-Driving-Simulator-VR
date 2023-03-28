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
    [HideInInspector] public float CountTimeinCompleted;
    [HideInInspector] public bool isUIcompletedActive;
    [HideInInspector] public float currenttimeUI = 0;
    CheckCompleted checkCompleted;
    RectTransform rectTransfrom;
    [SerializeField] GameObject UITimerCanvas;
    Timer timer;
    public GameObject vehicle;

    void Start()
    {
        checkCompleted = CheckCompleted.Instance;

        rectTransfrom = CheckpointUI.GetComponent<RectTransform>();
        
        TimeText.fontSize = 100;

        isUIcompletedActive = false;

        checkCompleted.GOUIcanActive = false;
        
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
            CountTimeinCompleted = 300;
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
        else if (TimeText.fontSize > 50 && isUIcompletedActive && CountTimeinCompleted <= 100)
        {
            TimeText.text = Math.Round(UITimerCanvas.GetComponent<Timer>().CurrentTime,2).ToString();
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
