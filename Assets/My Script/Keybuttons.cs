using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Keybuttons : MonoBehaviour
{   
    public static event EventHandler<OnAnykeyButtonArgs> OnAnykeyButton;
    
    public class OnAnykeyButtonArgs : EventArgs
    {
        public string KeyValue;
    }
    string keyValue;
    void Awake()
    {
        keyValue = gameObject.name;
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(()=>{
            OnAnykeyButton?.Invoke(this, new OnAnykeyButtonArgs{
                KeyValue = keyValue
            });
        });
    }

    public static void resetstaticEvent()
    {
        OnAnykeyButton = null;
    }
}
