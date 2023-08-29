using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStatic : MonoBehaviour
{
    void Awake()
    {
        Keybuttons.resetstaticEvent();
        Score.totalscore = 0;
    }
}
