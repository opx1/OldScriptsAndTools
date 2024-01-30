using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickEvents2022 : MonoBehaviour
{
   public UnityEvent onClickEvent;

   private void OnMouseDown()
   {
      onClickEvent.Invoke();
   }
}
