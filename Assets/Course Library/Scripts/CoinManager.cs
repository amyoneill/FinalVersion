using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coinPrefab;  
    public Transform roadTransform;
    public float roadWidth = 200f;  
    public float roadCenterX = -90f;  
    public float roadZPosition = 0f;  

    void Start()
    {
        SpawnCoin();
    }

    void SpawnCoin()
    {
        if (coinPrefab != null)
        {
            // Calculate random x posn within road bounds
            float halfRoadWidth = roadWidth / 2;
            float randomX = Random.Range(roadCenterX - halfRoadWidth, roadCenterX + halfRoadWidth);

            // Set the spawn position 
            Vector3 spawnPosition = new Vector3(randomX, 1f, roadZPosition);

            // Instantiate the coin at the position
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);

        }
        else
        {
           
        }
    }
}
