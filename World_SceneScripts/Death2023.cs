using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death2023 : MonoBehaviour
{
    public UnityEvent playSound;
    public Animator characterAnims;
    public PlayerController playerControllerScript;
    private Text death;
    public UnityEvent deathEvent;


    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        death = GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        playSound.Invoke();
        if (collision.gameObject.CompareTag("Player"))
        {
            playerControllerScript.isJumping = true;
            characterAnims.SetTrigger("Death");
            playSound.Invoke();
            deathEvent.Invoke();
            Invoke("ReloadScene", 1);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

