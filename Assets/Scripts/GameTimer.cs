using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float gameTime = 10f; // Total game time in seconds
    private float remainingTime;
    public Text timerText; // Reference to the UI Text component

    void Start()
    {
        remainingTime = gameTime;
        UpdateTimerText();
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            remainingTime = 0;
            UpdateTimerText();
            FindObjectOfType<GameManager>().Win(); // Call the Win method when time runs out
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}


