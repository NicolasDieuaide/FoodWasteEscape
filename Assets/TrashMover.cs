using UnityEngine;

public class TrashMover : MonoBehaviour
{
    public float speed = 5.0f;  // Speed of the trash
    public float endZPosition = 19.52337f; // Z position of the end of the plane

    // Update is called once per frame
    void Update()
    {
        // Move the trash along the Z-axis
        Vector3 movement = new Vector3(1, 0, 0);
        transform.Translate(movement * speed * Time.deltaTime);

        // Check if the trash has reached the end of the plane
        if (transform.position.z <= endZPosition)
        {
            // Destroy the trash if it's a clone
            if (gameObject.name.Contains("(Clone)"))
            {
                Destroy(gameObject);
            }
        }
    }

}
