using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesAndObjects {

    int health;
    int power;
    string name;

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
}
