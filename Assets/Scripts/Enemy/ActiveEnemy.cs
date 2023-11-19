using System;
using UnityEngine;

namespace Enemy
{
    public class ActiveEnemy : MonoBehaviour
    {

        [SerializeField] private GameObject enemyObj;

        private void OnTriggerEnter2D(Collider2D col)
        {
            enemyObj.SetActive(true);
        }
    }
}
