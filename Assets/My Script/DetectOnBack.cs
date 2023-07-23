using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOnBack : MonoBehaviour
{
    CheckCompleted checkcompleted;
    void Start()
    {
        checkcompleted = CheckCompleted.Instance;
        checkcompleted.iscompleted = false;
        checkcompleted.checkdetectB = false;
    }

    private void OnTriggerEnter(Collider other)
    {    
        if (other.CompareTag("DetectB"))
        {
            Debug.Log("Detect On Back");
            checkcompleted.checkdetectB = true;
        }
        
    }
}
