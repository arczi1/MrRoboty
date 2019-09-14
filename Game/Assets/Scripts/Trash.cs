using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
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
    
    void Update()
    {
        Vector3 fallingDireciton = new Vector3(0, -1, 0);

        transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 100);
    }
}
