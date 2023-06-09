using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private Vector3 offset;

    private void Awake()
    {
        offset = transform.position - character.position;
    }
    private void LateUpdate()
    {
        transform.position = character.position + offset;
        
    }
}
