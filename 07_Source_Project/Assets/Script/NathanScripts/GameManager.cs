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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        deci = Mathf.Round(Timer%60f);
        Total();
        if(Timer == 0 )
        {

        }
    }
    
    void Total()
    {
        txtScore.text = Score.ToString();
        txtTime.text = deci.ToString();
    }
}
