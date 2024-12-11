using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText; // Reference to the Game Over text
    public GameObject returnToMenuButton; // Reference to the Return to Menu button
    public float delayBeforeMainMenu = 3f; // Time to wait before auto-returning to the main menu

    void Start()
    {
        // Ensure the game over UI is hidden at the start
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
        if (returnToMenuButton != null)
        {
            returnToMenuButton.SetActive(false);
        }
    }

    public void gameOver()
    {
        // Show the Game Over text
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }

        // Show the Return to Menu button
        if (returnToMenuButton != null)
        {
            returnToMenuButton.SetActive(true);
        }

        // Optionally stop the game
        Time.timeScale = 0; // Pause the game
        Debug.Log("Game Over!");

        // Automatically return to the main menu after a delay
        Invoke(nameof(ReturnToMainMenu), delayBeforeMainMenu);
    }

    public void ReturnToMainMenu()
    {
        // Reset time scale and load the main menu scene
        Time.timeScale = 1; // Unpause the game
        SceneManager.LoadScene("MainMenu"); 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
