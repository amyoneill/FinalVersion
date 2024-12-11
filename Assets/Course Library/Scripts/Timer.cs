using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLimit = 60f; 
    public TextMeshProUGUI timerText;

    void Update()
    {
        timeLimit -= Time.deltaTime;

        if (timeLimit <= 0)
        {
            // Trigger Game Over
        }

        timerText.text = "Time: " + Mathf.CeilToInt(timeLimit);
    }
}
