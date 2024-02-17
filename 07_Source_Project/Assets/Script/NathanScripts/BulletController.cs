using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 direction;


    void Update()
    {
        // Move the bullet in its current direction
        transform.Translate(direction * speed * Time.deltaTime);

        // Destroy the bullet if it goes off-screen
        if (transform.position.y < -5.2f || transform.position.x <-2.5|| transform.position.x > 2.5|| transform.position.y > 5.2f)
        {
            Destroy(gameObject);
        }
        
    }

    // Set the initial direction of the bullet
    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection.normalized;
    }
    
}
