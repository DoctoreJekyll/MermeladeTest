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
            GetFurnitureChilds();
            EnableFurnituresFunction();
        }

        private void GetFurnitureChilds()
        {
            foreach (Transform child in this.gameObject.transform)
            {
                furnitureContenedor.Add(child.gameObject.GetComponent<SpriteRenderer>());
            }
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
