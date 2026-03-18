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

    [SerializeField] GameObject GameOverPanel;

    //Audio
    [SerializeField] AudioSource GameOverSource;
    [SerializeField] AudioClip DeathSFX;


    private void Start()
    {

        GameOverPanel.SetActive(false);

        Debug.Log("Check");
        Enter_Pos = this.transform.position;
    }

    private void Update()
    {
        float distance = Vector2.Distance(this.transform.position, Enter_Pos);

        if(distance > SafeDistance && !HasCrossedSafeDistance && GameOver)
        {
           StartCoroutine(GameOverFunc());

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
            StartCoroutine(GameOverFunc());
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("LimitZone") && GameOver)
        {
            StartCoroutine(GameOverFunc());
        }

    }

    IEnumerator GameOverFunc()
    {
        

        yield return new WaitForSeconds(0.5f);

        this.gameObject.SetActive(false);
        GameOverSource.PlayOneShot(DeathSFX);

        GameOverPanel.SetActive(true);

        Time.timeScale = 0;

    }


}
