using UnityEngine;

public class BarrierBehavior : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public float checkDistance = 1f; // Distance tolerance for passing the player

    void Update()
    {
        // Check if the barrier has passed the player's position
        if (player != null && transform.position.z < player.position.z - checkDistance)
        {
            TriggerGameOver();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the barrier collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        // Find the GameManager and call its gameOver method
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.gameOver(); // Trigger the GameManager's game over logic
        }
        else
        {
            Debug.LogError("GameManager not found!");
        }
    }
}
