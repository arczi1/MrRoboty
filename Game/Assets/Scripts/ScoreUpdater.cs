using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreUpdater : MonoBehaviour
{
    public static Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    public static void setPoints(int score)
    {
        
        scoreText.text = "Score : " + score.ToString();
    }

}
