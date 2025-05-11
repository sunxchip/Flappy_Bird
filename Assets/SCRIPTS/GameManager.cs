using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score;

    public bool isPlaying;
    public BirdController bc;

        //ui

    public TextMeshProUGUI scoreText;
    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    
    //점수증가함수
    public void UpdateScore()
    {
        score++;
        scoreText.text=$"score: {score}";

        if(score > PlayerPrefs.GetInt("BScore"))
        {
            PlayerPrefs.SetInt("BScore",score);
            Debug.Log($"BEST: {score}");
        }
    }
    public void SetPlaying(bool playing)
    {
        isPlaying=playing;
        bc.rb.simulated = playing;
    }

    public void GameOver()
    {
        SetPlaying(false);
        Time.timeScale=0;
    }
}
