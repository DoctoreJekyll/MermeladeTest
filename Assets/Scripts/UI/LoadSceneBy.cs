using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class LoadSceneBy : MonoBehaviour
    {

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
        
        
    }
}
