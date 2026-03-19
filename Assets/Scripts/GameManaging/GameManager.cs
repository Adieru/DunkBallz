using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;


    private void Start()
    {
        Time.timeScale = 0;
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

}
