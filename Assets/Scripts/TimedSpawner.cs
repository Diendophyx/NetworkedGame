using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public float timerSeconds; // gets a value to set to the value of the nested classes value
    public float endTimeTime;   // gets a value to set to the value of the nested classes value
    public GameObject enemyprefab; // prefab to instantiate

    private void Start()
    {
        TimerData timerdata = new TimerData(); // made it so i could acess the class by typing timerdata.variable
        timerSeconds = timerdata.timer; // sets timerseconds to the values that were initialised within the nested class
        endTimeTime = timerdata.endtime; // sets endvalue to the value initialised within the nested class
    }

    private void Update()
    {
        timerSeconds -= Time.deltaTime; // countdown from 5 (the 5 was initialised in the nested class the accessed outside of it)
        if (timerSeconds <= endTimeTime) // after 5 seconds has passed 
        {
            Instantiate(enemyprefab, transform.position, transform.rotation); // spawn an enemy on this gameobject 
            timerSeconds = 5; // set timer back to 5
        }
    }

    public class TimerData
    {
        // values that we want to initialise 
        public float timer; // how long the timer is
        public float endtime; // at what point we want the timer to end (it's a countdown timer)
            
        //constructor
        public TimerData()
        {
            this.timer = 5f; // sets the values to 5
            this.endtime = 0f; // sets the values to 0
        }
    }
}
