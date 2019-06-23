using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 3f;
    

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 3;
            TimerTick();
        }
    }

    public virtual void TimerTick()
    {
        Debug.Log("ThisFunctionShouldNotBeRunning");
    }
}
