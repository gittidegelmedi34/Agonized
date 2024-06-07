using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform tr;
    public Rigidbody2D rb;
    private bool isJumping;
    private bool isMovingRight;
    private bool isMovingLeft;
    
    public float jumpingForce = 30f;
    public float movingForce = 50f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            isMovingRight = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            isMovingLeft = true;
        }
    }
    void FixedUpdate()
    {
        if (isJumping)
        {
            rb.AddForce(Vector2.up * jumpingForce, ForceMode2D.Impulse);
            isJumping = false;
        }
        if (isMovingLeft)
        {
            rb.AddForce(Vector2.left * movingForce, ForceMode2D.Impulse);
            isMovingLeft = false;
        }
        if (isMovingRight)
        {
            rb.AddForce(Vector2.right * movingForce, ForceMode2D.Impulse);
            isMovingRight = false;
        }

    }
}
