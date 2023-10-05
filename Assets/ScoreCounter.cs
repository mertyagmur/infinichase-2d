using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    public int score;
    void Update()
    {
        score = (int)Time.time;
        scoreText.text = "Score: " + score.ToString();
    }
}
