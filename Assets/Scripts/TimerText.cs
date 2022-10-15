using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public float timer = 20;
    public TextMeshProUGUI Timertext;
    public int TimerInt;
    public ScoreScript scoreScript;


    void Start()
    {
        Timertext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        TimerInt = Mathf.RoundToInt(timer);
        Timertext.text = (TimerInt + " Secondes");


        if (TimerInt > 0)
        {
            timer -= Time.deltaTime;
        }

        if (TimerInt == 0)
        {
            scoreScript.score.text = "Perdu !";
        }


    }

    
}
