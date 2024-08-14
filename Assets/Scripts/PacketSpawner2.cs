using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketSpawner2 : MonoBehaviour
{
    public GameObject packetPrefab2;
    public GameObject malwarePrefab2;
    public Transform parentTransform; // Reference to the Canvas or a parent UI element
    public float spawnInterval2 = 1f;
    public float gameTime2 = 20f;

    private float malwareSpeedModifier = 1f;

    void Start()
    {
        StartCoroutine(SpawnObjects2());
        StartCoroutine(EndGameTimer2());
    }

    IEnumerator SpawnObjects2()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval2);

            GameObject obj;
            if (Random.value < 0.40f) // 40% chance of being malware
            {
                obj = Instantiate(malwarePrefab2, parentTransform);
                obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -Random.Range(0.5f, 1f) * malwareSpeedModifier); // Adjust speed range for difficulty
            }
            else
            {
                obj = Instantiate(packetPrefab2, parentTransform);
                obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -Random.Range(0.5f, 1f)); // Adjust speed range for difficulty
            }

            // Set falling speed and direction
            obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-300, 300), 600); // Adjust spawn position
            
        }
    }

    IEnumerator EndGameTimer2()
    {
        yield return new WaitForSeconds(gameTime2);
        FindObjectOfType<GameManager2>().Win();
    }

    public void SlowDownMalware(float factor)
    {
        malwareSpeedModifier = factor;
    }
}
