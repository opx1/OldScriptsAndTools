using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation2020 : MonoBehaviour
{
    public float rotateSpeed = 200.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
    }
}
