using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;

    [SerializeField] TextMeshProUGUI HighScoreText;


    private void Start()
    {
        Time.timeScale = 0;

        if(HighScoreText != null) { ShowHighScore(HighScoreText); }
        

    }

    //PlayerButton
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    //Restart
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    //MainMenu
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Play button
    public void UnPause()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }

    //Show highscore in Menu
    public void ShowHighScore(TextMeshProUGUI HighScoreText)
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore").ToString();
        }
        else
        {
            HighScoreText.text = "High Score : 0";
        }
    }

}
