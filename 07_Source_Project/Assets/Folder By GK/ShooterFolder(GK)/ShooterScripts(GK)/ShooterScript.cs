using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject objecttoInstitate;
    bool shoot;
    private float ShootCD = .3f;
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
            shooting();
            ShootCD = .3f;
        }
    }
    void shooting()
    {
        Instantiate(objecttoInstitate,transform.position,transform.rotation);

    }
}
