﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public float speed = 3f;
    public float patrolDistance = 2f;
    public GameObject bulletPrefab;
    public float shootInterval = 2f;

    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        InvokeRepeating("Shoot", 0f, shootInterval);
    }
  

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
