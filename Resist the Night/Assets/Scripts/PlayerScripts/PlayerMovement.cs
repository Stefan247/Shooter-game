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
        private const float AngleAdjust = 90f;
        private const int ZERO = 0;
        private float movementSpeed = 5f;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            cam = Camera.main;
        }
    
        void Update()
        {
            Move();
            PointAtCrosshair();
        }
    
        private void Move()
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + movement.normalized * (movementSpeed * Time.fixedDeltaTime));
        
            AnimationCheck();
        }
    
        private void PointAtCrosshair()
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lookDirection = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - AngleAdjust;
            rb.rotation = angle;
        }

        private void AnimationCheck()
        {
            if (movement.x != ZERO || movement.y != ZERO)
            {
                animator.SetBool(IsMoving, true);
            }
            else
            {
                animator.SetBool(IsMoving, false);
            }
        }
    }
}
