using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wisard : MonoBehaviour
{
    [Header("Player velocity")]
    int xVelocity = 5;
    int yVelocity = 8;
    Animator animator;
    Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        updatePlayerPosition();
    }

    private void updatePlayerPosition()
    {
        float moveInput = Input.GetAxis("Horizontal");

        float jumpInput = Input.GetAxis("Jump");
        if (moveInput < 0)
        {
            rigidBody.velocity = new Vector2(-xVelocity, rigidBody.velocity.y);
            animator.Play("Base Layer.Run", 0, 0);
        }
        else if (moveInput > 0)
        {
            rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
            animator.Play("Base Layer.Run", 0, 0);
        }

        if (jumpInput > 0)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, yVelocity);
            animator.Play("Base Layer.Jump", 0, 0);
        }
    }

    private void Animate()
    {
        
    }
}
