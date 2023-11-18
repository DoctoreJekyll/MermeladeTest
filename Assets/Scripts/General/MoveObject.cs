using DG.Tweening;
using UnityEngine;

namespace General
{
    public class MoveObject : MonoBehaviour
    {

        private Vector2 initialPos;
        private Vector2 nextPos;
        [SerializeField] private Vector2 add;
        
        // Start is called before the first frame update
        void Start()
        {
            initialPos = transform.position;
            nextPos = initialPos + add;
            Movement();
        }

        private void Movement()
        {
            transform.DOMove(nextPos, 2f).SetEase(Ease.Linear).OnComplete(() =>
            {
                (initialPos, nextPos) = (nextPos, initialPos);
                Movement();
            });
        }


    }
}
