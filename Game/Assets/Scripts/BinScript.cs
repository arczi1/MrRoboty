using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    public GameManager gameManager;
    private static int binCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        setTag(gameManager.consideredTypes[binCounter]);
        binCounter++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setTag(string type)
    {
        tag = type;
    } 
}
