using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text txtScore, txtTime;
    public float Timer;
    public static int Score;
    public GameObject o1,o2;
    string format;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        float Min = Mathf.Floor(Timer/60);
        float Sec = Mathf.RoundToInt(Timer % 60);
        format = string.Format("{0:00}:{1:00}", Min, Sec);
        Total();
        Spawncount();
        if (Timer == 0 )
        {

        }
    }
    
    void Total()
    {
        txtScore.text = Score.ToString();
        txtTime.text = format;
    }

    void Spawncount()
    {
        if(Timer < 70)
        {
            o1.SetActive(true);
        }
        if (Timer<50)
        {
            o2.SetActive(true);
        }
    }
}
