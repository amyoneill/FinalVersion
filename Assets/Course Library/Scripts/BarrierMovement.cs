using UnityEngine;

public class BarrierMovement : MonoBehaviour
{
    public float speed = 40f;  // Speed of barrier

    void Update()
    {
        // Move the barrier towards player 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
