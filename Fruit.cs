using UnityEngine;
using System.Collections;

// This is the base class which is also known as the Parent
public class Fruit
{
    public string color;

    // This is the first constructor for the Fruit class
    // and is not inheirted by any derived classes
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    // This is the second constructor for the Fruit class
    // and is not inherited by any derived classes
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    // These methods are virtual and this can be overridden in child classes
    public virtual void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}