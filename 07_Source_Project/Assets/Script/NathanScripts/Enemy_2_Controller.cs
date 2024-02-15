using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2_Controller : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRadius = 2f;
    public float rotationSpeed = 30f;
    public float shootInterval = 2f;

    private void Start()
    {
        InvokeRepeating("Shoot", 0f, shootInterval);
    }

    private void Update()
    {
        // Rotate the spawner object
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    private void Shoot()
    {
        // Spawn a bullet at the current position of the spawner
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        // Add additional logic to control the bullet's initial direction if needed

        // Attach a script to the bullet to control its movement
        BulletController bulletController = bullet.GetComponent<BulletController>();
        if (bulletController != null)
        {
            bulletController.SetDirection(transform.up); // Set the initial direction of the bullet
        }
    }
}
