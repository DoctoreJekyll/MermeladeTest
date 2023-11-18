using UnityEngine;

namespace Player
{
    public class PlayerSteps : MonoBehaviour
    {

        private AudioSource audioSource;
        [SerializeField] private AudioClip stepClip;
        
        // Start is called before the first frame update
        void Start()
        {
            audioSource = GetComponentInChildren<AudioSource>();
        }

        public void Step()
        {
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            audioSource.PlayOneShot(stepClip);
        }
        
    }
}
