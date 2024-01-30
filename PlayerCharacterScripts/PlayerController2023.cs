using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class PlayerController2023 : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 20.0f;
    public float jumpForce = 10f;
    public float leftxRange = 13.0f;
    public float rightxRange = 13.0f;
    public int powerUpDuration = 5;


    public bool isOnGround = true;
    public bool isOnPlatform = true;
    public bool isShooting = false;
    public bool isJumping = false;
    public bool isPowered = false;

    private Rigidbody playerRb;
    private Animator characterAnims;
    public Behaviour playerHalo;
    
    public UnityEvent playSound;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        characterAnims = GetComponent<Animator>();
    }
   
    void Update()
    {
        
        if (transform.position.x < -leftxRange)
        {
            transform.position = new Vector3(-leftxRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightxRange)
        {
            transform.position = new Vector3(rightxRange, transform.position.y, transform.position.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        if (!isShooting && !isJumping)
        {
            transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        }

        if (horizontalInput > 0 && !isShooting)
        {
            characterAnims.SetBool("WalkingForward", true);
        }
        else
        {
            characterAnims.SetBool("WalkingForward", false);
        }
        if (horizontalInput < 0 && !isShooting)
        {
            characterAnims.SetBool("WalkingBackward", true);
        }
        else
        {
            characterAnims.SetBool("WalkingBackward", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && (isOnGround || isOnPlatform) && (!isShooting))
        {
            isJumping = true;
            characterAnims.SetTrigger("Prejump");
        }
        
        if (Input.GetKeyUp(KeyCode.UpArrow) && (isOnGround || isOnPlatform) && (!isShooting))
        {
            isJumping = false;
            characterAnims.SetTrigger("Jump");
            playSound.Invoke();
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            isOnPlatform = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isShooting = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isShooting = false;
        }

        if (isPowered == true)
        {
            jumpForce = 15;
            playerHalo.enabled = true;
            StartCoroutine(PowerupCooldown());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Platform"))
        {
            isOnPlatform = true;
        }
    }
    IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        isPowered = false;
        jumpForce = 10;
        playerHalo.enabled = false;
    }
}

