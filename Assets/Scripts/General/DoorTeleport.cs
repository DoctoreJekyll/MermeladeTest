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
        
        [SerializeField] private bool doorUsed;

        private void Start()
        {
            activeDesactiveRooms = GetComponent<ActiveDesactiveRooms>();
            playerObjToTeleport = FindObjectOfType<PlayerMovement>().gameObject;
            playerNewLocation = this.gameObject.transform.GetChild(0);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                activeDesactiveRooms.ActiveDesactiveRoomsEvent();
                playerObjToTeleport.transform.position = playerNewLocation.position;
            }
        }
    }
}
