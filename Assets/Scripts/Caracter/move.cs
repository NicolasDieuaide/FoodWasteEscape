using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float objectSpeed = 5f;
    public float characterSpeed = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Move the object along the Z axis
        transform.Translate(Vector3.right * objectSpeed * Time.deltaTime);

        // Move the character along the X axis
        float moveX = Input.GetAxis("Horizontal") * characterSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveX);
    }



// This function is called when the player collides with a trigger collider
public void OnTriggerEnter(Collider other)
    {
        // If the player collided with a piece of trash
        if (other.gameObject.CompareTag("Trash"))
        {
            // Destroy the piece of trash
            Destroy(other.gameObject);
        }
    }
}

