using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces2020 : MonoBehaviour
{
    
    public Rigidbody rBody;
    public float force = 100f;
    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        rBody.AddForce(0, force, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
