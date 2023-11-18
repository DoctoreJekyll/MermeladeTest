using System;
using GameEvents;
using Player;
using UnityEngine;

namespace General
{
    public class DoorTeleport : MonoBehaviour
    {

        private GameObject playerObjToTeleport;
        private Transform playerNewLocation;
        private ActiveDesactiveRooms activeDesactiveRooms;
        
        [SerializeField] private GameObject necesaryObj;

        private void Start()
        {
            activeDesactiveRooms = GetComponent<ActiveDesactiveRooms>();
            playerObjToTeleport = FindObjectOfType<PlayerMovement>().gameObject;
            playerNewLocation = this.gameObject.transform.GetChild(0);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player") && !necesaryObj.activeSelf)
            {
                activeDesactiveRooms.ActiveDesactiveRoomsEvent();
                playerObjToTeleport.transform.position = playerNewLocation.position;
            }
        }
    }
}
