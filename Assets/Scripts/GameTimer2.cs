using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer2 : MonoBehaviour
{
    public float gameTime = 20f; // Total game time in seconds
    private float remainingTime;
    public Text timerText; // Reference to the UI Text component

    void Start()
    {
        remainingTime = gameTime;
        UpdateTimerText2();
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerText2();
        }
        else
        {
            remainingTime = 0;
            UpdateTimerText2();
            FindObjectOfType<GameManager2>().Win(); // Call the Win method when time runs out
        }
    }

    void UpdateTimerText2()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}


