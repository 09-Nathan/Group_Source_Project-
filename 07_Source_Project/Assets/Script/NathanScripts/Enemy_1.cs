using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);

        if (transform.position.y < -5.2f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectiles")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            AudioManager.instance.Play("Destroy");
            GameManager.Score += 10;
        }
    }

}
