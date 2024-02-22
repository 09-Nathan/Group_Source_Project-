using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public float speed;
    public PlayerScript ps;
    public GameObject[] Bouns;
    private int bouns_array;
    private void Start()
    {
        ps = GameObject.Find("player").GetComponent<PlayerScript>();
       // Debug.Log("PS Found");
    }
    void Update()
    {
        bouns_array = Random.Range(0, Bouns.Length);
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
            AudioManager.instance.Play("Destroy");
            Bouns_Buff();
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

    void Bouns_Buff()
    {
        GameObject randomBonus = Bouns[Random.Range(0, Bouns.Length)];
        Instantiate(randomBonus, transform.position, Quaternion.identity);
    }
}
