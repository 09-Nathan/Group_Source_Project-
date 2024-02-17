using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text txtScore, txtTime;
    public float Timer;

     float deci;
    public static int Score;
     public GameObject o1,o2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        deci = Mathf.Round(Timer%100f);
        Total();
        Spawncount();
        if (Timer == 0 )
        {

        }
    }
    
    void Total()
    {
        txtScore.text = Score.ToString();
        txtTime.text = deci.ToString();
    }

    void Spawncount()
    {
        if(Timer < 60)
        {
            o1.SetActive(true);
        }
        if (Timer<50)
        {
            o2.SetActive(true);
        }
    }
}
