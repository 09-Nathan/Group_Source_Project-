using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn_Bullets : MonoBehaviour
{
    public GameObject Bullet1;
    bool shoot;
<<<<<<< Updated upstream
    private float ShootCD = .35f;
=======
    private float ShootCD = .4f;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            ShootCD = .35f;
=======
            ShootCD = .4f;
>>>>>>> Stashed changes
        }
    }
    void Firing()
    {
        //Debug.Log("Shoot Once");
        Instantiate(Bullet1, transform.position, transform.rotation);
    }
}
