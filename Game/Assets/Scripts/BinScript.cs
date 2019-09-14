using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setTag(Trash.TrashType type)
    {
        switch(type)
        {
            case Trash.TrashType.PLASTIC:
                tag = "PlasticBin";
                break;
            case Trash.TrashType.PAPER:
                tag = "PaperBin";
                break;
            case Trash.TrashType.GLASS:
                tag = "GlassBin";
                break;
            case Trash.TrashType.ORGANIC:
                tag = "OrganicBin";
                break;
            case Trash.TrashType.NON_RECYCLABLE:
                tag = "Non-RecyclableBin";
                break;
            case Trash.TrashType.METAL:
                tag = "MetalBin";
                break;
            case Trash.TrashType.BATTERY:
                tag = "BatteryBin";
                break;
            case Trash.TrashType.CUP:
                tag = "CupBin";
                break;
            default:
                tag = "NullBin";
                break;
        }
    }
}
