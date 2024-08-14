using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Server"))
        {
            Destroy(gameObject);
        }
    }
}
