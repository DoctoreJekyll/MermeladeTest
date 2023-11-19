using System;
using UI;
using UnityEngine;

namespace General
{
    public class CatTxt : MonoBehaviour
    {
        
        [SerializeField] private TextContenedor txtInfo;
        private DialogueTyper dialogueTyper;

        private bool triggerEnter;
        private float txtCouldDown;
        
        // Start is called before the first frame update
        void Start()
        {
            triggerEnter = false;
            dialogueTyper = FindObjectOfType<DialogueTyper>();
        }

        private void Update()
        {
            if (triggerEnter)
            {
                txtCouldDown += Time.deltaTime;
                if (txtCouldDown >= 5f)
                {
                    triggerEnter = false;
                    txtCouldDown = 0f;
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                ActiveTxtPanel();
                triggerEnter = true;
            }
        }
        
        private void ActiveTxtPanel()
        {
            dialogueTyper.StartTextCorroutine(txtInfo.dialogueText);
        }
    }
}
