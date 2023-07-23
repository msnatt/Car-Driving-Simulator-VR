using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOnFont : MonoBehaviour
{
    CheckCompleted checkcompleted;
    void Start()
    {
        checkcompleted = CheckCompleted.Instance;
        checkcompleted.iscompleted = false;
        checkcompleted.checkdetectF = false;
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("DetectF"))
        {
            Debug.Log("Detect On Font");
            checkcompleted.checkdetectF = true;
        }
    }
}
