using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject gameWindow;
    public GameObject messageWindow;
    private bool messagePause = false;


    void Start()
    {
        gameWindow.SetActive(true);
        messageWindow.SetActive(false);
    }

    void gameSettings()
    {
        gameWindow.SetActive(true);
        messageWindow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(messagePause)
        {
            gameWindow.SetActive(false);
            messageWindow.SetActive(true);
            gameWindow.SetActive(false);
            messageWindow.SetActive(true);
        }
        else
        {
            gameWindow.SetActive(true);
            messageWindow.SetActive(false);
            gameWindow.SetActive(true);
            messageWindow.SetActive(false);
        }
    }

    public void setMessageWindow(bool _messagePause)
    {
        messagePause = _messagePause;
    }
}
