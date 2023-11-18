using System;
using UI;
using UnityEngine;

namespace General
{
    public class BlockDoor : MonoBehaviour
    {
        private BoxCollider2D doorTrigger;

        [SerializeField] private GameObject necesaryObj;
        [SerializeField] private bool doorIsBlock;

        [SerializeField] private GameObject overlapObj;
        [SerializeField] private Vector2 boxCheckSize;
        [SerializeField] private LayerMask layerToCheckPlayer;
        [SerializeField] private TextContenedor txt;
        private DialogueTyper dialogueTyper;
        
        // Start is called before the first frame update
        void Start()
        {
            dialogueTyper = FindObjectOfType<DialogueTyper>();
        }

        // Update is called once per frame
        void Update()
        {
            doorIsBlock = !HisOBjIsActive();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!doorIsBlock)
            {
                dialogueTyper.StartTextCorroutine(txt.dialogueText);
            }
        }

        private bool HisOBjIsActive()
        {
            return necesaryObj.activeSelf;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawCube(overlapObj.transform.position, boxCheckSize);
        }
    }
}
