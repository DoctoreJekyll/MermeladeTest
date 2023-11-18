using General;
using UnityEngine;

namespace Player
{
    public class FlipPlayer : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        private Vector2 direction;
        
        // Start is called before the first frame update
        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            if (GameStatusController.instance.IsOnGameplay())
            {
                DirectionValue();
                Flip();
            }
        }

        private void DirectionValue()
        {
            direction.x = Input.GetAxisRaw("Horizontal");
        }

        private void Flip()
        {
            if (direction.x >= 1)
            {
                spriteRenderer.flipX = true;
            }
            else if (direction.x <= -1)
            {
                spriteRenderer.flipX = false;
            }
        }
    }
}
