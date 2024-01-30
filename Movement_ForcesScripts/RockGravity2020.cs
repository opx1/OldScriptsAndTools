using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGravity2020 : MonoBehaviour
{
    public float gravity = -9.81f;
    private Vector3 moveDirection;
    private float yDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection.Set(0,yDirection,0);
    }

    // Update is called once per frame
    void Update()
    {
        yDirection += gravity*Time.deltaTime;
        if (moveDirection.y <0)
        {
            yDirection = -1f;
        }
    }
}
