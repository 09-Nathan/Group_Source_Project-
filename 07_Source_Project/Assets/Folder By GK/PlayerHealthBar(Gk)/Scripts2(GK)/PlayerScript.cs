using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int maxHealth = 6;
    public int currentHealth;
    public PlayerHealthBarScript healthBarScript;
    public PowerUpScript Secondary;
    // Start is called before the first frame update
    void Start()
    {
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
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Game Lose");
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
            AudioManager.instance.Play("PowerUps");
            Secondary.PowerUp = true;
            Secondary.PowerUpCD = 20f;
            Destroy(other.gameObject);
        }
    }
}
