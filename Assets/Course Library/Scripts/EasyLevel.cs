using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EasyLevel : MonoBehaviour
{
    // Reference to the "Easy" button
    public Button easyButton;

    void Start()
    {
        // Ensure the button has been assigned and add a listener
        if (easyButton != null)
        {
            easyButton.onClick.AddListener(LoadEasyLevel);
        }
        else
        {
            Debug.LogError("Easy Button is not assigned in the inspector.");
        }
    }

    // Method to load the EasyLevel scene
    public void LoadEasyLevel()
    {
        SceneManager.LoadScene("EasyLevel");
    }
}