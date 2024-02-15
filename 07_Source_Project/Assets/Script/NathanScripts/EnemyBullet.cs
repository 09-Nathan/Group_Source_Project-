using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;
  
    void Update()
    {
        // Move the bullet downward
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Destroy the bullet if it goes off-screen
         if (transform.position.y < -5.2f)
         {
             Destroy(gameObject);
         }

    }
}
