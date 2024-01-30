﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript2020 : MonoBehaviour
{
   public float moveSpeed;
   private Vector3 moveDirection;


   public void Update()
   {
      if (Input.GetButton("Jump"))
      {
         moveDirection.x = moveSpeed * Time.deltaTime;
      }
      else
      {
         moveDirection.x = -moveSpeed * Time.deltaTime;
      }
      transform.Translate(moveDirection);
   }
}
