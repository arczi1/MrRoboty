using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Sprites")]
    public Sprite[] binSprites;
    public Sprite[] trashSprites;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite getBinSprite(int index)
    {
        return binSprites[index];
    }

    public Sprite getTrashSprite(int index)
    {
        return trashSprites[index];
    }
}
