using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float speed = 40f;  // Speed at which the barrier moves towards the player

    void Update()
    {
        // Move the coin towards the player
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
