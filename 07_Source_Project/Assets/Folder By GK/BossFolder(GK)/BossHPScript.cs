using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHPScript : MonoBehaviour
{
    public Slider BossHpSlider;
    private void Start()
    {
        BossHpSlider = GameObject.Find("BossBarPlayer(GK)").GetComponent<Slider>();
    }
    public void BossSetMaxHealth(int health)
    {
        BossHpSlider.maxValue = health;
        BossHpSlider.value = health;
    }
    public void BossSetHealth(int health)
    {
        BossHpSlider.value = health;
    }
}
