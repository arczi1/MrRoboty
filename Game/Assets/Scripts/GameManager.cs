using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [Header("Sprites")]
    public Sprite[] trashSprites;
    private Dictionary<int, Sprite> plasticTrashSpritesMap = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> paperTrashSpritesMap = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> glassTrashSpritesMap = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> organicTrashSpritesMap = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> othersTrashSpritesMap = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> metalTrashSpritesMap = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> batteryTrashSpritesMap = new Dictionary<int, Sprite>();


    public Sprite[] binSprites;  
    public Dictionary<string, Sprite> binSpritesMap = new Dictionary<string, Sprite>();

    public List<string> consideredTypes = new List<string>();

    string[] types = { "Plastic", "Paper", "Glass", "Organic", "Others", "Metal", "Battery"/*, "Cup"*/};

    private const int binAmount = 7;
    private static int currentPoints;


    void Start()
    {
        currentPoints = 0;
        
        chooseTypes();
        initializeBinSpritesMap();
        initializeTrashSpritesMap();

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
        //plastic
        plasticTrashSpritesMap[0] = trashSprites[7];
        plasticTrashSpritesMap[1] = trashSprites[7];
        plasticTrashSpritesMap[2] = trashSprites[7];

        //paper
        paperTrashSpritesMap[0] = trashSprites[0];
        paperTrashSpritesMap[1] = trashSprites[1];
        paperTrashSpritesMap[2] = trashSprites[2];

        //glass
        glassTrashSpritesMap[0] = trashSprites[3];
        glassTrashSpritesMap[1] = trashSprites[4];
        glassTrashSpritesMap[2] = trashSprites[5];

        //organic
        organicTrashSpritesMap[0] = trashSprites[6];
        organicTrashSpritesMap[1] = trashSprites[6];
        organicTrashSpritesMap[2] = trashSprites[6];

        //others
        othersTrashSpritesMap[0] = trashSprites[7];
        othersTrashSpritesMap[1] = trashSprites[8];
        othersTrashSpritesMap[2] = trashSprites[7];

        //metal
        metalTrashSpritesMap[0] = trashSprites[9];
        metalTrashSpritesMap[1] = trashSprites[10];
        metalTrashSpritesMap[2] = trashSprites[11];
    }

    public void changePoints(int points)
    {
        currentPoints += points;
        ScoreUpdater.setPoints(currentPoints);
    }

    public Sprite getBinSprite(string spriteName)
    {

        return binSpritesMap[spriteName];
    }

    public Sprite getTrashSprite(string type, int index)
    {
        if (type == "Plastic")
            return plasticTrashSpritesMap[index];
        if (type == "Paper")
            return paperTrashSpritesMap[index];
        if (type == "Glass")
            return glassTrashSpritesMap[index];
        if (type == "Organic")
            return organicTrashSpritesMap[index];
        if (type == "Others")
            return othersTrashSpritesMap[index];
        if (type == "Metal")
            return metalTrashSpritesMap[index];

        return binSprites[0];
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
