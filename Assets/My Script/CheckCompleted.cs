using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCompleted : Singleton<CheckCompleted>
{
    [HideInInspector] public bool checkdetectF;
    [HideInInspector] public bool checkdetectB;
    [HideInInspector] public bool iscompleted;
    [HideInInspector] public bool GOUIcanActive;


    void Update()
    {
        Debug.Log($"      Font {checkdetectF}     ||     Back {checkdetectB}");

        if (checkdetectF && checkdetectB && !iscompleted)
        {
            iscompleted = true;
            StartCoroutine(WaitCheck());
        }
    }
    private IEnumerator WaitCheck()
    {
        yield return new WaitForSeconds(5f);
        if (checkdetectF && checkdetectB)
        {
            Debug.Log("Winner!!!!!!");
            GOUIcanActive = true;
        }
        else
        {
            iscompleted = false;
            
        } 
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.tag == "DetectF")
    //     {
    //         checkdetectF = true;
    //         Debug.Log($"Font = {checkdetectF}");
    //     }
    //     if( other.tag == "DetectB")
    //     {
    //         checkdetectB = true;
    //         Debug.Log($"Back = {checkdetectB}");
    //     }
    // }
}
