using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript_Variables : MonoBehaviour
{
    // this is the player's speed. This is single line comment

    /*
      Multiline 
      Comment
     */

    float speed = 2.3f;
    double power = 4.2;
    int health = 23;
    string name = "Some string here";
    bool isOn = true;

    // Use this for initialization
    void Start()
    {
        speed = 5.1f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
