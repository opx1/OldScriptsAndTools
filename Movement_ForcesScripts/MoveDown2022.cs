using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown2022 : MonoBehaviour
{
    public float speed = 40.0f;
    
    void Update()
    {
        transform.Translate(Vector3.back * (Time.deltaTime * speed)); 
    }
}
