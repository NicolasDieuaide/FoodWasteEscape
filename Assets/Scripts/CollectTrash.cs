using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrash : MonoBehaviour
{
    // This function is called when the player collides with a trigger collider
    void OnTriggerEnter(Collider other)
    {
        // If the player collided with a piece of trash
        if (other.gameObject.CompareTag("Trash"))
        {
            // Destroy the piece of trash
            Destroy(other.gameObject);
        }
    }
}
