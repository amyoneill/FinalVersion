using UnityEngine;

public class BarrierSpawner : MonoBehaviour
{
    public GameObject barrierPrefab;       // The barrier prefab
    public Transform spawnAreaCenter;     // Center of the road for spawning
    public float roadWidth = 200f;        // Width of the road
    public float spawnZOffset = 20f;      // Distance ahead of the spawner
    public float barrierLifetime = 5f;    // Time before the barrier disappears
    public float spawnInterval = 3f;      // Time between barrier spawns

    private float nextSpawnTime;

    public float difficultyIncreaseRate = 0.1f; // How much faster the spawn interval decreases
public float minimumSpawnInterval = 1f;    // Minimum interval for spawning barriers

void Update()
{
    if (Time.time >= nextSpawnTime)
    {
        SpawnBarrier();
        nextSpawnTime = Time.time + spawnInterval;

        // Gradually reduce the spawn interval
        spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - difficultyIncreaseRate);
    }
}


    void SpawnBarrier()
    {
        if (barrierPrefab != null)
        {
            // Calculate a random X position within the road bounds
            float randomX = Random.Range(-roadWidth / 2, roadWidth / 2);

            // Set Z position offset
            float randomZ = Random.value > 0.5f ? 5f : -5f;

            // Spawn position for the barrier
            Vector3 spawnPosition = new Vector3(
                spawnAreaCenter.position.x + randomX,
                spawnAreaCenter.position.y,
                randomZ
            );

            // Set the rotation to face the player
            Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

            // Instantiate the barrier with the correct rotation
            GameObject barrier = Instantiate(barrierPrefab, spawnPosition, spawnRotation);

            // Destroy the barrier after its lifetime
            Destroy(barrier, barrierLifetime);

        }
        else
        {
            
        }
    }
}
