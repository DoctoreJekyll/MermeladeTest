using UnityEngine;

namespace UI
{
    public class StartDisable : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            this.gameObject.SetActive(false);
        }
    }
}
