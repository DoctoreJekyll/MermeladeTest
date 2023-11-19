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
        private AudioSource aSource;

        private void Start()
        {
            dialogueTyper = FindObjectOfType<DialogueTyper>();
            aSource = GameObject.Find("PickItemSound").GetComponent<AudioSource>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            ActiveTxtPanel();
            aSource.PlayOneShot(aSource.clip);
            this.gameObject.SetActive(false);
        }

        private void ActiveTxtPanel()
        {
            dialogueTyper.StartTextCorroutine(txtInfo.dialogueText);
        }
    }
}
