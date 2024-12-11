using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private int score = 0; // Starting score
    public TextMeshProUGUI scoreText; 

    void Start()
    {
        UpdateScoreText(); // Initialize score display
    }

    // Method to increase the score
    public void AddScore(int amount)
    {
        score += amount; // Increase the score
        UpdateScoreText(); // Update UI
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
