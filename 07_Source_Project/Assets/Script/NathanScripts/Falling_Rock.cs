using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Rock : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        
    }
    void Update()
    {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);

        if (transform.position.y < -5.2f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectiles")
        {
            Debug.Log("score");
            AudioManager.instance.Play("Destroy");
            Destroy(this.gameObject);
            GameManager.Score += 5;
            
        }
        else
        {
            Debug.Log("Collided");
        }
    }
}
