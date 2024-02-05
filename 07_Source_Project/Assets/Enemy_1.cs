using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector2 movement = Vector2.down * speed * Time.deltaTime;
        transform.Translate(movement);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Projectiles")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
