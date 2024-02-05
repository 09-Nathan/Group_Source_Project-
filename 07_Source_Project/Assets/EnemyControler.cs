using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public float speed = 3f;
    public float patrolDistance = 2f;
    public GameObject bulletPrefab;
    public float shootInterval = 2f;

    private bool movingRight = true;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        InvokeRepeating("Shoot", 0f, shootInterval);
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        // ... (Previous patrol code)

        // Adjust the patrol code based on your game's requirements

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
