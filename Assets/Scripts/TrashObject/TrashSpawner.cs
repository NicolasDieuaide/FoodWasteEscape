using UnityEngine;
using System.Collections;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab; // This should be your Trash object (Cube)
    public float minSpawnInterval = 1.0f; // The minimum time interval between spawns (in seconds)
    public float maxSpawnInterval = 5.0f; // The maximum time interval between spawns (in seconds)
    public float minZPosition = 15.0f; // Minimum Z position for spawning
    public float maxZPosition = 23.58f; // Maximum Z position for spawning

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTrash());
    }

    IEnumerator SpawnTrash()
    {
        while (true)
        {
            // Instantiate trash at a random z-position
            float randomZ = Random.Range(minZPosition, maxZPosition);
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, randomZ);
            GameObject clone = Instantiate(trashPrefab, spawnPosition, Quaternion.identity);

            // Enable the Mesh Renderer of the cloned trash object to make it visible
            MeshRenderer renderer = clone.GetComponent<MeshRenderer>();
            if (renderer != null)
            {
                renderer.enabled = true;
            }

            // Enable the TrashMover script of the cloned trash object to make it move
            TrashMover trashMover = clone.GetComponent<TrashMover>();
            if (trashMover != null)
            {
                trashMover.enabled = true;
            }

            // Wait for a random time interval before spawning the next trash
            float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(randomInterval);
        }
    }

}
