using System;
using UnityEngine;

namespace Player
{
    public class PlayerAnim : MonoBehaviour
    {

        private Animator animator;
        private PlayerMovement playerMovement;

        private void Start()
        {
            animator = GetComponent<Animator>();
            playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            if (playerMovement.movementDirections.x != 0 || playerMovement.movementDirections.y != 0)
            {
                animator.Play("Walk");
            }
            else
            {
                animator.Play("Idle");
            }
        }
    }
}
