using UnityEngine;

public class VehicleShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // The bullet prefab
    public Transform firePoint;    // The point from which the bullet will fire
    public float fireRate = 0.5f;  // Time between shots

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime) // Check for spacebar press and fire rate
        {
            FireBullet();
            nextFireTime = Time.time + fireRate; // Update the next fire time
        }
    }

    void FireBullet()
    {
        // Instantiate the bullet at the fire point
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
