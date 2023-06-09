using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float velocity;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Animator animatorController;

   
    private void Update()
    {
        Debug.Log("Vertical" +joystick.Vertical + "Horizontal" + joystick.Horizontal);

        rigidbody.velocity = new Vector3(-joystick.Vertical * velocity, 0, joystick.Horizontal * velocity);
        Vector3 movement = new Vector3(-joystick.Vertical * velocity, 0.0f, joystick.Horizontal * velocity);

        if (movement.sqrMagnitude > 0.2f) {
            transform.rotation = Quaternion.LookRotation(movement);
            animatorController.SetBool("walk", true);
        }
        else
        {
            animatorController.SetBool("walk", false);
        }
       
    }
}
