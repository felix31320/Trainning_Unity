using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static int Score = 0;
    public TextMeshProUGUI score;
    public TimerScript TimerT;

    

    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        score.text = "Score : " + Score;



        if (TimerT.timer <= 0)
        {
            score.text = "Perdu !";
        }
        
    }
}
