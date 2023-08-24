using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Score
{
    public void savescore(int scoreAt)
    {
        Debug.Log("+"+scoreAt);
        totalscore = totalscore + scoreAt;
        showscore();
    }
}

