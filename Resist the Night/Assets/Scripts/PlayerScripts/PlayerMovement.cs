using System;
using UnityEngine;

namespace PlayerScripts
{
    public class PlayerMovement : MonoBehaviour
    {
        private Animator animator;
        private Rigidbody2D rb;
        private Camera cam;
    
        private Vector2 movement;
        private Vector2 mousePos;

        private static readonly int IsMoving = Animator.StringToHash("isMoving");
        private const float MovementSpeed = 5f;
        private const float AngleAdjust = 90f;
        private const int Zero = 0;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            cam = Camera.main;
        }
    
        private void Update()
        {
            Move();
            PointAtCrosshair();
        }
    
        private void Move()
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + movement.normalized * (MovementSpeed * Time.fixedDeltaTime));
        
            AnimationCheck();
        }
    
        private void PointAtCrosshair()
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            var lookDirection = mousePos - rb.position;
            rb.rotation = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - AngleAdjust;
        }

        private void AnimationCheck()
        {
            double tolerance = 0.01f;
            animator.SetBool(IsMoving, (Math.Abs(movement.x - Zero) > tolerance || Math.Abs(movement.y - Zero) > tolerance));
        }
    }
}
