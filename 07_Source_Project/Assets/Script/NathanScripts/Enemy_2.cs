using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_2 : MonoBehaviour
{
    public float speed;
    public int maxHP=3;
    public static int HP;
    public PlayerScript ps;
    public EnemyHp Healthbar;
    public GameObject[] Bouns;
    private int bouns_array;
    private void Start()
    {
        ps = GameObject.Find("player").GetComponent<PlayerScript>();
        HP = maxHP;
        Healthbar.SetMaxHealth(maxHP);
      
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
        else if (HP<=0)
        {
            AudioManager.instance.Play("Destroy");
            Destroy(gameObject);
            GameManager.Score += 20;
            Bouns_Buff();
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectiles")
        {
            enemydamage(1);
        }
        if (other.gameObject.tag == "Rocket")
        {
            enemydamage(2);
        }
        if (other.gameObject.tag == "Player")
        {
            ps.TakenDamage(1);

        }
    }
    void enemydamage(int enemydam)
    {
        HP -= enemydam;
        Healthbar.SetHealth(HP);

    }
    
    void Bouns_Buff()
    {
        GameObject randomBonus = Bouns[Random.Range(0, Bouns.Length)];
        Instantiate(randomBonus, transform.position, Quaternion.identity);
    }
    
}
