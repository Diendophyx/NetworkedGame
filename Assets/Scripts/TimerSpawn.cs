using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSpawn : Timer
{
    private GameObject enemy;


    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    public override void TimerTick()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
