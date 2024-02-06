using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn_Bullets : MonoBehaviour
{
    public GameObject Bullet1;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Bullet1, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
