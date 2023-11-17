using System;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public class EnableFurnitures : MonoBehaviour
    {

        [SerializeField] private List<SpriteRenderer> furnitureContenedor = new List<SpriteRenderer>();

        private void OnEnable()
        {
            EnableFurnituresFunction();
        }

        private void EnableFurnituresFunction()
        {
            for (int i = 0; i < furnitureContenedor.Count; i++)
            {
                furnitureContenedor[i].enabled = true;
            }
        }
    }
}
