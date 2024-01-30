using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene2020 : MonoBehaviour
{
    [SerializeField] private string toScene;
    private SceneController sceneController;

    private void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            sceneController.LoadScene(toScene);
        }
    }
}
