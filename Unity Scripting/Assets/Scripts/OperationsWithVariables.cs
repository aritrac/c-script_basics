using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationsWithVariables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        int b = 3;
        int c = a + b;

        Debug.Log("2 + 3 = " + c);

        a = 5;
        b = 2;
        c = a - b;

        Debug.Log("5 - 2 = " + c);

        c = a * b;

        Debug.Log("5 * 2 = " + c);

        c = a / b;

        Debug.Log("5 / 2 = " + c);

        float d = 5f;
        float e = 2f;
        float f = d / e;

        Debug.Log("5 / 2 = " + f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
