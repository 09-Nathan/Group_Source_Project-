using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public BossHPScript BossHPScript;
    public PlayerScript ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("player").GetComponent<PlayerScript>();
        currentHealth = maxHealth;
        BossHPScript.BossSetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, 0.0015f);
        
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void BossTakenDamage(int damage)
    {
        currentHealth -= damage;
        BossHPScript.BossSetHealth(currentHealth);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Projectiles"))
        {
            Debug.Log("Collision");
            BossTakenDamage(1);
            Destroy(other.gameObject);
        }
    }
}
