using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy42021 : MonoBehaviour
{
    public float speed;

    private Rigidbody enemyRb;

    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position);
     enemyRb.AddForce(lookDirection.normalized * speed);
     if (transform.position.y < -10)
     {
         Destroy(gameObject);
     }
    }
}
