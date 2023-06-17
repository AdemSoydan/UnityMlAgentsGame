using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PoliceAgents : AgentBase
{
    [SerializeField] GameObject destinationsParent;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rb;
   
    public override void Attack()
    {
        MainCharacterController character = GameObject.FindAnyObjectByType<MainCharacterController>();
        agent.isStopped = true;
        transform.LookAt(character.transform.position);
        animator.SetTrigger("shoot");
    }

    public override void onChangeDestination()
    {
        return;
    }
}
