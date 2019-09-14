using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private GameManager gm;
    public SpriteRenderer graphics;
    private float fallingSpeed = 150;
    private TrashType type;

    public enum TrashType
    {
        PLASTIC,
        PAPER,
        GLASS,
        ORGANIC,
        NON_RECYCLABLE,
        METAL,
        AGD,
        BATTERY,
        CUP,
        NULL
    }

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        
        graphics.sprite = gm.getTrashSprite(Random.Range(0, 4));
    }
    
    void Update()
    {
        Vector3 fallingDireciton = new Vector3(0, -1, 0);

        transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 100);
    }

    
}
