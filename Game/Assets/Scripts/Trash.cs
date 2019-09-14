using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private GameManager gm;
    private ScoreUpdater scoreUpdater;
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
    }

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        scoreUpdater = FindObjectOfType<ScoreUpdater>();

        graphics.sprite = gm.getTrashSprite(Random.Range(0, 4));
        type = (TrashType)Random.Range(0, 8);
    }
    
    void Update()
    {
        Vector3 fallingDireciton = new Vector3(0, -1, 0);

        transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 100);
    }

    void onCollisionEnter2D(Collider2D col)
    {
        switch (type)
        {
            case TrashType.PLASTIC:
                if (col.tag == "PlasticBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.PAPER:
                if (col.tag == "PaperBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.GLASS:
                if (col.tag == "GlassBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.ORGANIC:
                if (col.tag == "OrganicBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.NON_RECYCLABLE:
                if (col.tag == "Non-RecyclableBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.METAL:
                if (col.tag == "MetalBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.BATTERY:
                if (col.tag == "BatteryBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            case TrashType.CUP:
                if (col.tag == "CupBin") { }
                //add points;
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }
    
}
