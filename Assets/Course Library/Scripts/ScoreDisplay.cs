using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private int score = 0; // Initial score
    public TextMeshProUGUI scoreText; // Reference to the TMP text element

    void Start()
    {
        UpdateScoreText(); // Initialize the score display
    }

    // Method to increase the score
    public void AddScore(int amount)
    {
        score += amount; // Increment the score
        UpdateScoreText(); // Update the UI
    }

    // Update the score text on the screen
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
