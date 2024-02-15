using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_2 : MonoBehaviour
{
    public float speed;
    public int maxHP=3;
    public static int HP;

    public EnemyHp Healthbar;
    private void Start()
    {
        
        HP = maxHP;
        Healthbar.SetMaxHealth(maxHP);
      
    }
    void Update()
    {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);


        if (transform.position.y < -5.2f||HP==0)
        {
            Destroy(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            enemydamage(1);
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(HP==0f)
        {
            if (other.gameObject.tag == "Projectiles")
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }     
    void enemydamage(int enemydam)
    {
        HP -= enemydam;
        Healthbar.SetHealth(HP);

    }
}
