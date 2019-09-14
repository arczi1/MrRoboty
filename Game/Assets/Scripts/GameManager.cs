using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Sprites")]
    public Sprite[] binSprites;
    public Sprite[] trashSprites;
    public Dictionary<string, Sprite> binSpritesMap = new Dictionary<string, Sprite>;

    public List<string> considereadTypes = new List<string>();

    string[] types = { "Plastic", "Paper", "Glass", "Organic", "Others", "Metal", "Battery", "Cup"};

    void OnAwake()
    {
        chooseTypes();

        binSpritesMap["Plastic"] = binSprites[0];

    }

    public Sprite getBinSprite(string spriteName)
    {
        return binSprites[binSpritesMap[spriteName]];
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
