using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer12021 : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 10, -10);
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
