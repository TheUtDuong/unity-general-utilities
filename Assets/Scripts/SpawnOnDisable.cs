using UnityEngine;
///<summary> 
/// SpawnOnDisable will spawn a gameobject at the same location 
/// when attached object is disabled.
/// </summary>

namespace UtUtils
{
    public class SpawnOnDisable : MonoBehaviour
    {
        //Set Gameobject in the inspector
        public GameObject ObjectToSpawn;

        //Spawn Object when disabled
        private void OnDisable()
        {
            if(ObjectToSpawn != null) // Make sure the ObjectToSpawn is not null
                Instantiate(ObjectToSpawn, transform.position, Quaternion.identity); //Spawn the object at the same location
        }

    }
}
