﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward2020 : MonoBehaviour
{
    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
