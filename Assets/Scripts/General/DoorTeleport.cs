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
        private AudioSource aSource;
        
        [SerializeField] private GameObject necesaryObj;

        private void Start()
        {
            aSource = GameObject.FindWithTag("Sound").GetComponent<AudioSource>();
            activeDesactiveRooms = GetComponent<ActiveDesactiveRooms>();
            playerObjToTeleport = FindObjectOfType<PlayerMovement>().gameObject;
            playerNewLocation = this.gameObject.transform.GetChild(0);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player") && !necesaryObj.activeSelf)
            {
                aSource.PlayOneShot(aSource.clip);
                activeDesactiveRooms.ActiveDesactiveRoomsEvent();
                playerObjToTeleport.transform.position = playerNewLocation.position;
            }
        }
    }
}
