using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoretextscript : MonoBehaviour
{
    public Text ScoreText;
    public float score=0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loaded");
    }
    public void Update()
    {
        Debug.Log("ongoing");
        ScoreText.text = ("" + score);
    }

    public void scoreRock()
    {
        score += 5;
    }
}
