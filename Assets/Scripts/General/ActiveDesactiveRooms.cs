using System;
using UnityEngine;

namespace General
{
    public class ActiveDesactiveRooms : MonoBehaviour
    {

        [Header("Activable Rooms")]
        [SerializeField] private GameObject[] objectsToActive;
        [Header("Desactivable Rooms")]
        [SerializeField] private GameObject[] objectsToDesactive;

        public void ActiveDesactiveRoomsEvent()
        {
            Debug.Log("event raising");
            ActivateArrayObjs();
            DesactivateArrayObjs();
        }

        private void ActivateArrayObjs()
        {
            foreach (var objs in objectsToActive)
            {
                ObjsState(objs, true);
                Debug.Log("activing");
            }
        }


        private void DesactivateArrayObjs()
        {
            foreach (var objs in objectsToDesactive)
            {
                ObjsState(objs, false);
                Debug.Log("desactiving");
            }
        }

        private void ObjsState(GameObject obj, bool state)
        {
            obj.SetActive(state);
        }
        
        
    }
}
