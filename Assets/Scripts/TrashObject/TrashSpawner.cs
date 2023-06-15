using System.Collections;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab; // Assign the trash prefab in the inspector
    public float spawnInterval = 1.0f; // Spawn a trash object every second

    private void Start()
    {
        StartCoroutine(SpawnTrash());
    }

    private IEnumerator SpawnTrash()
    {
        while (true)
        {
            Instantiate(trashPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
