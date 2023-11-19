using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ActiveItemOnUI : MonoBehaviour
    {

        [SerializeField] private GameObject ownObj;
        
        private bool objIsTake;
        private Image image;

        private void Start()
        {
            image = GetComponent<Image>();
        }

        private void Update()
        {
            objIsTake = !ownObj.activeSelf;

            if (objIsTake)
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
            }
            else
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0.5f);
            }
        }
    }
}
