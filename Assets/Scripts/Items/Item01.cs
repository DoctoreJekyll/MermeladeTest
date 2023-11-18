using System;
using General;
using UI;
using UnityEngine;

namespace Items
{
    public class Item01 : MonoBehaviour
    {

        [SerializeField] private TextContenedor txtInfo;
        private DialogueTyper dialogueTyper;

        private void Start()
        {
            dialogueTyper = FindObjectOfType<DialogueTyper>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            ActiveTxtPanel();
            this.gameObject.SetActive(false);
        }

        private void ActiveTxtPanel()
        {
            dialogueTyper.StartTextCorroutine(txtInfo.dialogueText);
        }
    }
}
