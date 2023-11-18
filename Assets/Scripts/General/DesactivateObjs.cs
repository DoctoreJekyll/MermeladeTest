using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace General
{
    public class DesactivateObjs : MonoBehaviour
    {

        [SerializeField] private List<SpriteRenderer> spriteRenderersList = new List<SpriteRenderer>();

        // Start is called before the first frame update
        void Start()
        {
            FindSpriteRenderers();
        }

        public void FindSpriteRenderers()
        {
            ClearSpriteRendererList();            

            GameObject[] furnitureObjs = GameObject.FindGameObjectsWithTag("Furniture");

            foreach (GameObject furnitureObject in furnitureObjs)
            {
                SpriteRenderer spriteRenderer = furnitureObject.GetComponent<SpriteRenderer>();
                spriteRenderersList.Add(spriteRenderer);
            }
        }

        private void ClearSpriteRendererList()
        {
            spriteRenderersList.Clear();
        }

        private void ClearRandomObjectFromList()
        {
            if (spriteRenderersList.Count > 0)
            {
                int randomIndex = Random.Range(0, spriteRenderersList.Count);
                spriteRenderersList[randomIndex].enabled = false;
                spriteRenderersList.RemoveAt(randomIndex);
            }
        }

        public void ClearSpriteWhenBlink()
        {
            ClearRandomObjectFromList();
            ClearRandomObjectFromList();
        }
        
    }
}
