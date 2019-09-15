﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private GameManager gameManager;
    public SpriteRenderer graphics;
    private float fallingSpeed = 200.0f;
    private string type;
    private float timeUntilDestroy = 20.0f;
    private int randomTrashType = 0;
    private Vector3 mOffset;
    private float mZCoord;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        randomTrashType = Random.Range(0, 2);
        type = gameManager.consideredTypes[randomTrashType];
        graphics.sprite = gameManager.getTrashSprite(randomTrashType);

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
        Vector3 fallingDireciton = new Vector3(0, -1, 0);
        transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 100);
    }

    void onCollisionEnter2D(Collider2D col)
    {
        if (col.tag == type)
        {
            //add points
        }
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
