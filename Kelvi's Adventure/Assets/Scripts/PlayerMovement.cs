using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    Vector2 movement;

    private void Update()
    {
        MovementInput();
    }

    private void FixedUpdate()
    {
        // move the player
        rb.velocity = movement * moveSpeed;
    }

    private void MovementInput()
    {
        // get move input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        // assign the direction of the player
        movement = new Vector2 (moveX, moveY).normalized;
        if (moveX > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveX < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
