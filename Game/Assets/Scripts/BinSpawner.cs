using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinSpawner : MonoBehaviour
{
    public GameObject bin;
    private GameManager gameManager;
    private int numberOfBins = 3;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        float cameraHeight = Camera.main.orthographicSize * 2;
        float cameraWidth = Camera.main.aspect * cameraHeight;

        float sizeOfFirstPart = (cameraWidth / (numberOfBins + 1));
        float firstBinXPosition = -(cameraWidth / 2) + sizeOfFirstPart;

        for (int i = 0; i < numberOfBins; i++)
        {
            Instantiate<GameObject>(bin, new Vector3(firstBinXPosition + i * sizeOfFirstPart, -cameraHeight/2 + 1.1f, 0), new Quaternion(), this.transform);
        }
    }
}
