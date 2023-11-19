using System.Collections;
using UnityEngine;

namespace General
{
    public class MusicOn : MonoBehaviour
    {
        private AudioSource aSource;
        private float initVolume;
        private float finalVolume;
        
        void Start()
        {
            aSource = GetComponent<AudioSource>();
            initVolume = aSource.volume;

            aSource.volume = 0f;
        }

        public void StartFadeCorroutine()
        {
            aSource.enabled = true;
            StartCoroutine(StartFadeMusic());
        }

        IEnumerator StartFadeMusic()
        {
            while (aSource.volume < initVolume)
            {
                aSource.volume += 0.002f;
                yield return new WaitForEndOfFrame();
            }
        }
        

    }
}
