using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn_Bullets : MonoBehaviour
{
    public GameObject Bullet1;
    bool shoot;
    private float ShootCD = .2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShootCD -= Time.deltaTime;
        if (ShootCD <= 0)
        {
            Firing();
            ShootCD = .2f;
        }
    }
    void Firing()
    {
        //Debug.Log("Shoot Once");
        AudioManager.instance.Play("Shooting");
        Instantiate(Bullet1, transform.position, transform.rotation);
    }
}
