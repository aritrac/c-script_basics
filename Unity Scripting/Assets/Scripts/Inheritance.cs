using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheriting ClassesAndObjects class
public class Inheritance : ClassesAndObjects
{
    public Inheritance()
    {
        health = 100;
        power = 200;
        name = "Warrior";
    }

    //Overriding the Attack() method inherited from ClassesAndObjects
    public override void Attack()
    {
        Debug.Log("The WARRIOR is attacking");
    }
}
