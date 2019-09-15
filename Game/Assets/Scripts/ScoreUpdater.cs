using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreUpdater : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void setPoints(int score)
    {
        scoreText.text = "Score : " + score.ToString();
    }

}
