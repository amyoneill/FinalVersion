using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public int scoreValue = 1; // Points added when coin is collected

    void OnTriggerEnter(Collider other)
    {

        // Check that the object colliding is the player
        if (other.CompareTag("Player"))
        {

            // Find ScoreDisplay component and add to the score
            ScoreDisplay scoreDisplay = FindObjectOfType<ScoreDisplay>();
            if (scoreDisplay != null)
            {
                scoreDisplay.AddScore(scoreValue); // Increase score by 1
            }
            else
            {

            }

            // Destroy the coin after collection
            Destroy(gameObject);
        }
    }
}
