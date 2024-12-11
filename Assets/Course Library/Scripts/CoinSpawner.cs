using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;          // The coin prefab
    public Transform spawnAreaCenter;     // Center of the road for spawning
    public float roadWidth = 200f;        // Width of the road
    public float spawnZOffset = 20f;      // Distance ahead of the spawner
    public float spawnInterval = 2f;      // Time between spawns
    public float coinLifetime = 10f;      // Time before the coin is destroyed

    private float nextSpawnTime = 0f;

    void Update()
    {
        // Spawn coins at regular intervals
        if (Time.time >= nextSpawnTime)
        {
            SpawnCoin();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnCoin()
    {
        // Null check for spawnAreaCenter
        if (spawnAreaCenter == null)
        {
            Debug.LogError("Spawn Area Center is not assigned!");
            return;
        }

        // Null check for coinPrefab
        if (coinPrefab == null)
        {
            Debug.LogError("Coin prefab is not assigned!");
            return;
        }

        // Random X position within the road bounds
        float randomX = Random.Range(-roadWidth / 2, roadWidth / 2);

        // Random Z position to either 5 or -5
        float randomZ = Random.value > 0.5f ? 5f : -5f;

        // Calculate the spawn position
        Vector3 spawnPosition = new Vector3(
            spawnAreaCenter.position.x + randomX,
            spawnAreaCenter.position.y,
            spawnAreaCenter.position.z + randomZ
        );

        // Set the rotation to face the player
        Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

        // Instantiate the coin
        GameObject coin = Instantiate(coinPrefab, spawnPosition, spawnRotation);

        // Destroy the coin after its lifetime
        Destroy(coin, coinLifetime);

        Debug.Log($"Coin spawned at {spawnPosition}");
    }
}
