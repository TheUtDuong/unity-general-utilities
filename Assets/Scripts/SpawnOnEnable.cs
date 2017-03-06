using UnityEngine;
///<summary> 
/// SpawnOnDisable will spawn a gameobject at the same location 
/// when attached object is enabled.
/// </summary>
namespace UtUtils
{
    public class SpawnOnEnable : MonoBehaviour
    {

        public GameObject ObjectToSpawn;
        private void OnEnable()
        {
            if (ObjectToSpawn != null)
                Instantiate(ObjectToSpawn, transform.position, Quaternion.identity);
        }
    }
}

