﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer2020 : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    Destroy(other.gameObject);
  }
}
