using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class AgentBase : MonoBehaviour
{
    protected NavMeshAgent agent;
    protected int current_dest = 0;
    protected void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public abstract void GoToDestination(Transform destination);
    public abstract void Attack();
    public abstract Transform changeDestination();
}
