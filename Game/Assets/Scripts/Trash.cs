using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
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
    public Trash(TrashType type)
    {
        this.type = type;
    }
}
