using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    public GameManager gameManager;
    public SpriteRenderer graphics;
    private static int binCounter = 0;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        string type = gameManager.consideredTypes[binCounter];
        setTag(type);
        graphics.sprite = gameManager.getBinSprite(type);
        binCounter++;

    }

    private void setTag(string type)
    {
        tag = type;
    } 
}
