using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class KeyboardManager : MonoBehaviour
{
    [SerializeField] TMP_Text InputShowText;
    List<string> inputText = new List<string>();
    CRUDToJsonManager cRUDToJsonManager;
    string resultText;
    ScoreBoardManager scoreBoardManager;
    [SerializeField] GameObject KeyboardGameObJect;
    bool isKBActive = false;
    void Start()
   {
        cRUDToJsonManager = FindObjectOfType<CRUDToJsonManager>();
        scoreBoardManager = FindObjectOfType<ScoreBoardManager>();
        Keybuttons.OnAnykeyButton += KeybuttonsOnAnyKeyButton;

   }
   IEnumerator waitasecond()
   {
    yield return new WaitForSeconds(2);
   }

   public void ToggleActive()
   {
        if (!isKBActive)
        {
            isKBActive = true;
            KeyboardGameObJect.SetActive(isKBActive);
        }
        else
        {
            isKBActive = false;
            KeyboardGameObJect.SetActive(isKBActive);
        }
   }
   public void BacktoMenu()
   {
        SceneManager.LoadScene("MainScene");
   }

    private void KeybuttonsOnAnyKeyButton(object sender, Keybuttons.OnAnykeyButtonArgs e)
    {
        if(e.KeyValue == "Backspace")
        {
            if (inputText.Count != 0)
            {
                inputText.RemoveAt(inputText.Count-1);
            }
        }
        else if (e.KeyValue == "Spacebar")
        {
            inputText.Add(" ");
        }
        else if (e.KeyValue == "Enter")
        {
            SaveToJson();
            StartCoroutine(waitasecond());
            scoreBoardManager.CreateitemListFromJson();
            ToggleActive();
        }
        else
        {
            inputText.Add(e.KeyValue);
        }
        
        resultText = string.Join("",inputText);
        InputShowText.text = resultText;
    }
    void SaveToJson()
    {
        cRUDToJsonManager.SaveToJson(resultText, Score.totalscore);
    }
}
