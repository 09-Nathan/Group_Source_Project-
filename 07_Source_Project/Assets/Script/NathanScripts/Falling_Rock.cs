using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Falling_Rock : MonoBehaviour
{
    public float speed;
    public scoretextscript ss;

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
            ss.score += 5f;
            Debug.Log("score");
            Destroy(this.gameObject);
            
        }
        else
        {
            Debug.Log("Collided");
        }
    }
}
