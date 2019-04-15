using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesAndObjectsTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ClassesAndObjects warrior = new ClassesAndObjects();
        warrior.Info();

        ClassesAndObjects newWarrior = new ClassesAndObjects(90,175,"Samum");
        newWarrior.Info();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
