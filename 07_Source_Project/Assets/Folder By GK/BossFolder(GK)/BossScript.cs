using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public BossHPScript BossHPScript;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        BossHPScript.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, 0.0005f);
        
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void BossTakenDamage(int damage)
    {
        currentHealth -= damage;
        BossHPScript.SetHealth(currentHealth);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Projectiles"))
        {
            //Debug.Log("Collision");
            BossTakenDamage(1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == ("Rocket"))
        {
            //Debug.Log("Collision");
            BossTakenDamage(2);
            Destroy(collision.gameObject);
        }
    }
}
