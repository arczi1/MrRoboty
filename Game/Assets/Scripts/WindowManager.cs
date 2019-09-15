using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject gameWindow;
    public GameObject messageWindow;
    private bool messagePause = false;
    private float messageTimer = 5.0f;

    void Start()
    {
        gameWindow.SetActive(true);
        messageWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(messagePause)
        {
            messageTimer -= Time.deltaTime;
            gameWindow.SetActive(false);
            messageWindow.SetActive(true);
            if (messageTimer <= 0)
            {
                messageTimer = 5.0f;
                messagePause = false;
            }
        }
        else
        {
            gameWindow.SetActive(true);
            messageWindow.SetActive(false);
        }
    }

    public void setMessageWindow(bool _messagePause)
    {
        messagePause = _messagePause;
    }

    public bool getMessageWindow()
    {
        return messagePause;
    }
}
