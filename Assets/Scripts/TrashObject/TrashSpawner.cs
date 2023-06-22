using UnityEngine;
using System.Collections;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab; 
    public float minSpawnInterval = 1.0f; 
    public float maxSpawnInterval = 5.0f;
    public float minZPosition = 15.0f; 
    public float maxZPosition = 23.58f; 

    void Start()
    {
        StartCoroutine(SpawnTrash());
    }

    IEnumerator SpawnTrash()
    {
        while (true)
        {
            float randomZ = Random.Range(minZPosition, maxZPosition);
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, randomZ);
            GameObject clone = Instantiate(trashPrefab, spawnPosition, Quaternion.identity);

            MeshRenderer renderer = clone.GetComponent<MeshRenderer>();
            if (renderer != null)
            {
                renderer.enabled = true;
            }

            TrashMover trashMover = clone.GetComponent<TrashMover>();
            if (trashMover != null)
            {
                trashMover.enabled = true;
            }

            float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(randomInterval);
        }
    }

}
