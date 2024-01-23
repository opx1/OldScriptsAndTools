using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetCollected();
    }

    public void GetCollected()
    {
       Destroy(gameObject); 
    }
}
