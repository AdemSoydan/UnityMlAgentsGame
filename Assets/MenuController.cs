using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject endScreen;

    public void enableEndScreen()
    {
        endScreen.SetActive(true);
    }
}
