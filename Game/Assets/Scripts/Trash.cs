﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private GameManager gameManager;
    public SpriteRenderer graphics;
    private float fallingSpeed = 150.0f;
    private string type;
    private float timeUntilDestroy = 4.0f;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        type = gameManager.consideredTypes[Random.Range(0, 2)];

        //graphics.sprite = gameManager.getTrashSprite(Random.Range(0, 4));

    }
    
    void Update()
    {
        timeUntilDestroy -= Time.deltaTime;
        if(timeUntilDestroy <= 0)
        {
            Destroy(gameObject);
        }
        trashMovement();
    }

    private void trashMovement()
    {
        Vector3 fallingDireciton = new Vector3(0, -2, 0);
        transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 100);
    }

    void onCollisionEnter2D(Collider2D col)
    {
        if (col.tag == type)
        {
            //add points
        }
    }
}
