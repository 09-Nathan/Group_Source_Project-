using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BossScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public BossHPScript BossHPScript;
    public float delayTime;
    private Animator boss;
    public Collider2D play_win,boss_lose;
    private bool bossing = false;
    private bool bossDeathAudioPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponent<Animator>();
        currentHealth = maxHealth;
        BossHPScript.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, 0.0005f);
 
        if (currentHealth <= 0 && !bossDeathAudioPlayed)
        {
            AudioManager.instance.Play("BossDeath");
            boss.SetTrigger("BossDeath");
            boss_lose.enabled = false;
            play_win.enabled = false;
            Invoke("ChangeScene", delayTime);
            bossDeathAudioPlayed = true;
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
    private void ChangeScene()
    {        
        SceneManager.LoadScene(7);
    }


}
