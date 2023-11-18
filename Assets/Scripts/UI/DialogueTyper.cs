using System;
using System.Collections;
using General;
using TMPro;
using UnityEngine;

namespace UI
{
    public class DialogueTyper : MonoBehaviour
    {
        [SerializeField] private float letterPauseTime;
        [SerializeField] private TMP_Text textObj;
        [SerializeField] private GameObject panelObj;

        private void Start()
        {
            panelObj.SetActive(false);
        }

        public void StartTextCorroutine(string message)
        {
            GameStatusController.instance.ChangeGameStatusTo(GameStatusController.GameStatus.Dialogue);
            panelObj.SetActive(true);
            StartCoroutine(DialogueTyping(message));
        }
        
        IEnumerator DialogueTyping(string message)
        {
            textObj.text = "";
            
            foreach (var letter in message.ToCharArray())
            {
                textObj.text += letter;
                yield return new WaitForSeconds(letterPauseTime);
            }

            yield return new WaitForSeconds(0.75f);
            GameStatusController.instance.ChangeGameStatusTo(GameStatusController.GameStatus.Gameplay);
            panelObj.SetActive(false);
        }

    }
}
