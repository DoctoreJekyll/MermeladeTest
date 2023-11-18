using UnityEngine;

namespace General
{
    public class BlockDoor : MonoBehaviour
    {
        private BoxCollider2D doorTrigger;

        [SerializeField] private GameObject necesaryObj;
        
        // Start is called before the first frame update
        void Start()
        {
            doorTrigger = GetComponent<BoxCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {
            doorTrigger.enabled = !HisOBjIsActive();
        }

        private bool HisOBjIsActive()
        {
            return necesaryObj.activeSelf;
        }
    }
}
