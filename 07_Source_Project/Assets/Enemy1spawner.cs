using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
    }
}
