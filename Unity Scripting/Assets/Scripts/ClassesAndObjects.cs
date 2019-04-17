using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesAndObjects {

    //Adding public access specifier so that we are able to access
    //these members in Inheritance class directly
    public int health;
    //If we add protected access specifier, then the immediate children of this class will inherit it.
    protected int power;
    //If we add private or do not provide any access specifier, this field will not be inherited by any of this classes children.
    //string name; OR private string name;
    protected string name;

    public ClassesAndObjects()
    {
        health = 100;
        power = 150;
        name = "Warrior";
    }

    public ClassesAndObjects(int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
    }

    public void Info()
    {
        Debug.Log("Player created, Health: " + health + " Power: " + power + " Name: " + name);
    }

    //The keyword virtual is added so that Attack() method can be overriden in child classes
    public virtual void Attack()
    {
        Debug.Log("The player is attacking");
    }
}
