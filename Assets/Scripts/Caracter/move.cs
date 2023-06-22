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
        transform.Translate(Vector3.right * objectSpeed * Time.deltaTime);

        float moveX = Input.GetAxis("Horizontal") * characterSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveX);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Trash") && other.gameObject.name.Contains("(Clone)"))
        {
            Destroy(other.gameObject);

            ScoreManager.instance.IncreaseScore(1);
        }
    }


}
