using System;
using System.Collections;
using General;
using UnityEngine;

namespace Enemy
{
    public class KillPlayer : MonoBehaviour
    {

        [SerializeField] private GameObject player;
        [SerializeField] private Transform newPlayerPos;
        [SerializeField] private Transform newEnemyPos;
        [SerializeField] private Animator fadeAnimator;

        private bool playerIsDead;

        private void Update()
        {
            KillByPos();
        }

        private void KillByPos()
        {
            if (Vector2.Distance(this.transform.position, player.transform.position) < 0.3f && !playerIsDead)
            {
                StartCoroutine(Kill());
            }
        }

        private IEnumerator Kill()
        {
            GameStatusController.instance.ChangeGameStatusTo(GameStatusController.GameStatus.None);
            fadeAnimator.Play("FadeInAnim");
            yield return new WaitForSeconds(1f);
            playerIsDead = true;
            player.transform.position = newPlayerPos.position;
            transform.position = newEnemyPos.position;

            yield return new WaitForSeconds(1f);
            playerIsDead = false;
            fadeAnimator.Play("FadeAnim");
            GameStatusController.instance.ChangeGameStatusTo(GameStatusController.GameStatus.Gameplay);
            
        }


    }
}
