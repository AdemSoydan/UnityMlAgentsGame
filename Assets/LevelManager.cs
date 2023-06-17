using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [SerializeField] MenuController menuController;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    public void onFailed(AgentBase agent)
    {
        MainCharacterController character = GameObject.FindAnyObjectByType<MainCharacterController>();
        agent.Attack();
        character.onCathced();
        menuController.enableAttackedImage();
        StartCoroutine(EnableEndScreen());
    }
    public void onSuccess()
    {
        menuController.enableEndScreen();
    }
    public void onFailedNoAgent()
    {
        MainCharacterController character = GameObject.FindAnyObjectByType<MainCharacterController>();
        character.onCathced();
        StartCoroutine(EnableEndScreen());
    }
    private IEnumerator EnableEndScreen()
    {
        yield return new WaitForSeconds(2.3f);
        menuController.enableEndScreen();
    }

}
