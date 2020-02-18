﻿using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    private Vector2 movement;
    private Vector2 mousePos;

    private Animator animator;
    private Rigidbody2D rb;
    private Camera cam;
    private static readonly int IsMoving = Animator.StringToHash("isMoving");

    private const float AngleAdjust = 90f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        cam = Camera.main;
    }
    
    void Update()
    {
        Move();
        LookAtMouse();
    }

    private void LookAtMouse()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - AngleAdjust;
        rb.rotation = angle;
    }

    private void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        AnimationCheck();

        rb.MovePosition(rb.position + movement.normalized * (movementSpeed * Time.fixedDeltaTime));
    }

    private void AnimationCheck()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetBool(IsMoving, true);
        }
        else
        {
            animator.SetBool(IsMoving, false);
        }
    }
}
