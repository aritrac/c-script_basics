using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    //Creating a static member for this class and initializing it
    public static int strength = 120;

    //Making the power member private
    private int power;
    //Making the health member private
    private int health;
    //Making the name member private
    private string name;

    public Player()
    {
        power = 100;
        health = 100;
        name = "Warrior";
    }

    //Creating a static function
    public static void printSomething()
    {
        Debug.Log("This is the static print method");
    }

    //Defining getters and setters for the member power to manipulate it from outside of this class
    public void SetPower(int power)
    {
        this.power = power;
    }

    public int GetPower()
    {
        return this.power;
    }
}
