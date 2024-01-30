//Awake Function goes first, and then the Start function, when called.
using UnityEngine;
using System.Collections;

public class AwakeAndStartChallenge2022 : MonoBehaviour
{
    void Awake ()
    {
        Debug.Log("Awake called.");
    }
    
    
    void Start ()
    {
        Debug.Log("Start called.");
    }
}
