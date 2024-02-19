using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInteractionScript : MonoBehaviour
{
    public PlayerScript ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            ps.TakenDamage(1);

        }
    }
}
