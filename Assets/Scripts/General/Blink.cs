using System;
using UnityEngine;

namespace General
{
    public class Blink : MonoBehaviour
    {

        private Animator anim;

        [SerializeField] private float waitToBlinkTime;
        
        private void Start()
        {
            anim = GetComponent<Animator>();
            PlayBlink();
        }


        private void Update()
        {
            waitToBlinkTime -= Time.deltaTime;
            
            if (waitToBlinkTime <= 0)
            {
                PlayBlink();
                ResetBlinTime();
            }
        }


        private void PlayBlink()
        {
            anim.Play("Blink", -1,0f);
        }

        private void ResetBlinTime()
        {
            waitToBlinkTime = 5f;
        }
    }
}
