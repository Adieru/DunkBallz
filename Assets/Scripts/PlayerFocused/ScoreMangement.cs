using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMangement : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;

    [SerializeField] AudioSource ScoreAudioSource;
    [SerializeField] AudioClip ScoreAudioClip;

    int Score = 0;

    private void Start()
    {
        ScoreText.text = "Score : " + Score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Basket"))
        {
            ScoreAudioSource.PlayOneShot(ScoreAudioClip);

            Score++;
            ScoreText.text = "Score : " + Score.ToString();

        }

    }



}
