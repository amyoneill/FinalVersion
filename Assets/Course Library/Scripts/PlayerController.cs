using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;       // Speed of side-to-side movement
    public float laneWidth = 3.5f;     // Distance between lanes
    public float maxSideMovement = 5f; // Maximum horizontal range

    private float targetX; // Target horizontal position

    void Start()
    {
        // Initialize target position to the car's starting position
        targetX = transform.position.z;
    }

    void Update()
    {
        // Get player input (keyboard or joystick axis)
        float input = Input.GetAxis("Horizontal");

        // Calculate target position
        targetX += input * moveSpeed * Time.deltaTime;

        // Clamp the target position to stay within bounds
        targetX = Mathf.Clamp(targetX, -maxSideMovement, maxSideMovement);

        // Smoothly move the car to the target position
        Vector3 newPosition = transform.position;
        newPosition.z = Mathf.Lerp(newPosition.z, targetX, Time.deltaTime * 10f);
        transform.position = newPosition;
    }
}
