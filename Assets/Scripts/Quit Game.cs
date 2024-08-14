using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("GameQuit Time", "The application was last closed at: " + System.DateTime.Now);
        Debug.Log("Application Closed " + System.DateTime.Now);
    }

    public void QuitGameFun()
    {
        OnApplicationQuit();
        Application.Quit();

        Input.backButtonLeavesApp = true;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnApplicationQuit();
            Application.Quit();
        }
    }
}
