using System;
using General;
using Player;
using UnityEngine;

namespace Enemy
{
    public class EnemyMove : MonoBehaviour
    {
        private SpriteRenderer enemySprite;
        private Transform playerTransform;

        [SerializeField] private float speed;

        private void Start()
        {
            playerTransform = FindObjectOfType<PlayerMovement>().transform;
            enemySprite = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (GameStatusController.instance.IsOnGameplay())
            {
                EnemyFollow();
                FlipEnemy();
            }
        }

        private void EnemyFollow()
        {
            if (!PlayerIsClose())
            {
                Vector3 direction = (playerTransform.position - transform.position).normalized;
                transform.Translate(direction * (speed * Time.deltaTime));
            }
        }

        private void FlipEnemy()
        {
            enemySprite.flipX = !(playerTransform.position.x < this.transform.position.x);
        }

        private bool PlayerIsClose()
        {
            if (Vector2.Distance(transform.position, playerTransform.transform.position) < 0.25f)
            {
                return true;
            }

            return false;

        }
    }
}
