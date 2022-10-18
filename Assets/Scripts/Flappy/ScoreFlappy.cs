using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFlappy : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    public Text EndScore;
    
    

    public int Score;
    public int HighScore;

    void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("ScoreFlappy").ToString();
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.timeScale != 0)
        {
            Score += 1;
        }
       if (Time.timeScale == 0 && PlayerPrefs.GetInt("ScoreFlappy") < Score)
        {
            PlayerPrefs.SetInt("ScoreFlappy", Score);
        }

        ScoreText.text = Score.ToString();
        EndScore.text = Score.ToString();

    }
}
