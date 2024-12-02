using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController
{

    private int score;
    public int Score
    {
        get { return score; }
    }

    public ScoreController()
    {
        score = 0;
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log(score);
    }
}
