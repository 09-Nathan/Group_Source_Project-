using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHPScript : MonoBehaviour
{
    public Slider BossHpSlider;
    public void SetMaxHealth(int health)
    {
        BossHpSlider.maxValue = health;
        BossHpSlider.value = health;
    }
    public void SetHealth(int health)
    {
        BossHpSlider.value = health;
    }
}
