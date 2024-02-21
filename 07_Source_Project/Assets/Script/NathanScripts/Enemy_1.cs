using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public float speed;
    public PlayerScript ps;
    private void Start()
    {
        ps = GameObject.Find("player").GetComponent<PlayerScript>();
        Debug.Log("PS Found");
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectiles")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameManager.Score += 10;
        }

        if (collision.gameObject.tag == "Player")
        {
            ps.TakenDamage(1);
        }
        if (collision.gameObject.tag == "Rocket")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameManager.Score += 10;
        }
    }


}
