using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMangement : MonoBehaviour
{
    [SerializeField] GameObject ScorePanel;
    [SerializeField] TextMeshProUGUI ScoreText;

    [SerializeField] AudioSource ScoreAudioSource;
    [SerializeField] AudioClip ScoreAudioClip;

    int Score = 0;

    private void Start()
    {
        ScoreText.text = "Score : " + Score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Basket"))
        {
            ScoreAudioSource.PlayOneShot(ScoreAudioClip);

            Score++;
            ScoreText.text = "Score : " + Score;

        }


    }

}
