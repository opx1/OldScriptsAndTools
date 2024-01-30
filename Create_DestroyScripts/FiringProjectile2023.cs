using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FiringProjectile2023 : MonoBehaviour
{
    public Rigidbody projectilePrefab;
    public bool isShooting = false;
    public Transform barrelEnd;
    public Quaternion ogPosition;
    public float rotationSpeed = 10f;
    public float shootForce = 200f;
    public UnityEvent playSound;

    private void Start()
    {
        ogPosition = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isShooting = true;
        }

        if (isShooting)
        {
            // Get the rotation input from the user.
            float rotationInput = Input.GetAxis("Horizontal");

            // Calculate the rotation angle based on input and speed.
            float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

            // Rotate the object around its local up axis (z-axis).
            transform.Rotate(Vector3.forward, rotationAmount);
            
            // Shooting the projectile with the Space key.
            if (Input.GetKeyUp(KeyCode.Space))
            {
                ShootProjectile();
                isShooting = false;
                transform.rotation = ogPosition;
            }
        }
    }

    void ShootProjectile()
    {
        playSound.Invoke();
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectilePrefab, barrelEnd.position, barrelEnd.rotation);
        projectileInstance.AddForce(barrelEnd.up * shootForce);
    }
}