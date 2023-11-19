using System;
using UnityEngine;

namespace General
{
    public class GameStatusController : MonoBehaviour
    {

        #region Singleton
        public static GameStatusController instance { get; private set; }

        private void Awake()
        {
            Time.timeScale = 1;
            
            if (instance != null && instance != this)
            {
                Destroy(this);
            }
            else
            {
                instance = this;
            }
        }

        #endregion

        public enum GameStatus
        {
            Gameplay,
            Dialogue,
            Start,
            None
        }

        public GameStatus gameStatus;

        public GameObject lastGameObj;

        private void Start()
        {
            ChangeGameStatusTo(GameStatus.Gameplay);
        }

        public void ChangeGameStatusTo(GameStatus newStatus)
        {
            gameStatus = newStatus;
        }

        public bool IsOnGameplay()
        {
            return gameStatus == GameStatus.Gameplay;
        }

        public void SetLastGameObj(GameObject gObj)
        {
            lastGameObj = gObj;
        }

        public void ActivateLastObj()
        {
            lastGameObj.SetActive(true);
        }

    }
}
