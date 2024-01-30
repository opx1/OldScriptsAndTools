using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController2020 : MonoBehaviour
{
   public static string prevScene = "";
   public static string currentScene = "";

   public void Start()
   {
      currentScene = SceneManager.GetActiveScene().name;
   }

   public void LoadScene(string sceneName)
   {
      prevScene = currentScene;
      SceneManager.LoadScene(sceneName);
   }
}
