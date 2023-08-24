using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScore : MonoBehaviour 
{
    public ScoreManager scoremanager;

    [SerializeField] private int scoreAt = 10;
    [SerializeField] GameObject ggameObject;
    
    void Awake()
    {
        scoremanager = FindObjectOfType<ScoreManager>();
    }
    
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("In Tag Car");
            scoremanager.savescore(scoreAt);
            ggameObject.SetActive(false);
            
        }
    }
}

