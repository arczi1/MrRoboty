using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score : 0";
    }

    void setPoints(int score)
    {
        scoreText.text = "Score : " + score.ToString();
    }

}
