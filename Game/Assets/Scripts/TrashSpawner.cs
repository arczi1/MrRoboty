using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trash;
    public float timeBeetwenSpawns = 5f;
    private float countdown = 2f;
    private WindowManager windowManager;

    void Start()
    {
        
        windowManager = FindObjectOfType<WindowManager>();
    }

    void Update()
    {
        if(!windowManager.getMessageWindow() && countdown <= 0f)
        {
            spawnTrash();
            countdown = timeBeetwenSpawns;
        }

        countdown -= Time.deltaTime;
    }

    public void spawnTrash()
    {
        float xPosition = Random.Range(- Camera.main.aspect * Camera.main.orthographicSize + 5, Camera.main.aspect * Camera.main.orthographicSize - 5);
        Instantiate<GameObject>(trash, new Vector3(xPosition, 5.5f, 0), new Quaternion());
    }
}
