using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static int Score = 0;
    TextMeshPro score;

    void Start()
    {
        score = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + Score;
    }
}
