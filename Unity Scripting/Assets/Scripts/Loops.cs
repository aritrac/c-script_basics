using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //A Normal For Loop
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("Printed From For Loop " + i);
        }

        int a = 0;

        //A Normal While Loop
        while (a < 10)
        {
            Debug.Log("Printed From While Loop " + a);
            a++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
