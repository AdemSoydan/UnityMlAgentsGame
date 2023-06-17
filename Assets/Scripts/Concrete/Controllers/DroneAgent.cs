using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DroneAgent : AgentBase
{
    private void Awake()
    {
        base.Awake();
       
    }
    public override void Attack()
    {
        agent.isStopped = true;
    }
    public override void onChangeDestination()
    {
        int increaseOrDecraseSpeed = Random.Range(0, 2);
        float amount = Random.Range(0, .3f);
        if (increaseOrDecraseSpeed == 0)
        {
            speed += amount;
        }
        else {
            speed -= amount;
        }
    }
}
