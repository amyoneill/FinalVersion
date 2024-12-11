using UnityEngine;

public class RoadManager : MonoBehaviour
{
    private Vector3 startPos;  // Starting position of the road
    public float repeatLength = 10f;  // Distance after which the road repeats
    public float speed = 40f;         // Speed of the road movement

    void Start()
    {
        // Save the initial position of the road
        startPos = transform.position;
    }

    void Update()
    {
        // Move the road along the X-axis (to the right)
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Check if the road has moved beyond the repeatLength
        if (transform.position.x > startPos.x + repeatLength)
        {
            // Move the road back to repeat seamlessly
            transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);
        }
    }
}
