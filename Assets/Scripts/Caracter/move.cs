using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxTiltAngle = 30f; // Maximum tilt angle in degrees

    private Transform cylinderTransform;
    private Quaternion initialRotation;

    private void Start()
    {
        cylinderTransform = GetComponent<Transform>();
        initialRotation = cylinderTransform.rotation;
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);

        cylinderTransform.Translate(movement * moveSpeed * Time.deltaTime);

        // Reset cylinder rotation
        cylinderTransform.rotation = initialRotation;

        // Prevent tilting
        Vector3 eulerRotation = cylinderTransform.rotation.eulerAngles;
        eulerRotation.z = Mathf.Clamp(eulerRotation.z, -maxTiltAngle, maxTiltAngle);
        cylinderTransform.rotation = Quaternion.Euler(eulerRotation);
    }

    // This function is called when the player collides with a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // If the player collided with a piece of trash
        if (other.gameObject.CompareTag("Trash"))
        {
            // Destroy the piece of trash
            Destroy(other.gameObject);
        }
    }
}
