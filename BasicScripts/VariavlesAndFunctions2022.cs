using UnityEngine;
using System.Collections;

public class VariavlesAndFunctions2022 : MonoBehaviour
{   
    int myInt = 5;
    
    
    void Start ()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    
    
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}