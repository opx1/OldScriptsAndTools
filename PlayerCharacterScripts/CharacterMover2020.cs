﻿using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover2020 : MonoBehaviour
{
    private CharacterController controller;
    
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 30f;
    private Vector3 moveDirection;
    private float yDirection;
    public GameObject projectilePrefab;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        
        moveDirection.Set(moveSpeedInput,yDirection,0);

        yDirection += gravity*Time.deltaTime;

        if (controller.isGrounded && moveDirection.y <0)
        {
            yDirection = -1f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        } 
        
        controller.Move(moveDirection * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
       
        
    }
}
