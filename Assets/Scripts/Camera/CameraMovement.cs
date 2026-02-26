using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset;

    private bool CheckThreshold = false;



    private void Start()
    {
        offset = player.transform.position - transform.position;
    }

    private void LateUpdate()
    {
        if (CheckThreshold)
        {
            this.transform.position = player.transform.position - offset;
        }
    }



}
