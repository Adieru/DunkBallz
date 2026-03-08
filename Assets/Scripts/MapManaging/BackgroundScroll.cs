using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    private MeshRenderer BGmeshRenderer;
    private float scrollSpeed = 0.01f;


    private void Start()
    {
        BGmeshRenderer = this.GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        BGmeshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);

        this.transform.position = new Vector3(playerTransform.position.x, this.transform.position.y, this.transform.position.z);
    }
}
