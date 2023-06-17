using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public abstract class AgentBase : MonoBehaviour
{
    protected NavMeshAgent agent;
    protected GameObject[] destinations;
    [SerializeField] GameObject destinationsParent;
    protected int current_dest = 0;
    protected float speed = 0;
    
    protected void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        int childCount = destinationsParent.transform.childCount;
        destinations = new GameObject[childCount];
        for (int i = 0; i < destinations.Length; i++)
        {
            destinations[i] = destinationsParent.transform.GetChild(i).gameObject;
        }
    }

    private void Start()
    {
        speed = agent.speed;
        agent.SetDestination(destinations[0].transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("dest") && destinations.Contains(other.gameObject))
        {
            agent.SetDestination(changeDestination().position);
        }
    }

    public abstract void Attack();
    public Transform changeDestination() {
        onChangeDestination();
        if (current_dest == destinations.Length - 1)
        {
            current_dest = 0;
        }
        else
        {  
            current_dest += 1;
        }
        return destinations[current_dest].transform;
    }
    public abstract void onChangeDestination();
}
