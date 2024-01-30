using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpJump2023 : MonoBehaviour
{
    public PlayerController playerControllerScript;
    public UnityEvent playSound;

    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            playerControllerScript.isPowered = true;
            playSound.Invoke();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
