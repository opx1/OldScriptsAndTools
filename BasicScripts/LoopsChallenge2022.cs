//For Loops
using UnityEngine;
using System.Collections;

public class LoopsChallenge2022 : MonoBehaviour
{
    int numEnemies = 3;
    
    
    void Start ()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}

//While Loop
using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;
    
    
    void Start ()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}

//Do While Loop
using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{
    void Start()
    {
        bool shouldContinue = false;
        
        do
        {
            print ("Hello World");
            
        }while(shouldContinue == true);
    }
}

//Foreach Loop
using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}
