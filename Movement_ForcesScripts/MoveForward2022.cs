using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward2022 : MonoBehaviour
{
    public float speed = 100f;
    
    void Update()
    {
       transform.Translate(Vector3.down * (Time.deltaTime * speed)); 
    }
}
