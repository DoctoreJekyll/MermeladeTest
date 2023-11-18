using System;
using UnityEngine;

namespace General
{
    public class Activate : MonoBehaviour
    {
        [SerializeField] private GameObject musicObj;
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            AudioSource audioSource = musicObj.GetComponent<AudioSource>();
            audioSource.enabled = true;
        }
    }
}
