using UnityEngine;

namespace UI
{
    [CreateAssetMenu(menuName = "TextDialogue")]
    public class TextContenedor : ScriptableObject
    {

        [TextArea(3,6)]
        public string dialogueText;
    }
}
