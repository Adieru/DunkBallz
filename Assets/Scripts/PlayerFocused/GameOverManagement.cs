using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManagement : MonoBehaviour
{

    [SerializeField] bool GameOver;

    private Vector3 EnterStart_Pos;
    private Vector3 EnterEnd_Pos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Basket"))
        {
            EnterStart_Pos = this.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Basket"))
        {
            EnterEnd_Pos = this.transform.position;
        }

        if((Mathf.Abs(EnterStart_Pos.y) > Mathf.Abs(EnterEnd_Pos.y)) && GameOver)
        {
            GameOverFunc();
        }
    }


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
