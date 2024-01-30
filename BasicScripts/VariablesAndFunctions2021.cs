using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions2021 : MonoBehaviour
{
    private int myInt = 5;
    private int myNum = 50;
    private void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
