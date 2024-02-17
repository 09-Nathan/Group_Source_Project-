using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Rock : MonoBehaviour
{
    public float speed;
    public GameManager scoremanage;
    public PlayerScript ps;
    private void Start()
    {
        ps = GameObject.Find("player").GetComponent<PlayerScript>();
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
            Destroy(this.gameObject);
            GameManager.Score += 5;
            
        }
        if (other.gameObject.tag == "Player")
        {
            ps.TakenDamage(1);

        }
    }
}
