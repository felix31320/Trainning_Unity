using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timer = 20f;
    public TextMeshProUGUI Timertext;
    public int TimerInt;
    


    void Start()
    {
        Timertext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        TimerInt = Mathf.RoundToInt(timer);
        Timertext.text = (TimerInt + " Secondes");


        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

    }

    
}
