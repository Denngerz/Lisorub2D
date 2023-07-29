using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    Rigidbody2D rb;
    Vector2 movement;
    private bool isFacingRight = true;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("Fight");
        }
        Flip();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * 0.02f);
    }

    void Flip()
    {
        if (isFacingRight == true && movement.x < 0f || isFacingRight == false && movement.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
