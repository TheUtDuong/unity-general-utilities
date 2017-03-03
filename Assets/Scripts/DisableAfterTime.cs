using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{
    ///<summary> DisableAfterTime will disable the gameObject after _lifeTimer has elapsed.
    /// Set the "LifeInSeconds" variable in the inspector
    /// As soon as the gameObject is enabled it will begin 
    /// to countdown and will disable itself after the time has elapsed.
    /// </summary>

    //Set in Inspector
    public float LifeInSeconds;

    //Countdown timer
    private float _lifeTimer;

    //Property to determine if the time has elapsed
    private bool TimeElapsed
    {
        get { return _lifeTimer <= Time.time; }
    }


    //Initialize timer once the gameObject has been enabled
    void OnEnable()
    {
        _lifeTimer = Time.time + LifeInSeconds;
    }

    
    void Update()
    {
        //Checks if the time has elapsed
        if(TimeElapsed)
            gameObject.SetActive(false); // Disable the gameobject
    }

}
