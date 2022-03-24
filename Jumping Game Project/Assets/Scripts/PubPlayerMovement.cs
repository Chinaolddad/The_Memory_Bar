using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubPlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Veritical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

   void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
        
    }

}
