using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn_Bullets : MonoBehaviour
{
    public GameObject Bullet1;
    bool shoot;
    public float ShootCD = .6f;
    public bool PoweredUp = false;
    public float powercd = 20f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PoweredUp == false)
        {
            ShootCD -= Time.deltaTime;
            if (ShootCD <= 0)
            {
                Firing();
                ShootCD = .6f;

            }
        }
        if (PoweredUp == true)
        {
            powercd -= Time.deltaTime;
            ShootCD -= Time.deltaTime;
            if (ShootCD <= 0)
            {
                Firing();
                ShootCD = .3f;

            }
            if(powercd <= 0)
            {
                PoweredUp = false;
                powercd = 20f;
            }
        }
    }
    void Firing()
    {
        //Debug.Log("Shoot Once");
        //AudioManager.instance.Play("Shooting");
        Instantiate(Bullet1, transform.position, transform.rotation);
    }
}
