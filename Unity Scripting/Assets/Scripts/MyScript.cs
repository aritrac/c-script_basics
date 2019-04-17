using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    void Awake()
    {
        //Subscribing to the event print of the Tester class. So someFunction() method will be invoked on that event generation and handle it
        Tester.print += someFunction;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Accessing the static member strength of the Player class
        Debug.Log("The value of static member strength of the Player class = " + Player.strength);

        //Accessing the static method printSomething of the Player class
        Player.printSomething();

        Player p1 = new Player();
        Debug.Log("The power is " + p1.GetPower());
        p1.SetPower(56);
        Debug.Log("The power is " + p1.GetPower());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void someFunction()
    {
        Debug.Log("Handling the event");
    }
}
