using UnityEngine;
using System.Collections;

public class LookAtChallenge2022 : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}