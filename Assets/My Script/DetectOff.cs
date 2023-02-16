using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOff : MonoBehaviour
{
    CheckCompleted checkcompleted;
    void Start()
    {
        checkcompleted = CheckCompleted.Instance;
        Debug.Log("================ Detect Off ==================");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DetectF"))
        {
            Debug.Log("Detect Off Font");
            checkcompleted.checkdetectF = false;
        }
        else if (other.CompareTag("DetectB"))
        {
            Debug.Log("Detect Off Back");
            checkcompleted.checkdetectB = false;
        }
    }
}
