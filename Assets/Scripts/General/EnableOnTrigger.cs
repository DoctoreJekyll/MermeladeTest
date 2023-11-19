using System;
using UnityEngine;

namespace General
{
    public class EnableOnTrigger : MonoBehaviour
    {

        [SerializeField] private GameObject objToEnable;
        [SerializeField] private Animator test;


        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                GameStatusController.instance.ChangeGameStatusTo(GameStatusController.GameStatus.Dialogue);
                objToEnable.SetActive(true);
                test.Play("Idle");
                test.enabled = false;
            }
        }
    }
}
