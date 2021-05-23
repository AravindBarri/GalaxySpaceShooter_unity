using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score;

    Text ScoreText;
    private void Start()
    {
        ScoreText = this.GetComponent<Text>();
    }
    public void IncrementScore()
    {
        Score +=1;
        ScoreText.text = "SCORE : "+Score;
    }
}
