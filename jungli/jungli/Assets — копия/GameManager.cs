using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int GenScore;
    public int endscore;
    public int endbestscore;

    public Text ScoreText;
    public Text BestScoreText;
    public float highscore;

    public Text ScoreText1;
    public Text BestScoreText1;
    public float highscore1;

    public Text ScoreText2;
    public Text BestScoreText2;
    public float highscore2;

    public Text endScoreText;
    public Text endBestScoreText;

    public Text endScoreText1;
    public Text endBestScoreText1;

    public Text endScoreText2;
    public Text endBestScoreText2;

    private void Start()
    {
        highscore = PlayerPrefs.GetFloat("GenScore");
        BestScoreText.text ="Best: " + highscore;
        endBestScoreText.text = "Best: " + highscore;

        highscore1 = PlayerPrefs.GetFloat("GenScore1");
        BestScoreText1.text = "Best: " + highscore1;
        endBestScoreText1.text = "Best: " + highscore1;

        highscore2 = PlayerPrefs.GetFloat("GenScore2");
        BestScoreText2.text = "Best: " + highscore2;
        endBestScoreText2.text = "Best: " + highscore2;
    }
    
    public void AddScore(int score)
    { 
        GenScore += score;

        if (highscore < GenScore)
        {
            PlayerPrefs.SetFloat("GenScore", GenScore);
        }
        ScoreText.text = "Score: " + GenScore;
        endScoreText.text = "Your Score: " + GenScore;

        if (highscore1 < GenScore)
        {
            PlayerPrefs.SetFloat("GenScore1", GenScore);
        }
        ScoreText1.text = "Score: " + GenScore;
        endScoreText1.text = "Your Score: " + GenScore;

        if (highscore2 < GenScore)
        {
            PlayerPrefs.SetFloat("GenScore2", GenScore);
        }
        ScoreText2.text = "Score: " + GenScore;
        endScoreText2.text = "Your Score: " + GenScore;
    }

    
}
