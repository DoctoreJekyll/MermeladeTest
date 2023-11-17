using System;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public class EnableFurnitures : MonoBehaviour
    {

        [SerializeField] private List<SpriteRenderer> furnitureContenedor = new List<SpriteRenderer>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("Activando movidas");
                
                for (int i = 0; i < furnitureContenedor.Count; i++)
                {
                    furnitureContenedor[i].enabled = true;
                }
            }
        }
    }
}
