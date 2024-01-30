using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World2020 : SceneController
{
    public Transform player;
    public Transform start1;
    public Transform start2;
    public Transform start3;
    public Vector3 starting1;
    public Vector3 starting2;
    public Vector3 starting3;
    public float holdTime;
    public new IEnumerator Start()
    {
        base.Start();
        starting1 = start1.position;
        starting2 = start2.position;
        starting3 = start3.position;
        yield return new WaitForSeconds(holdTime);

        switch (prevScene)
        {
            case "Switch1":
                player.position = starting1;
                break;
            case "Switch3":
                player.position = starting3;
                break;
            case "Switch2": 
                player.position= starting2;
                break;
            default:
                player.position = starting1;
                break;
        }
    }
   
}
