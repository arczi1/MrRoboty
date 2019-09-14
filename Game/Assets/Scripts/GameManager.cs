using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Sprites")]
    public Sprite[] trashSprites;
    public Dictionary<string, Sprite> trashSpritesMap = new Dictionary<string, Sprite>();

    public Sprite[] binSprites;  
    public Dictionary<string, Sprite> binSpritesMap = new Dictionary<string, Sprite>();

    public List<string> consideredTypes = new List<string>();

    string[] types = { "Plastic", "Paper", "Glass", "Organic", "Others", "Metal", "Battery"/*, "Cup"*/};

    void Start()
    {
        chooseTypes();
        initializeBinSpritesMap();
    }

    private void initializeBinSpritesMap()
    {
        binSpritesMap["Plastic"] = binSprites[0];
        binSpritesMap["Paper"] = binSprites[1];
        binSpritesMap["Glass"] = binSprites[2];
        binSpritesMap["Organic"] = binSprites[3];
        binSpritesMap["Others"] = binSprites[4];
        binSpritesMap["Metal"] = binSprites[5];
        binSpritesMap["Battery"] = binSprites[6];
        //binSpritesMap["Cup"] = binSprites[7];
    }


    public Sprite getBinSprite(string spriteName)
    {
        return binSpritesMap[spriteName];
    }

    public Sprite getTrashSprite(int index)
    {
        return trashSprites[index];
    }

    void chooseTypes()
    {
        string first = types[Random.Range(0, 7)];
        string second = types[Random.Range(0, 7)];
        while (first == second)
        {
            second = types[Random.Range(0, 7)];
        }
        string third = types[Random.Range(0, 7)];
        while (first == third || second == third)
        {
            third = types[Random.Range(0, 7)];
        }

        consideredTypes.Add(first);
        consideredTypes.Add(second);
        consideredTypes.Add(third);
    }
}
