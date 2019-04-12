using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    void Awake()
    {
        //This will be the first statement to be executed
        //Debug.Log("Printed from Awake method");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Printed from Start method");
        printArgument("This is a function that takes an argument");
        printArgument("Something else");
        printArgument("The value returned is " + returnTheValue());
        printArgument("The value of the numbers is " + calculateTwoNumbers(3,6));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Printed from Update method");
    }

    void printSomething()
    {
        Debug.Log("Printed from function");
    }

    void printArgument(string message)
    {
        Debug.Log(message);
    }

    int returnTheValue()
    {
        return 2;
    }

    int calculateTwoNumbers(int a, int b)
    {
        return a + b;
    }
}
