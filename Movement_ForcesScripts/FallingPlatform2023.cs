using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FallingPlatform2023 : MonoBehaviour
{
    public Rigidbody rb;
    public UnityEvent playSound;
  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            playSound.Invoke();
            rb.useGravity = true;
        }
    }
}