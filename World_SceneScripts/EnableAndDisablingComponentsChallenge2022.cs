using UnityEngine;
using System.Collections;

public class EnableAndDisablingComponentsChallenge2022 : MonoBehaviour
{
    private Light lampLight;
    
    
    void Start ()
    {
        lampLight = GetComponent<Light>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            lampLight.enabled = !lampLight.enabled;
        }
    }
}