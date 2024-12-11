using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public int scoreValue = 1; // Points added when this coin is collected

    void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is the player
        if (other.CompareTag("Player"))
        {
            // Play the collection sound
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.Play(); // Play the sound

                // Detach the AudioSource from the coin GameObject
                audioSource.transform.parent = null;

                // Destroy the detached AudioSource after the clip finishes playing
                Destroy(audioSource.gameObject, audioSource.clip.length);
            }

            // Find the ScoreDisplay component and add to the score
            ScoreDisplay scoreDisplay = FindObjectOfType<ScoreDisplay>();
            if (scoreDisplay != null)
            {
                scoreDisplay.AddScore(scoreValue); // Increase score by 1
            }

            // Destroy the coin immediately after the player collects it
            Destroy(gameObject);
        }
    }
}
