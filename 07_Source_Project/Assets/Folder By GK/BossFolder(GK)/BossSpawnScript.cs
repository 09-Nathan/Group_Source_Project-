using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnScript : MonoBehaviour
{
    public GameObject BosstoInstitate;
    bool BossSpawn;
    private float BossSpawnTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BossSpawnTime -= Time.deltaTime;
        if (BossSpawnTime <= 0&&BossSpawn==false)
        {
            Spawned();
        }
    }
    void Spawned()
    {
        Instantiate(BosstoInstitate, transform.position, transform.rotation);
        BossSpawn = true;
    }
}
