using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketSpawner : MonoBehaviour
{
    public GameObject packetPrefab;
    public GameObject malwarePrefab;
    public Transform parentTransform; // Reference to the Canvas or a parent UI element
    public float spawnInterval = 1f;
    public float gameTime = 10f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
        StartCoroutine(EndGameTimer());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            GameObject obj;
            if (Random.value < 0.35f) // 35% chance of being malware
            {
                obj = Instantiate(malwarePrefab, parentTransform);
            }
            else
            {
                obj = Instantiate(packetPrefab, parentTransform);
            }

            // Set falling speed and direction
            obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-300, 300), 600); // Adjust spawn position
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -Random.Range(0.5f, 1f)); // Adjust speed range for difficulty
        }
    }

    IEnumerator EndGameTimer()
    {
        yield return new WaitForSeconds(gameTime);
        FindObjectOfType<GameManager>().Win();
    }

}
