using UnityEngine;
using System.Collections;

public class ArraysChallenge2022 : MonoBehaviour
{
    public GameObject[] pc;

    void Start ()
    {
        pc = GameObject.FindGameObjectsWithTag("PlayableCharacter");
        
        for(int i = 0; i < pc.Length; i++)
        {
            Debug.Log("Character Number "+i+" is named "+pc[i].name);
        }
    }
}