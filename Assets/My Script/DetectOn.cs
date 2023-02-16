using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOn : MonoBehaviour
{
    CheckCompleted checkcompleted;
    void Start()
    {
        checkcompleted = CheckCompleted.Instance;
        Debug.Log("================ Detect On ==================");
        checkcompleted.iscompleted = false;
        checkcompleted.checkdetectF = false;
        checkcompleted.checkdetectB = false;
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("DetectF"))
        {
            Debug.Log("Detect On Font");
            checkcompleted.checkdetectF = true;
        }
        else if (other.CompareTag("DetectB"))
        {
            Debug.Log("Detect On Back");
            checkcompleted.checkdetectB = true;
        }
        
    }
}
