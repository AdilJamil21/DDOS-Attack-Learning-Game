using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpManager : MonoBehaviour
{
    public Button slowDownButton;
    public Button extendTimeButton;
    public float slowDownFactor = 0.15f; // Adjust the slowdown factor as needed
    public int additionalTime = 5; // Additional time in seconds

    private bool isSlowDownUsed = false;
    private bool isExtendTimeUsed = false;
    private PacketSpawner2 spawner;
    private GameManager2 gameManager;

    void Start()
    {
        spawner = FindObjectOfType<PacketSpawner2>();
        gameManager = FindObjectOfType<GameManager2>();

        slowDownButton.onClick.AddListener(UseSlowDown);
        extendTimeButton.onClick.AddListener(UseExtendTime);
    }

    public void UseSlowDown()
    {
        if (!isSlowDownUsed)
        {
            spawner.SlowDownMalware(slowDownFactor);
            slowDownButton.interactable = false;
            isSlowDownUsed = true;
        }
    }

    public void UseExtendTime()
    {
        if (!isExtendTimeUsed)
        {
            gameManager.ExtendGameTime(additionalTime);
            extendTimeButton.interactable = false;
            isExtendTimeUsed = true;
        }
    }
}
