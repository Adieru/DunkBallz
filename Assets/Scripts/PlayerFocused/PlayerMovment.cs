using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] float jumpForce;
    private bool JumpAllowed = false;
    private Rigidbody2D playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        //Constant forward movement
        playerRB.velocity = new Vector2(speed, playerRB.velocity.y);

        //Jump
        if(JumpAllowed)
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            JumpAllowed = false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpAllowed = true;
        }
    }
}
