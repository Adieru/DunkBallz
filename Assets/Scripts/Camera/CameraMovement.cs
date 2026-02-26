using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset;
    private Transform CameraTransform;

    private void Start()
    {
        CameraTransform = this.GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        CameraTransform.position = player.transform.position + offset;
    }
}

