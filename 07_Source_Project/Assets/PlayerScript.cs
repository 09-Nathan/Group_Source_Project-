using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int maxHealth = 8;
    public int currentHealth;
    public Player_Spawn_Bullets psb;
    public PlayerHealthBarScript healthBarScript;
    public PowerUpScript Secondary;
    public PowerUpScript Secondary2;
    public float delayTime=3f;
    public Animator Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakenDamage(1);
        }
        if (currentHealth == 0)
        {
            Invoke("ChangeScene", delayTime);
            AudioManager.instance.Play("PlayerDeath");
            Player.SetTrigger("PlayerDeath");          
        }
        
    }
    public void TakenDamage(int damage)
    {
        currentHealth -= damage;
        healthBarScript.SetHealth(currentHealth);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == ("PowerRocket"))
        {
            AudioManager.instance.Play("PowerUp");
            Secondary.PowerUp = true;
            Secondary.PowerUpCD = 20f;
            Secondary2.PowerUp = true;
            Secondary2.PowerUpCD = 20f;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == ("HPup"))
        {
            AudioManager.instance.Play("PowerUp");
            if (maxHealth >= 9)
            {
                currentHealth = 8;
                healthBarScript.SetHealth(currentHealth);
            }
            if (maxHealth <= 8)
            {
                currentHealth +=3;
                healthBarScript.SetHealth(currentHealth);
                Destroy(other.gameObject);
            }
        }
        if (other.gameObject.tag == ("FiringUp"))
        {
            AudioManager.instance.Play("PowerUp");
            psb.PoweredUp = true;
            psb.powercd = 20f;
            Destroy(other.gameObject);
        }
    }
    private void ChangeScene()
    {      
        SceneManager.LoadScene(3);
    }
}
