using System;
using UnityEngine;

namespace General
{
    public class InventaryBool : MonoBehaviour
    {

        #region Singleton
        public static InventaryBool instance { get; private set; }

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(this);
            }
            else
            {
                instance = this;
            }
        }

        #endregion
        
        public bool hasobj00;
        public bool hasobj01;
        public bool hasobj02;
        public bool hasobj03;

    }
}
