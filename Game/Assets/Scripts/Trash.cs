﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private GameManager gameManager;
    public SpriteRenderer graphics;
    private float fallingSpeed = 200.0f;
    private string type;
    private float timeUntilDestroy = 10.0f;
    private int randomTrashType = 0;
    private Vector3 mOffset;
    private float mZCoord;
    private WindowManager windowManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        windowManager = FindObjectOfType<WindowManager>();

        //gets random index of one of considered types
        randomTrashType = Random.Range(0, 3);
        type = gameManager.consideredTypes[randomTrashType];
        Debug.Log(type);
        //set random sprites from sprites of considered type
        graphics.sprite = gameManager.getTrashSprite(type, Random.Range(0, 3));
    }

    void Update()
    {
        timeUntilDestroy -= Time.deltaTime;
        if (!windowManager.getMessageWindow() && timeUntilDestroy <= 0)
        {
            Destroy(gameObject);
            gameManager.changePoints(-2);
        }
        trashMovement();
        if (!windowManager.getMessageWindow() && gameObject.transform.position.x < -Camera.main.aspect * Camera.main.orthographicSize + 0.2)
        {
            Vector3 fallingDireciton = new Vector3(1, 0, 0);
            transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 20);
        }
        else if (!windowManager.getMessageWindow() && gameObject.transform.position.x > Camera.main.aspect* Camera.main.orthographicSize - 0.2)
        {
            Vector3 fallingDireciton = new Vector3(-1, 0, 0);
            transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 20);
        }
    }

    private void trashMovement()
    {
        Vector3 fallingDireciton = new Vector3(0, -1, 0);
        transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 100);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == type)
        {
            gameManager.changePoints(1);
        }
        else
        {
            windowManager.setMessageWindow(true);
            gameManager.changePoints(-1);
        }
        Destroy(this.gameObject);
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
