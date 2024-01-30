using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX22021 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
