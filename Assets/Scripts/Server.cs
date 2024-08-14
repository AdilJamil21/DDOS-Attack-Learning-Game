using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Malware"))
        {
            HandleMalwareHit();
        }
    }
    public void HandleMalwareHit()
    {
        GetComponent<SpriteRenderer>().color = Color.red;

        if (FindObjectOfType<GameManager>() != null)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (FindObjectOfType<GameManager2>() != null)
        {
            FindObjectOfType<GameManager2>().GameOver();
        }
        
        
    }
}
