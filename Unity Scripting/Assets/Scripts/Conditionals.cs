using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int speed = 5;
        int maxSpeed = 3;
        if (speed >= maxSpeed)
        {
            if(speed > 4)
            {
                Debug.Log("speed is greater than 4");
            }
            Debug.Log("The code is executed for speed >= maxSpeed");
        }else
        {
            Debug.Log("The code is not executed for speed >= maxSpeed");
        }

        if(2 != 3)
        {
            Debug.Log("The code is executed for 2 != 3");
        }

        switch (speed)
        {
            case 1:
                Debug.Log("The speed is 1");
                break;
            case 2:
                Debug.Log("The speed is 2");
                break;
            case 3:
                Debug.Log("The speed is 3");
                break;
            case 4:
                Debug.Log("The speed is 4");
                break;
            default:
                Debug.Log("The default has been executed");
                break;
        }

        //if (speed == 1)
        //{
        //    Debug.Log("The speed is 1");
        //}
        //else if (speed == 2)
        //{
        //    Debug.Log("The speed is 2");
        //}
        //else if (speed == 3)
        //{
        //    Debug.Log("The speed is 3");
        //}
        //else
        //{
        //    Debug.Log("The speed is not equal to 1 2 or 3");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
