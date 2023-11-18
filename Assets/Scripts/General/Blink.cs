using System;
using System.Collections;
using UnityEngine;

namespace General
{
    public class Blink : MonoBehaviour
    {

        private Animator anim;

        [SerializeField] private float waitToBlinkTime;
        
        private IEnumerator Start()
        {
            anim = GetComponent<Animator>();
            yield return new WaitForSeconds(0.75f);
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
            waitToBlinkTime = 4f;
        }
    }
}
