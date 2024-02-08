using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{
    public Slider EMYHP;

    public void SetHealth(int Health)
    {
        EMYHP.value= Health ;
    }
    public void SetMaxHealth(int Health)
    {
        EMYHP.maxValue = Health;
        EMYHP.value = Health;
    }
}
