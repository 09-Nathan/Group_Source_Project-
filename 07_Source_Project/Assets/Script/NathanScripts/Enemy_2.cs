using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    public float speed;
    public static float HP;

    private void Awake()
    {
        HP = 3;
    }
    void Update()
    {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);


        if (transform.position.y < -5.2f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(HP==0f)
        {
            if (other.gameObject.tag == "Projectiles")
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }     
}
