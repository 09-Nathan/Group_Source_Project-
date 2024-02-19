using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScip : MonoBehaviour
{
    public Text TimerText;
    public float TimerStart;
    float timeremaining;
    int OngoingTimer;
    // Start is called before the first frame update
    void Start()
    {
        timeremaining = TimerStart;
    }

    // Update is called once per frame
    void Update()
    {
        timeremaining -= Time.deltaTime;
        OngoingTimer = Mathf.FloorToInt(timeremaining % 60);
        TimerText.text = (""+OngoingTimer.ToString());
    }
}
