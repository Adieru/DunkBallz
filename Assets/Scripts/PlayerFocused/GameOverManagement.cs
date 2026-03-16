using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManagement : MonoBehaviour
{

    [SerializeField] bool GameOver;
    bool HasCrossedSafeDistance = false;

    [SerializeField] float SafeDistance;

    private Vector3 Enter_Pos;
    private Vector3 Exit_Pos;


    private void Start()
    {
        Debug.Log("Check");
        Enter_Pos = this.transform.position;
    }

    private void Update()
    {
        float distance = Vector2.Distance(this.transform.position, Enter_Pos);

        if(distance > SafeDistance && !HasCrossedSafeDistance && GameOver)
        {
            Debug.Log("GameOver");
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Basket"))
        {
            Enter_Pos = this.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Basket"))
        {
            Exit_Pos = this.transform.position;
        }

        if((Mathf.Abs(Enter_Pos.y) > Mathf.Abs(Exit_Pos.y)) && GameOver)
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
