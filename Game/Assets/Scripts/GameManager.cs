using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [Header("Sprites")]
    public Sprite[] trashSprites;
    public Dictionary<string, Dictionary<int, Sprite>> trashSpritesMap = new Dictionary<string, Dictionary<int, Sprite>>();

    public Sprite[] binSprites;  
    public Dictionary<string, Sprite> binSpritesMap = new Dictionary<string, Sprite>();

    public List<string> consideredTypes = new List<string>();

    string[] types = { "Plastic", "Paper", "Glass", "Organic", "Others", "Metal", "Battery"/*, "Cup"*/};

    private const int binAmount = 7;
    private static int _currentPoints;
    public static int CurrentPoints
    {
        get { return _currentPoints;  }
    }

    void Start()
    {
        _currentPoints = 0;  
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

    private void initializeTrashSpritesMap()
    {
        trashSpritesMap["Plastic"] = new Dictionary<int, Sprite>();
        trashSpritesMap["Paper"] = new Dictionary<int, Sprite>();
        trashSpritesMap["Glass"] = new Dictionary<int, Sprite>();
        trashSpritesMap["Organic"] = new Dictionary<int, Sprite>();
        trashSpritesMap["Others"] = new Dictionary<int, Sprite>();
        trashSpritesMap["Metal"] = new Dictionary<int, Sprite>();
        trashSpritesMap["Battery"] = new Dictionary<int, Sprite>();
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
        string first = types[Random.Range(0, binAmount - 1)];
        string second = types[Random.Range(0, binAmount - 1)];
        while (first == second)
        {
            second = types[Random.Range(0, binAmount - 1)];
        }
        string third = types[Random.Range(0, binAmount - 1)];
        while (first == third || second == third)
        {
            third = types[Random.Range(0, binAmount - 1)];
        }

        consideredTypes.Add(first);
        consideredTypes.Add(second);
        consideredTypes.Add(third);
    }
}
