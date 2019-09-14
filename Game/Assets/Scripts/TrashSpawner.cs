﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trash;
    public float timeBeetwenSpawns = 5f;
    private float countdown = 2f;

    void Update()
    {
        if(countdown <= 0f)
        {
            spawnTrash();
            countdown = timeBeetwenSpawns;
        }

        countdown -= Time.deltaTime;
    }

    public void spawnTrash()
    {
        int trashTypeIndex = Random.Range(1, 8);
        float xPosition = Random.Range(-2.5f, 2.5f);
        Instantiate<GameObject>(trash, new Vector3(xPosition, 5.5f, 0), new Quaternion());

    }
}
