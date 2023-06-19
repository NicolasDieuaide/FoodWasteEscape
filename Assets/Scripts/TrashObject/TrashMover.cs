using UnityEngine;

public class TrashMover : MonoBehaviour
{
    public float speed = 5.0f;  // Speed of the trash
    public float endXPosition = -8.0f; // X position of the end of the plane

    private MeshRenderer renderer;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        if (!gameObject.name.Contains("(Clone)")) // if it's the original trash object
        {
            renderer.enabled = false; // make it invisible
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Contains("(Clone)")) // if it's a clone
        {
            // Move the trash along the X-axis towards negative direction
            Vector3 movement = new Vector3(1, 0, 0);
            transform.Translate(movement * speed * Time.deltaTime);

            // Check if the trash has reached the end of the plane
            if (transform.position.x <= endXPosition)
            {
                Destroy(gameObject);
            }
        }
    }
}
