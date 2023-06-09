using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PoliceAgents : AgentBase
{
    [SerializeField] GameObject[] destinations;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rb;
    private void Awake()
    {
        base.Awake();
        agent.SetDestination(destinations[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("dest")) {
            agent.SetDestination(changeDestination().position);
        }
    }

    public override void Attack()
    {
        MainCharacterController character = GameObject.FindAnyObjectByType<MainCharacterController>();
        agent.Stop();
        transform.LookAt(character.transform.position);
        animator.SetTrigger("shoot");
    }

    public override void GoToDestination(Transform destination)
    {
        throw new System.NotImplementedException();
    }
    

    public override Transform changeDestination()
    {
        if(current_dest == destinations.Length -1)
        {
            current_dest = 0;
        }
        else
        {
            current_dest += 1;
        }
        return destinations[current_dest].transform;
    }
}
