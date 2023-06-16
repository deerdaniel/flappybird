using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    private AudioSource managerSource;
    public AudioClip buttonSound;
    public AudioClip gameOverSound;
    public int points = 0;
    public int golds = 0;
    public int bestScore = 0;
    public int currentScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreGoldText;
    [SerializeField]public TextMeshProUGUI bestScoreText;

    public void StartGame()
    {
        
        Time.timeScale = 1;
        
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);       
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        

    }

    public void OnGameOver()
    {
        
        ShowLoseUI();
        Time.timeScale = 0;
        
    }

    public void UpdateScore()
    {
        
        points++;
        scoreText.text = points.ToString();
        
        CheckHighScore();
        
    }

    private void CheckHighScore()
    {      

        if (PlayerPrefs.GetInt("BestScore", 0)  < points)
        {
            PlayerPrefs.SetInt("BestScore", points);
            //PlayerPrefs.Save();
            
        }
    }

    private void UpdateBestScore()
    {
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void UpdateGoldScore()
    {
        golds++;
        scoreGoldText.text = golds.ToString();
    }

    public void ResetHighScore()
    {
        
        PlayerPrefs.SetInt("BestScore",0);
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    void Update()
    {
        UpdateBestScore();
    }
}
