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
}
