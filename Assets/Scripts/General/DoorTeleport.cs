using GameEvents;
using Player;
using UnityEngine;

namespace General
{
    public class DoorTeleport : MonoBehaviour
    {

        private GameObject playerObjToTeleport;
        private Transform playerNewLocation;

        [SerializeField] private GameEvent doorEvent;

        private void Start()
        {
            playerObjToTeleport = FindObjectOfType<PlayerMovement>().gameObject;
            playerNewLocation = this.gameObject.transform.GetChild(0);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                doorEvent.Raise();
                playerObjToTeleport.transform.position = playerNewLocation.position;
            }
        }
    }
}
