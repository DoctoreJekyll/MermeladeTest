using System;
using UnityEngine;

namespace General
{
    public class RefillFurniture : MonoBehaviour
    {

        private DesactivateObjs desactivateObjs;

        private void Start()
        {
            desactivateObjs = FindObjectOfType<DesactivateObjs>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            desactivateObjs.FindSpriteRenderers();
        }
    }
}
