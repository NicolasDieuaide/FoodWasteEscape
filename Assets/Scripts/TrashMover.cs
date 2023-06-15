using UnityEngine;

public class TrashMover : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject player; // Reference to the player

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction from the trash to the player
        Vector3 direction = (player.transform.position - transform.position).normalized;

        // Set the y component of the direction to 0 to only move horizontally
        direction.y = 0;

        // Move the trash in the direction of the player
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
