using UnityEngine;
///<summary> 
/// UnparentOnDisable will remove this child gameObject from its parent
/// Simply attach it to any object you wish to unparent when it gets disabled
/// </summary>
namespace UtUtils
{
    public class UnparentOnDisable : MonoBehaviour
    {
        public void Disable()
        {
            transform.parent = null;
            gameObject.SetActive(false);
        }
    }
}
