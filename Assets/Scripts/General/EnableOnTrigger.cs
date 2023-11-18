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
                objToEnable.SetActive(true);
                test.enabled = false;
            }
        }
    }
}
