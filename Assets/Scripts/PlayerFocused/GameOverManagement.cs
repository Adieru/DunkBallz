using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManagement : MonoBehaviour
{

    [SerializeField] bool GameOver;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("LimitZone") && GameOver)
        {
            GameOverFunc();
        }

    }

    private void GameOverFunc()
    {
        Time.timeScale = 0;


        //Show gameover panel

    }


}
