using UnityEngine;
///<summary> 
/// TriggerMessage will send a message to ObjectToInform
/// Uses OnTriggerEnter and OnTriggerExit to inform object
/// Set TargetToTriggerWith to the tag you want to trigger with.
/// </summary>

namespace UtUtils
{
    public class TriggerMessage : MonoBehaviour
    {
        public GameObject ObjectToInform;
        public string TriggerEnterMessage;
        public string TriggerExitMessage;
        public string TargetToTriggerWith;

        void OnTriggerEnter(Collider other)
        {
            if (string.IsNullOrEmpty(TriggerEnterMessage))
                return;
            if (other.CompareTag(TargetToTriggerWith))
                ObjectToInform.SendMessage(TriggerEnterMessage, SendMessageOptions.DontRequireReceiver);
        }

        void OnTriggerExit(Collider other)
        {
            if (string.IsNullOrEmpty(TriggerExitMessage))
                return;
            if (other.CompareTag(TargetToTriggerWith))
                ObjectToInform.SendMessage(TriggerExitMessage, SendMessageOptions.DontRequireReceiver);
        }
    }

}
