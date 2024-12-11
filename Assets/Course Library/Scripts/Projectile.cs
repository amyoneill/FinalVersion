using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Destroy bullet after a 3 secs
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the projectile collided with a barrier
        if (collision.gameObject.CompareTag("Barrier"))
        {
            // Destroy the projectile and the barrier
            Destroy(collision.gameObject); // Destroy barrier
            Destroy(gameObject); // Destroy projectile
        }
    }
}
