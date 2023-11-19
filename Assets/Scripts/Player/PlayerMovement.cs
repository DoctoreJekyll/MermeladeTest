using System;
using General;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {

        private Rigidbody2D rb2d;
        public Vector2 movementDirections;

        [SerializeField] private float speed;
        [SerializeField] private float runAccelAmount;
        [SerializeField] private float runDeccelAmount;
        
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            PlayerInputsValue();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 10;
            }else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = 3;
            }
        }

        private void FixedUpdate()
        {
            if (GameStatusController.instance.IsOnGameplay())
            {
                PlayerMoveImprove();
            }
            else
            {
                rb2d.velocity = Vector2.zero;
            }
        }

        private void PlayerInputsValue()
        {
            movementDirections.x = Input.GetAxisRaw("Horizontal");
            movementDirections.y = Input.GetAxisRaw("Vertical");
        }
        
        private void PlayerMoveImprove()
        {
            Vector2 rate = new Vector2(SpeedDelta().x * AccelerationRate().x, SpeedDelta().y * AccelerationRate().y);
            rb2d.AddForce(rate, ForceMode2D.Force);
        }

        private Vector2 TargetSpeed()
        {
            Vector2 targetSpeed = new Vector2(movementDirections.x, movementDirections.y).normalized * speed;
            
            return targetSpeed;
        }

        private Vector2 AccelerationRate()
        {
            Vector2 accelRate = new Vector2((Mathf.Abs(TargetSpeed().x) > 0.01f) ? runAccelAmount : runDeccelAmount,
                (Mathf.Abs(TargetSpeed().y) > 0.01f) ? runAccelAmount : runDeccelAmount);
            
            return accelRate;
        }

        private Vector2 SpeedDelta()
        {
            Vector2 sDelta = new Vector2(TargetSpeed().x - rb2d.velocity.x, TargetSpeed().y - rb2d.velocity.y);
            return sDelta;
        }
    }
}
