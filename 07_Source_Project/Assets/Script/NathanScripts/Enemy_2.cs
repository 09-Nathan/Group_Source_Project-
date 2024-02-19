using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_2 : MonoBehaviour
{
    public float speed;
    public int maxHP=3;
    public static int HP;
    public GameObject[] Bouns;
    int bounsnum;
    public EnemyHp Healthbar;
    private void Start()
    {
        
        HP = maxHP;
        Healthbar.SetMaxHealth(maxHP);
      
    }
    void Update()
    {

        bounsnum = Random.Range(0, Bouns.Length);
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);


        if (transform.position.y < -5.2f)
        {
            Destroy(gameObject);
        }
        else if (HP==0)
        {
            Destroy(gameObject);
            BounsPlayer();
            AudioManager.instance.Play("Destroy");
            GameManager.Score += 20;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectiles")
        {
            enemydamage(1);
        }
    }
    void enemydamage(int enemydam)
    {
        HP -= enemydam;
        Healthbar.SetHealth(HP);

    }
    void BounsPlayer()
    {
        if (Bouns.Length > 0)
        {          
            GameObject randomBonus = Bouns[Random.Range(0, Bouns.Length)];
            Instantiate(randomBonus, transform.position, Quaternion.identity);
        }
    }
}
