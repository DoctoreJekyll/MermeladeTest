using System;
using UnityEngine;

namespace UI
{
    public class Pause : MonoBehaviour
    {

        [SerializeField] private GameObject pausePanel;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pausePanel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        public void ResetTime()
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
