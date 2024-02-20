using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public GameObject Bullet2;
    public bool PowerUp = false;
    public float PowerUpCD;
    public float PowerShotCD = .6f;
    // Start is called before the first frame update
    void awake()
    {
        Debug.Log("Started");
        PowerUp = true;
        PowerUpCD = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(PowerUp == true)
        {
        PowerUpCD -= Time.deltaTime;
        PowerShotCD -= Time.deltaTime;
            if (PowerShotCD <= 0)
            {
                
                SecondaryFiring();
                PowerShotCD = .6f;
            }
            if (PowerUpCD <= 0)
            {
                PowerUpCD = 20f;
                PowerUp = false;
            }
        }
        
    }
    void SecondaryFiring()
    {
        
        //AudioManager.instance.Play("Shooting");
        Instantiate(Bullet2, transform.position, transform.rotation);
    }
}
