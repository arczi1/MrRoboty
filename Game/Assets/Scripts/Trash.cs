using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private GameManager gameManager;
    public SpriteRenderer graphics;
    private float fallingSpeed = 200.0f;
    private string type;
    private float timeUntilDestroy = 7.0f;
    private int randomTrashType = 0;

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
}
