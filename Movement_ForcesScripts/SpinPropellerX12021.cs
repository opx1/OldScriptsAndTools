using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX12021 : MonoBehaviour
{

    private float speed = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.back * speed); 
    }
}
