using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText; // Game Over text
    public GameObject returnToMenuButton; //Return to Menu button
    public float delayBeforeMainMenu = 3f; // Time to wait before return to main menu

    void Start()
    {
        // "game over" UI is hidden at the start
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
        // Show Game Over text
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }

        // Show Return to Menu button
        if (returnToMenuButton != null)
        {
            returnToMenuButton.SetActive(true);
        }

        // stop the game
        Time.timeScale = 0; // Pause the game
        Debug.Log("Game Over!");

        // Automatically return to the main menu after a delay
        Invoke(nameof(ReturnToMainMenu), delayBeforeMainMenu);
    }

    public void ReturnToMainMenu()
    {
        // Reset time scale and load main menu 
        Time.timeScale = 1; // Unpause the game
        SceneManager.LoadScene("MainMenu"); 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
