using UnityEngine;

public class TrashMover : MonoBehaviour
{
    public float speed = 5.0f;  
    public float endXPosition = -8.0f; 

    private MeshRenderer renderer;
    private HeartDisplay heartDisplay;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        if (!gameObject.name.Contains("(Clone)")) 
        {
            renderer.enabled = false; 
        }

        heartDisplay = FindObjectOfType<HeartDisplay>();
    }

    void Update()
    {
        if (gameObject.name.Contains("(Clone)"))
        {
            Vector3 movement = new Vector3(1, 0, 0);
            transform.Translate(movement * speed * Time.deltaTime);

            if (transform.position.x <= endXPosition)
            {
                Destroy(gameObject);
                ScoreManager.instance.DecreaseHealth(1);
                heartDisplay.UpdateHealth(ScoreManager.instance.health);
            }
        }
    }
}
