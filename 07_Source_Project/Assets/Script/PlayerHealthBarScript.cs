using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBarScript : MonoBehaviour
{
    public Slider HpSlider;
    public void SetMaxHealth(int health)
    {
        HpSlider.maxValue = health;
        HpSlider.value = health;
    }
    public void SetHealth(int health)
    {
        HpSlider.value = health;
    }

}
