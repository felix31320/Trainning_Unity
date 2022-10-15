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
    public PauseMenu arrete;

    

    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        score.text = "Score : " + Score;

        if(Score == 4 && arrete.isPaused == false)
        {
            arrete.PauseGame();
        }

        if (TimerT.timer <= 0)
        {
            score.text = "Perdu !";
            TimerT.enabled = true;
        }
        
    }
}
