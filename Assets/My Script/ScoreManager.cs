using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{   
    int oldscore=0;
    void Start()
    {
        oldscore = Score.totalscore;
    }

    public void savescore(int scoreAt)
    {
        Debug.Log("+"+scoreAt);
        Score.totalscore += scoreAt;
    }
    public void restartscore()
    {
        Score.totalscore = oldscore;
    }
    public int Getlevelscore()
    {
        return Score.totalscore-oldscore;
    }
    void Update()
    {
        Debug.Log("Now : "+Score.totalscore);
    }
}

