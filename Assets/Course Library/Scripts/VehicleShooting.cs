using UnityEngine;

public class VehicleShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // bullet prefab
    public Transform firePoint;    // Firepoint of the bullet
    public float fireRate = 0.3f;  // Time between shots

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime) // Check spacebar
        {
            FireBullet();
            nextFireTime = Time.time + fireRate; // Update next fire time
        }
    }

    void FireBullet()
    {
        // Instantiate bullet at the fire point
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
