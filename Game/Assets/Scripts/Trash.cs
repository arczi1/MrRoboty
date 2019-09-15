using System.Collections;
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

        //gets random index of one of considered types
        randomTrashType = Random.Range(0, 3);
        type = gameManager.consideredTypes[randomTrashType];
        Debug.Log(type);
        //set random sprites from sprites of considered type
        graphics.sprite = gameManager.getTrashSprite(randomTrashType);
        //graphics.sprite = gameManager.getTrashSprite(type, Random.Range(0, 3));
    }

    void Update()
    {
        timeUntilDestroy -= Time.deltaTime;
        if (timeUntilDestroy <= 0)
        {
            Destroy(gameObject);
        }
        trashMovement();
        if (gameObject.transform.position.x < -Camera.main.aspect * Camera.main.orthographicSize + 0.2)
        {
            Vector3 fallingDireciton = new Vector3(1, 0, 0);
            transform.position = (transform.position + fallingDireciton * Time.deltaTime * fallingSpeed / 20);
        }
        else if (gameObject.transform.position.x > Camera.main.aspect* Camera.main.orthographicSize - 0.2)
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
            //add points
            Debug.Log(col.gameObject.tag + "The same" + type);
        }
        Debug.Log("Collides");
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
