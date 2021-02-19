using UnityEngine;
using System.Collections;

// This is the derived class which is also known as a Child
public class Apple : Fruit
{
    // This is the first constructor for the Apple class
    // It calls the parent constructor immediately, before it runs
    public Apple()
    {
        // Notice how Apple has access to the public variable
        // color, which is a part of the parent Fruit
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    // Specifies which parent constructor will be called
    // using the "base" keyword.
    public Apple(string newColor) : base(newColor)
    {
        // Notice how this constructor doesn't set the color
        // since the base constructor sets the color that
        // is passed as an argument
        Debug.Log("2nd Apple Constructor Called");
    }

    // Apple has its own Chop() and SayHello()
    // When running the scripts, notice when Fruit's
    // versions are called and when Apple's are called

    // Override methods override any virtual methods in parent class
    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}